using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class Customer : BaseEntity
    {
        public int? TCKimlikNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Gender { get; set; }
        public string Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public DateTime? BirthDate { get; set; }

        //Relational Properties

        public virtual List<Order> Orders { get; set; }
    }
}