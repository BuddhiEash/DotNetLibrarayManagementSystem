using LibrarayManagementSystem.Models;

namespace LibrarayManagementSystem.Data.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User Get(int id);
        void Add(User userRole);
        void Update(User userRole);
        void Delete(int id);
    }
}
