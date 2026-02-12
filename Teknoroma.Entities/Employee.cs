using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public decimal Wage { get; set; } 

        //Role tablosu oluşturulmalı
        public int StoreID { get; set; }
        public Store Store { get; set; }
        public virtual List<Order> Orders { get; set; }
        public User User { get; set; }
    }
}