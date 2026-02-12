using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teknoroma.BLL.DesignPatterns.GenericRepository.BaseRep;
using Teknoroma.BLL.DesignPatterns.GenericRepository.Helpers;
using Teknoroma.BLL.DesignPatterns.GenericRepository.IntRep;
using Teknoroma.Entities;

namespace Teknoroma.BLL.DesignPatterns.GenericRepository.ConcRep
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public void CreatedUser(int employeeId, string userName, string password)
        {
            if (Any(x => x.UserName == userName))
            {
                throw new Exception("Bu kullanıcı adı zaten mevcut");
            }

            PasswordHasher.CreateHash(password, out string hash, out string salt);

            User user = new User
            {
                EmployeeID = employeeId,
                UserName = userName,
                PasswordHash = hash,
                PasswordSalt = salt,
                isLocked = true,
                CreatedDate = DateTime.Now,
                Status = Entities.Enums.DataStatus.Active
            };

            Add(user);
        }

        public void LockUser(int userId)
        {
            User user = Find(userId);
            user.isLocked = false;
            Update(user);
        }

        public User Login(string userName, string password)
        {
            User user = FirstOrDefault(x => x.UserName == userName);

            if (user == null)
            {
                return null;
            }

            if (user.isLocked)
            {
                throw new Exception("Hesabınız kilitli");
            }

            bool verified = PasswordHasher.Verify(password, user.PasswordHash, user.PasswordSalt);

            if (!verified)
            {
                return null;
            }

            user.LastLoginDate = DateTime.Now;
            Update(user);

            return user;
        }

        public void UnlockUser(int userId)
        {
            User user = Find(userId);
            user.isLocked = true;
            Update(user);
        }
    }
}
