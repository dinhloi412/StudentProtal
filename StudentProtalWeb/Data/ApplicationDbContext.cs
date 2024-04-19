using Microsoft.EntityFrameworkCore;
using StudentProtalWeb.Models.Entities;

namespace StudentProtalWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) // ctor
        {
               
        }

        public DbSet<Student> Students { get; set; }
        
    }
}
