using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Controllers.DataAccessLayer
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-090J43E4\\MSSQLSERVERBATI;database=CoreAPIDB; integrated security=true;");// User Instance=true;           
        }
        
        public DbSet<Employee> Employees { get; set; }

    }
}
