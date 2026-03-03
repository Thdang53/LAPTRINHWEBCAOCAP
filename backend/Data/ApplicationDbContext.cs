using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        // Khai báo các bảng sẽ xuất hiện trong MySQL
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}