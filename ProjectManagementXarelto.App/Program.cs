using Microsoft.EntityFrameworkCore;
using ProjectManagementXarelto.Data.Context;
using ProjectManagementXarelto.Data.Seed;

namespace ProjectManagementXarelto.App
{
    internal static class Program {
        public static AppDbContext DbContext { get; private set; } = null!;

        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();

            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite("Data Source=projectmanagement.db")
                .Options;

            DbContext = new AppDbContext(options);

            DbContext.Database.Migrate();
            DbSeeder.SeedUsers(DbContext);

            Application.Run(new Form1());
        }
    }
}

