using LibrarayManagementSystem.Controllers;
using LibrarayManagementSystem.Data.Interfaces;
using LibrarayManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarayManagementSystem.Data.Repositories
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRoleRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<UserRole> GetAll() => _appDbContext.UserRole.OrderBy(u => u.Id).ToList();

        public UserRole Get(int id)
        {
            return _appDbContext.UserRole.Find(id);
        }

        public void Add(UserRole userRole)
        {
            _appDbContext.UserRole.Add(userRole);
        }

        public void Update(UserRole userRole)
        {
            _appDbContext.UserRole.Update(userRole);
        }

        public void Delete(int id)
        {
            var user = _appDbContext.UserRole.Find(id);
            if (user != null)
            {
                _appDbContext.UserRole.Remove(user);
            }
        }
    }

}
