using Microsoft.EntityFrameworkCore;
using MyRecommendationsService.Domain;

namespace MyRecommendationsService.persistance
{
    public class Context : DbContext
    {
        public DbSet<Audio> audios => Set<Audio>();
        public Context() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyaudioBasse.db");
        }
    }
}
