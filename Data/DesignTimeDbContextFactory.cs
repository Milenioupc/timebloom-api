using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PomodoroApp.Api.Data
{
    public class DesignTimeDbContextFactory
      : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseNpgsql(

              "Host=servertm.postgres.database.azure.com;Port=5432;Database=Timebloom;Username=admintm;Password=Tm123789+;SSL Mode=Require"
            );
            return new ApplicationDbContext(builder.Options);
        }
    }
}
