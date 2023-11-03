using LibrarayManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarayManagementSystem.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    public DbSet<UserRole> UserRoles {get;set;}
}
