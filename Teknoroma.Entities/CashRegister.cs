using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class CashRegister : BaseEntity
    {
        public string Name { get; set; }
        
        //Relational Properties
        public Store Store { get; set; }
        public int StoreID { get; set; }
        public virtual List<Order> Orders { get; set; }
        
    }
}