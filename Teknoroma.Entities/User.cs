using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class User : BaseEntity
    {
        // Bu tablo çalışanların sisteme girebilmesi için kullanıcı ve şifresinin tutulduğu tablodur. Employee ile 1-1 ilişkilidir
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool isLocked { get; set; } = true;
        public DateTime? LastLoginDate { get; set; }

        public Employee Employee { get; set; }
    }
}
