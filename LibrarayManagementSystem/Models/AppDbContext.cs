using Microsoft.EntityFrameworkCore;

namespace LibrarayManagementSystem.Models
{
	public class AppDbContext : DbContext
	{
		public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;database=libraray_management_sys;uid=root;pwd=");
        }
    }
}

