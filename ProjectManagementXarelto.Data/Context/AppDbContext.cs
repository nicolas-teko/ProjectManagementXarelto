using Microsoft.EntityFrameworkCore;
using ProjectManagementXarelto.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementXarelto.Data.Context {
    public class AppDbContext : DbContext {
        public DbSet<User> Users => Set<User>();
        public DbSet<Project> Projects => Set<Project>();
        public DbSet<Information> Informations => Set<Information>();
        public DbSet<Comment> Comments => Set<Comment>();
        public DbSet<InfoTag> InfoTags => Set<InfoTag>();
        public DbSet<InfoLink> InfoLinks => Set<InfoLink>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            // ===== USER =====
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .IsRequired()
                .HasMaxLength(200);

            // ===== PROJECT =====
            modelBuilder.Entity<Project>()
                .Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<Project>()
                .Property(p => p.CustomerName)
                .IsRequired()
                .HasMaxLength(200);

            modelBuilder.Entity<Project>()
                .HasOne(p => p.ProjectLeadUser)
                .WithMany()
                .HasForeignKey(p => p.ProjectLeadUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Project>()
                .HasMany(p => p.Informations)
                .WithOne(i => i.Project!)
                .HasForeignKey(i => i.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            // ===== INFORMATION =====
            modelBuilder.Entity<Information>()
                .Property(i => i.Text)
                .IsRequired();

            modelBuilder.Entity<Information>()
                .HasMany(i => i.Comments)
                .WithOne(c => c.Information!)
                .HasForeignKey(c => c.InformationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Information>()
                .HasMany(i => i.Tags)
                .WithOne(t => t.Information!)
                .HasForeignKey(t => t.InformationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Information>()
                .HasMany(i => i.Links)
                .WithOne(l => l.Information!)
                .HasForeignKey(l => l.InformationId)
                .OnDelete(DeleteBehavior.Cascade);

            // ===== INFOTAG =====
            modelBuilder.Entity<InfoTag>()
                .Property(t => t.Tag)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<InfoTag>()
                .HasIndex(t => new { t.InformationId, t.Tag })
                .IsUnique(); // kein doppeltes Tag pro Info

            // ===== INFOLINK =====
            modelBuilder.Entity<InfoLink>()
                .Property(l => l.Url)
                .IsRequired();
        }
    }
}
