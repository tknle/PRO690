using Microsoft.EntityFrameworkCore;
using ProjectMVCExample.Models;

namespace ProjectMVCExample.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
