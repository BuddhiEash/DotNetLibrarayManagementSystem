using LibrarayManagementSystem.Models;

namespace LibrarayManagementSystem.Data.Interfaces
{
    public interface IUserRoleRepository
    {
        IEnumerable<UserRole> GetAll();
        UserRole Get(int id);
        void Add(UserRole userRole);
        void Update(UserRole userRole);
        void Delete(int id);
    }
}
