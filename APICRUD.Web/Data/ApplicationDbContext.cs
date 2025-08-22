using APICRUD.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace APICRUD.Web.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
