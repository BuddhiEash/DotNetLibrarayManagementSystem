using LibrarayManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarayManagementSystem.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    public DbSet<UserRole> UserRole {get;set;}
    public DbSet<User> User {get;set; }
}
