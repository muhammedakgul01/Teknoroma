using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class Product : BaseEntity
    {
        public string SKU { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockLevel { get; set; }

        //Relational Properties

        public Supplier? Supplier { get; set; }
        public int? SupplierID { get; set; }
        public Category Category { get; set; }
        public int CategoryID { get; set; }
        public virtual List<ProductOfStore> ProductOfStores { get; set; }
        public virtual List<ProductOfOrder> ProductOfOrders  { get; set; }
    }
}