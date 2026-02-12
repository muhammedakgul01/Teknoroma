using Teknoroma.Entities;

namespace Teknoroma.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IUserRepository : IRepository<User>
    {
        void CreatedUser(int employeeId, string userName, string password);
        User Login(string userName, string password);
        void UnlockUser(int userId);
        void LockUser(int userId);
    }
}
