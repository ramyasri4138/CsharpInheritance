using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpInheritance
{
    using System;

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Base class method to get discounted price
        public virtual decimal GetDiscountedPrice()
        {
            // Default discount rule (e.g., 10% discount)
            return Price * 0.90m;
        }
    }

    public class ElectronicProduct : Product
    {
        // Override to apply specific discount rule for electronic products
        public override decimal GetDiscountedPrice()
        {
            // Electronic products get a 15% discount
            return Price * 0.85m;
        }
    }

    public class ClothingProduct : Product
    {
        // Override to apply specific discount rule for clothing products
        public override decimal GetDiscountedPrice()
        {
            // Clothing products get a 20% discount
            return Price * 0.80m;
        }
    }
}
