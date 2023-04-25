using Microsoft.EntityFrameworkCore;
using MyRecommendationsService.Application.Interface;
using MyRecommendationsService.Domain;

namespace MyRecommendationsService.persistance
{
    public class Context : DbContext, IContext
    {
        public DbSet<Audio> Audios { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Config());
            base.OnModelCreating(modelBuilder);
        }
    }
}
