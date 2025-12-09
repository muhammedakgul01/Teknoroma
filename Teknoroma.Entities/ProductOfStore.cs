using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class ProductOfStore : BaseEntity
    {
        public int ProductID { get; set; }
        public int StoreID { get; set; }
        
        //Relational Properties
        public virtual Product Product { get; set; }
        public virtual Store Store { get; set; }


    }
}