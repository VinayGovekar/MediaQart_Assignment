using MediaQart_Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace MediaQart_Assignment.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

    }
}
