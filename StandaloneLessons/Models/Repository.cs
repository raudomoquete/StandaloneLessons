using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StandaloneLessons.Models
{
    public class Repository : IRepository
    {
        private List<Product> products;

        public Repository()
        {
            products = new List<Product>();
            new List<Product>
            {
                new Product { Name = "Basketball", Price = 3.99M },
                new Product { Name = "Basketball Shirt", Price = 9.99M },
                new Product { Name = "Basketball Pants", Price = 19.99M },
            }.ForEach(x => AddProduct(x));
        }

        public IEnumerable<Product> Products => Products;

        public void AddProduct(Product product) => products.Add(product);

        public void DeleteProduct(Product product) => products.Remove(product);
       
    }
}
