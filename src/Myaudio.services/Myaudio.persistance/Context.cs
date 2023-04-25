using Microsoft.EntityFrameworkCore;
using Myaudio.Application.CQRS.Interface;
using Myaudio.Domain;

namespace Myaudio.persistance
{
    public class Context : DbContext ,IContext
    {
        public DbSet<Myaudios> Myaudio { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Config());
            base.OnModelCreating(modelBuilder);
        }

        
    }
}
