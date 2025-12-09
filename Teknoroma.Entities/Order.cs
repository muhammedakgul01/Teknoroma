using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class Order : BaseEntity
    {
        public Product Product { get; set; }
        public int ProductID { get; set; }

        //Relational Properties   

        public Store Store { get; set; }
        public int StoreID { get; set; }
        public CashRegister CashRegister { get; set; }
        public int CashRegisterID { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeID { get; set; }
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
        public virtual List<ProductOfOrder> ProductOfOrders { get; set; }
    }
}