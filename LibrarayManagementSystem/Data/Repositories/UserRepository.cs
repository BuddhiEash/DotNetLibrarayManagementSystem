using LibrarayManagementSystem.Controllers;
using LibrarayManagementSystem.Data.Interfaces;
using LibrarayManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LibrarayManagementSystem.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<User> GetAll() => _appDbContext.User.OrderBy(u => u.Id).ToList();

        public User Get(int id)
        {
            return _appDbContext.User.Find(id);
        }

        public void Add(User user)
        {
            _appDbContext.User.Add(user);
        }

        public void Update(User user)
        {
            _appDbContext.User.Update(user);
        }

        public void Delete(int id)
        {
            var user = _appDbContext.User.Find(id);
            if (user != null)
            {
                _appDbContext.User.Remove(user);
            }
        }
    }

}
