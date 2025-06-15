using Microsoft.EntityFrameworkCore;
using PomodoroApp.Api.Models;
namespace PomodoroApp.Api.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Aquí corregimos el tipo genérico de us a User:
        public DbSet<User> Users { get; set; } = null!;

        public DbSet<TaskItemDto> Tasks { get; set; } = null!;
        // public DbSet<PomodoroSession> PomodoroSessions { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuraciones adicionales del modelo si las necesitas
        }
    }
}
