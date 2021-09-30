
using Microsoft.EntityFrameworkCore;

namespace PlannerAPI.Models
{
    public class TodoDbContext : DbContext
    {
        public TodoDbContext(DbContextOptions options) : base(options)
        {
        }

        protected TodoDbContext()
        {
        }
        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<Person> Person { get; set; }
    }
}

