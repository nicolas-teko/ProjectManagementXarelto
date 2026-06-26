using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectManagementXarelto.Core.Models;
using ProjectManagementXarelto.Data.Context;

namespace ProjectManagementXarelto.Web.Controllers;

public class AccountController(AppDbContext context) : Controller
{
    public async Task<IActionResult> Index()
    {
        if (HttpContext.Session.GetInt32("CurrentUserId") is not null)
        {
            return RedirectToAction("Index", "Projects");
        }

        var users = await context.Users.AsNoTracking().OrderBy(u => u.Id).ToListAsync();
        return View(users);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Choose(RoleType role)
    {
        var user = await context.Users.SingleOrDefaultAsync(u => u.Role == role);
        if (user is null)
        {
            TempData["Error"] = "Die ausgewählte Rolle ist nicht verfügbar.";
            return RedirectToAction(nameof(Index));
        }

        HttpContext.Session.SetInt32("CurrentUserId", user.Id);
        HttpContext.Session.SetString("CurrentUserName", user.DisplayName);
        HttpContext.Session.SetString("CurrentUserRole", RoleLabel(user.Role));
        return RedirectToAction("Index", "Projects");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction(nameof(Index));
    }

    private static string RoleLabel(RoleType role) => role == RoleType.ProjectLead
        ? "Projektleiter"
        : "Projektmitarbeiter";
}
