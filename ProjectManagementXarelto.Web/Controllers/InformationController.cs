using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagementXarelto.Core.Models;
using ProjectManagementXarelto.Data.Context;
using ProjectManagementXarelto.Web.Models;

namespace ProjectManagementXarelto.Web.Controllers;

public class InformationController(AppDbContext context) : Controller
{
    [HttpGet]
    public async Task<IActionResult> Create(int projectId)
    {
        if (await GetCurrentUserAsync() is null) return RedirectToLogin();
        var project = await context.Projects.AsNoTracking().SingleOrDefaultAsync(p => p.Id == projectId);
        if (project is null) return NotFound();
        ViewBag.Project = project;
        return View(new InformationFormModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(int projectId, InformationFormModel model)
    {
        var user = await GetCurrentUserAsync();
        if (user is null) return RedirectToLogin();
        var projectExists = await context.Projects.AnyAsync(p => p.Id == projectId);
        if (!projectExists) return NotFound();
        if (!ModelState.IsValid)
        {
            ViewBag.Project = await context.Projects.AsNoTracking().SingleAsync(p => p.Id == projectId);
            return View(model);
        }

        var information = new Information
        {
            ProjectId = projectId,
            Text = model.Text.Trim(),
            CreatedAt = DateTime.UtcNow,
            CreatedByUserId = user.Id
        };
        context.Informations.Add(information);
        await context.SaveChangesAsync();
        TempData["Success"] = "Information wurde gespeichert. Du kannst jetzt Tags, Links und Kommentare ergänzen.";
        return RedirectToAction(nameof(Edit), new { id = information.Id });
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        if (await GetCurrentUserAsync() is null) return RedirectToLogin();
        var information = await LoadInformationAsync(id);
        if (information is null) return NotFound();
        return View(new InformationEditViewModel
        {
            Information = information,
            Form = new InformationFormModel { Text = information.Text }
        });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, InformationFormModel model)
    {
        var user = await GetCurrentUserAsync();
        if (user is null) return RedirectToLogin();
        var information = await LoadInformationAsync(id);
        if (information is null) return NotFound();
        if (!ModelState.IsValid)
        {
            return View(new InformationEditViewModel { Information = information, Form = model });
        }

        information.Text = model.Text.Trim();
        information.UpdatedAt = DateTime.UtcNow;
        information.UpdatedByUserId = user.Id;
        await context.SaveChangesAsync();
        TempData["Success"] = "Information wurde aktualisiert.";
        return RedirectToAction(nameof(Edit), new { id });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddTag(int informationId, string tag)
    {
        if (await GetCurrentUserAsync() is null) return RedirectToLogin();
        var information = await LoadInformationAsync(informationId);
        if (information is null) return NotFound();
        var value = tag.Trim();
        if (string.IsNullOrWhiteSpace(value)) TempData["Error"] = "Ein Tag darf nicht leer sein.";
        else if (information.Tags.Count >= 3) TempData["Error"] = "Pro Information sind maximal drei Tags erlaubt.";
        else if (information.Tags.Any(t => t.Tag.Equals(value, StringComparison.OrdinalIgnoreCase))) TempData["Error"] = "Dieser Tag ist bereits vorhanden.";
        else
        {
            context.InfoTags.Add(new InfoTag { InformationId = information.Id, Tag = value });
            await context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Edit), new { id = informationId });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RemoveTag(int id)
    {
        if (await GetCurrentUserAsync() is null) return RedirectToLogin();
        var tag = await context.InfoTags.SingleOrDefaultAsync(t => t.Id == id);
        if (tag is null) return NotFound();
        var informationId = tag.InformationId;
        context.InfoTags.Remove(tag);
        await context.SaveChangesAsync();
        return RedirectToAction(nameof(Edit), new { id = informationId });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddLink(int informationId, LinkType type, string url)
    {
        if (await GetCurrentUserAsync() is null) return RedirectToLogin();
        var information = await LoadInformationAsync(informationId);
        if (information is null) return NotFound();
        if (!Uri.TryCreate(url.Trim(), UriKind.Absolute, out var uri) || (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
        {
            TempData["Error"] = "Bitte gib eine gültige HTTP(S)-URL ein.";
        }
        else
        {
            context.InfoLinks.Add(new InfoLink { InformationId = informationId, Type = type, Url = uri.ToString() });
            await context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Edit), new { id = informationId });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> RemoveLink(int id)
    {
        if (await GetCurrentUserAsync() is null) return RedirectToLogin();
        var link = await context.InfoLinks.SingleOrDefaultAsync(l => l.Id == id);
        if (link is null) return NotFound();
        var informationId = link.InformationId;
        context.InfoLinks.Remove(link);
        await context.SaveChangesAsync();
        return RedirectToAction(nameof(Edit), new { id = informationId });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> AddComment(int informationId, string text)
    {
        var user = await GetCurrentUserAsync();
        if (user is null) return RedirectToLogin();
        var information = await LoadInformationAsync(informationId);
        if (information is null) return NotFound();
        if (string.IsNullOrWhiteSpace(text)) TempData["Error"] = "Ein Kommentar darf nicht leer sein.";
        else
        {
            context.Comments.Add(new Comment
            {
                InformationId = informationId,
                Text = text.Trim(),
                CreatedAt = DateTime.UtcNow,
                CreatedByUserId = user.Id
            });
            await context.SaveChangesAsync();
        }
        return RedirectToAction(nameof(Edit), new { id = informationId });
    }

    private async Task<Information?> LoadInformationAsync(int id) => await context.Informations
        .Include(i => i.Project)
        .Include(i => i.Tags)
        .Include(i => i.Links)
        .Include(i => i.Comments)
        .SingleOrDefaultAsync(i => i.Id == id);

    private async Task<User?> GetCurrentUserAsync()
    {
        var id = HttpContext.Session.GetInt32("CurrentUserId");
        return id is null ? null : await context.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == id);
    }

    private IActionResult RedirectToLogin() => RedirectToAction("Index", "Account");
}
