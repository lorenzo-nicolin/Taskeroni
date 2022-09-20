using Microsoft.EntityFrameworkCore;

namespace Taskeroni.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<NewTasks> Tasks { get; set; }

    }
}
