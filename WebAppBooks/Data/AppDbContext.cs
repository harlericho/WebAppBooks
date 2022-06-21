using Microsoft.EntityFrameworkCore;
using WebAppBooks.Models;

namespace WebAppBooks.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
        public DbSet<BookModel> Books { get; set; }
    } 
}
