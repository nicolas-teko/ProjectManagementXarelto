using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagementXarelto.Core.Models;
using ProjectManagementXarelto.Data.Context;
using ProjectManagementXarelto.Web.Models;

namespace ProjectManagementXarelto.Web.Controllers;

public class ProjectsController(AppDbContext context) : Controller
{
    public async Task<IActionResult> Index()
    {
        var user = await GetCurrentUserAsync();
        if (user is null) return RedirectToLogin();

        var projects = await context.Projects
            .AsNoTracking()
            .Include(p => p.ProjectLeadUser)
            .OrderBy(p => p.Name)
            .Select(p => new ProjectListItem
            {
                Id = p.Id,
                Name = p.Name,
                CustomerName = p.CustomerName,
                ProjectLeadName = p.ProjectLeadUser != null ? p.ProjectLeadUser.DisplayName : "—",
                CreatedAt = p.CreatedAt,
                InformationCount = p.Informations.Count
            })
            .ToListAsync();

        return View(new ProjectsIndexViewModel
        {
            UserName = user.DisplayName,
            CanCreateProjects = user.Role == RoleType.ProjectLead,
            Projects = projects
        });
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var user = await GetCurrentUserAsync();
        if (user is null) return RedirectToLogin();
        if (user.Role != RoleType.ProjectLead) return Forbid();
        return View(new ProjectFormModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ProjectFormModel model)
    {
        var user = await GetCurrentUserAsync();
        if (user is null) return RedirectToLogin();
        if (user.Role != RoleType.ProjectLead) return Forbid();
        if (!ModelState.IsValid) return View(model);

        var project = new Project
        {
            Name = model.Name.Trim(),
            CustomerName = model.CustomerName.Trim(),
            InitialDescription = model.InitialDescription?.Trim() ?? string.Empty,
            ProjectLeadUserId = user.Id,
            CreatedByUserId = user.Id,
            CreatedAt = DateTime.UtcNow
        };

        context.Projects.Add(project);
        await context.SaveChangesAsync();
        TempData["Success"] = "Projekt wurde erstellt.";
        return RedirectToAction(nameof(Details), new { id = project.Id });
    }

    public async Task<IActionResult> Details(int id, string? tag)
    {
        if (await GetCurrentUserAsync() is null) return RedirectToLogin();

        var project = await context.Projects
            .AsNoTracking()
            .Include(p => p.ProjectLeadUser)
            .SingleOrDefaultAsync(p => p.Id == id);
        if (project is null) return NotFound();

        IQueryable<Information> informationQuery = context.Informations
            .AsNoTracking()
            .Where(i => i.ProjectId == id)
            .Include(i => i.Tags)
            .Include(i => i.Comments)
            .Include(i => i.Links);

        if (!string.IsNullOrWhiteSpace(tag))
        {
            informationQuery = informationQuery.Where(i => i.Tags.Any(t => t.Tag == tag));
        }

        var informations = await informationQuery
            .OrderByDescending(i => i.UpdatedAt ?? i.CreatedAt)
            .Select(i => new InformationListItem
            {
                Id = i.Id,
                Text = i.Text,
                CreatedAt = i.CreatedAt,
                UpdatedAt = i.UpdatedAt,
                Tags = i.Tags.OrderBy(t => t.Tag).Select(t => t.Tag).ToList(),
                CommentCount = i.Comments.Count,
                LinkCount = i.Links.Count
            })
            .ToListAsync();

        var availableTags = await context.InfoTags
            .AsNoTracking()
            .Where(t => t.Information!.ProjectId == id)
            .Select(t => t.Tag)
            .Distinct()
            .OrderBy(t => t)
            .ToListAsync();

        return View(new ProjectDetailsViewModel
        {
            Project = project,
            Informations = informations,
            AvailableTags = availableTags,
            ActiveTag = tag
        });
    }

    private async Task<User?> GetCurrentUserAsync()
    {
        var id = HttpContext.Session.GetInt32("CurrentUserId");
        return id is null ? null : await context.Users.AsNoTracking().SingleOrDefaultAsync(u => u.Id == id);
    }

    private IActionResult RedirectToLogin() => RedirectToAction("Index", "Account");
}
