using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base (option)
        {
                
        }
        public DbSet<Employee> TblEmployeeTemp { get; set; }
    }
}
