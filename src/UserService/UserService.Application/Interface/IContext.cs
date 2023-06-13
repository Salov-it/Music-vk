using Microsoft.EntityFrameworkCore;
using UserService.Domain;

namespace UserService.Application.Interface
{
    public interface IContext
    {
        public DbSet<User> Users { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
