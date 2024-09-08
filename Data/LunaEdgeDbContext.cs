using LunaEdgeTestTask.Models;
using Microsoft.EntityFrameworkCore;

namespace LunaEdgeTestTask.Data
{
    public class LunaEdgeDbContext : DbContext
    {
        DbSet<Models.Task> Tasks { get; set; }
        DbSet<User> Users { get; set; }

        public LunaEdgeDbContext()
        {
            
        }
        public LunaEdgeDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
