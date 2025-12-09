using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Teknoroma.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        // Relational Properties
        public int? ParentCategoryID { get; set; }
        public Category? ParentCategory { get; set; }
        

        public ICollection<Category> ChildCategories { get; set; }
    }
}