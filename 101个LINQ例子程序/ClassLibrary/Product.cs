using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public int ProductID { get; set; }
        public int UnitsInStock { get; set; }
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public string Category { get; set; }

        public static List<Product> GetProductList()
        {
            return new List<Product>();
        }
    }
}
