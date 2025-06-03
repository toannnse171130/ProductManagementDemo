using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        List<Product> list = new List<Product>();
        public List<Product> GetProducts()
        {
            list.Add(
            
                new Product{ProductID=1,ProductName="Chai",UnitPrice=18.00M,UnitsInStock=39,CategoryID=1},
                new Product{ProductID=2,ProductName="Chang",UnitPrice=19.00M,UnitsInStock=17,CategoryID=1},
                new Product{ProductID=3,ProductName="Aniseed Syrup",UnitPrice=10.00M,UnitsInStock=13,CategoryID=2},
                new Product{ProductID=4,ProductName="Chef Anton's Cajun Seasoning",UnitPrice=22.00M,UnitsInStock=53,CategoryID=2},
                new Product{ProductID=5,ProductName="Chef Anton's Gumbo Mix",UnitPrice=21.35M,UnitsInStock=0,CategoryID=2},
                new Product{ProductID=6,ProductName="Grandma's Boysenberry Spread",UnitPrice=25.00M,UnitsInStock=120,CategoryID=2},
                new Product{ProductID=7,ProductName="Uncle Bob's Organic Dried Pears",UnitPrice=30.00M,UnitsInStock=15,CategoryID=3},
                new Product{ProductID=8,ProductName="Northwoods Cranberry Sauce",UnitPrice=40.00M,UnitsInStock=6,CategoryID=3}
            );
            return list;
        }
        public void SaveProduct(Product p)
        {
            list.Add(p);
        }
    }
}
