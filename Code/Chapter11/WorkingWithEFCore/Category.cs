using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Packt.Shared
{
    public class Category
    {
        // these properties map to columns in the database
        
        public int CateoryID { get; set; }
        public string CategoryName { get; set; }

        // change the type of the description column
        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        // defines a navigation property for related rows. Product is used to represent a row in the Products table
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            // to enable developers to add products to category, we must
            // initialize the navigation property to an empty list
            this.Products = new List<Product>();
        }
    }
}
