using Microsoft.EntityFrameworkCore;
using UserService.Application.Interface;
using UserService.Domain;

namespace UserService.Persistance
{
    public class Context : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Config());
            base.OnModelCreating(modelBuilder);
        }
    }
}
