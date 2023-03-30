using Microsoft.EntityFrameworkCore;

namespace Aplikacja_Internetowa.Models
{
    public class TaskManagerContext : DbContext
    {
        public TaskManagerContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<TaskModel> Tasks { get; set; }
    }
}
