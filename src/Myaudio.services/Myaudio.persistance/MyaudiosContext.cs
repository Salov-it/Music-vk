using Microsoft.EntityFrameworkCore;
using Myaudio.Domain;

namespace Myaudio.persistance
{
    public class MyaudiosContext : DbContext
    {
        public DbSet<Myaudios> myaudios => Set<Myaudios>();
        public MyaudiosContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MyaudioBasse.db");
        }
    }
}
