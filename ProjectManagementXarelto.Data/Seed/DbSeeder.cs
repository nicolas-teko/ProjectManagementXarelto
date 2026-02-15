using ProjectManagementXarelto.Core.Models;
using ProjectManagementXarelto.Data.Context;

namespace ProjectManagementXarelto.Data.Seed;

public static class DbSeeder {
    public static void SeedUsers(AppDbContext context) {
        if (context.Users.Any())
            return;

        context.Users.AddRange(
            new User { DisplayName = "Projektleiter", Role = RoleType.ProjectLead },
            new User { DisplayName = "Projektmanager", Role = RoleType.ProjectManager }
        );

        context.SaveChanges();
    }
}
