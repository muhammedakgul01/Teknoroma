using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class Store : BaseEntity
    {
        public string Name { get; set; }
        public string City { get; set; }

        //Relational Properties
        public virtual List<Employee> Employees { get; set; }
        public virtual List<CashRegister> CashRegisters { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<ProductOfStore> ProductOfStores { get; set; }
    }
}