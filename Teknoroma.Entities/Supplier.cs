using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        //Relational Properties

        public virtual List<Product> Products { get; set; }
    }
}