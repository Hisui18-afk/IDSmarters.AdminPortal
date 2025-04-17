using IDSmarters.AdminPortal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IDSmarters.AdminPortal.Data.Migrations
{
    public class IDSmarterDbContext : IdentityDbContext
    {
        public IDSmarterDbContext(DbContextOptions<IDSmarterDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fix AdminDashboard relationships
            modelBuilder.Entity<AdminDashboard>()
                .HasOne(a => a.DeanDashboards)
                .WithMany(d => d.AdminDashoards)
                .HasForeignKey(a => a.DeanDashboardId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<AdminDashboard>()
                .HasOne(a => a.InstructorDashboards)
                .WithMany(i => i.AdminDashoards)
                .HasForeignKey(a => a.InstructorDashboardId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<AdminDashboard>()
                .HasOne(a => a.StudentDashboards)
                .WithMany(s => s.AdminDashoards)
                .HasForeignKey(a => a.StudentDashboardId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            // Fix DeanDashboard relationships
            modelBuilder.Entity<DeanDashboard>()
                .HasOne(d => d.InstructorDashboards)
                .WithMany(i => i.DeanDashboards)
                .HasForeignKey(d => d.InstructorDashboardId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            modelBuilder.Entity<DeanDashboard>()
                .HasOne(d => d.StudentDashboards)
                .WithMany(s => s.DeanDashboards)
                .HasForeignKey(d => d.StudentDashboardId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            // Fix InstructorDashboard relationships
            modelBuilder.Entity<InstructorDashboard>()
                .HasOne(i => i.StudentDashboards)
                .WithMany()
                .HasForeignKey(i => i.StudentDashboardId)
                .OnDelete(DeleteBehavior.ClientNoAction);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<IDSmarters.AdminPortal.Models.AdminDashboard> AdminDashboard { get; set; } = default!;

        public DbSet<IDSmarters.AdminPortal.Models.DeanDashboard> DeanDashboard { get; set; } = default!;

        public DbSet<IDSmarters.AdminPortal.Models.InstructorDashboard> InstructorDashboard { get; set; } = default!;

        public DbSet<IDSmarters.AdminPortal.Models.PreRegistration> PreRegistration { get; set; } = default!;

        public DbSet<IDSmarters.AdminPortal.Models.StudentDashboard> StudentDashboard { get; set; } = default!;
        public DbSet<IDSmarters.AdminPortal.Models.Course> Courses { get; set; } = default!;
        public DbSet<IDSmarters.AdminPortal.Models.DepProgram> DepPrograms { get; set; } = default!;
        public DbSet<IDSmarters.AdminPortal.Models.Enrollment> Enrollments { get; set; } = default!;
        public DbSet<IDSmarters.AdminPortal.Models.InstructorsDetail> InstructorDetails { get; set; } = default!;
        public DbSet<IDSmarters.AdminPortal.Models.Schedule> Schedules { get; set; } = default!;
        public DbSet<IDSmarters.AdminPortal.Models.Strand> Strands { get; set; } = default!;
        public DbSet<IDSmarters.AdminPortal.Models.StudentDetail> StudentDetails { get; set; } = default!;


    }
}
