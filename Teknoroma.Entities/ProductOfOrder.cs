using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class ProductOfOrder : BaseEntity
    {
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        //Relational Properties

        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}