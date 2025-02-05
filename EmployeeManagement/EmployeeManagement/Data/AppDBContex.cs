
using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;


namespace EmployeeManagement.Data
{
    public class AppDBContex : DbContext
    {   
        public DbSet<Employee> Employees { get; set; }

        public AppDBContex(DbContextOptions<AppDBContex> options)
            : base(options) { }
    }
}
