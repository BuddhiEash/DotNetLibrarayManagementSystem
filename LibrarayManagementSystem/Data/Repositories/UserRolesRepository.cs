using LibrarayManagementSystem.Controllers;
using LibrarayManagementSystem.Data.Interfaces;
using LibrarayManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarayManagementSystem.Data.Repositories
{
    public class UserRolesRepository : IUserRolesRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRolesRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<UserRole> GetAll() => _appDbContext.UserRoles.OrderBy(u => u.Id).ToList();

        public UserRole Get(int id)
        {
            return _appDbContext.UserRoles.Find(id);
        }

        public void Add(UserRole userRole)
        {
            _appDbContext.UserRoles.Add(userRole);
        }

        public void Update(UserRole userRole)
        {
            _appDbContext.UserRoles.Update(userRole);
        }

        public void Delete(int id)
        {
            var user = _appDbContext.UserRoles.Find(id);
            if (user != null)
            {
                _appDbContext.UserRoles.Remove(user);
            }
        }
    }

}
