using Microsoft.EntityFrameworkCore;
using SurveyAndVoting.Models;
using System.Xml;

namespace SurveyAndVoting.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Survey> Surveys { get; set; }
        public DbSet<Option> Options { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Survey>()
            .HasMany(s => s.Options)
            .WithOne(o => o.Survey)
            .HasForeignKey(o => o.SurveyId);

            modelBuilder.Entity<Survey>()
                .HasMany(s => s.Accounts)
                .WithMany(a => a.Surveys)
                .UsingEntity(j => j.ToTable("SurveyorSurveys"));

            modelBuilder.Entity<Option>()
                .HasMany(o => o.Accounts)
                .WithMany(a => a.Options)
                .UsingEntity(j => j.ToTable("SurveyedOptions"));

            // Configurar la conversión de Role
            modelBuilder.Entity<Account>()
                .Property(a => a.Role)
                .HasConversion<string>();
        }


    }
}
