using Microsoft.EntityFrameworkCore;

namespace TaskMVC.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=RITG;Trusted_Connection=True;");
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                    new Role { Id = 1, Name = "Administrator" },
                    new Role { Id = 2, Name = "Reporter" }
                );
            modelBuilder.Entity<User>().HasData(
                    new User { Id = 1, Login = "administrator", Password = "administrator", RoleId = 1 },
                    new User { Id = 2, Login = "reporter", Password = "reporter", RoleId = 2 }
                );
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<News> News { get; set; }
    }
}
