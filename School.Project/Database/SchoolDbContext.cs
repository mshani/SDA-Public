using Microsoft.EntityFrameworkCore;
using SchoolProject.Entities;
using System.Reflection.Metadata;

namespace SchoolProject.Database
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        { }
        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Address> Addresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("AppDb");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.ToTable("Students");
                entity.Property(e => e.Name)
                    .HasColumnName("Name")
                    .HasMaxLength(50)
                    .IsRequired();
                entity.Property(e => e.Surname)
                    .HasColumnName("Surname")
                    .HasMaxLength(50)
                    .IsRequired();
                entity.Property(e => e.Age)
                        .HasColumnName("Age")
                        .IsRequired();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Id);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.Id);
            });
        }
     }
}
