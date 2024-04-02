using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240401_1.models
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public float CurrentPriece { get; set; }
         public bool Validate()
        {
            return true;
        }

        public Product Retrieve()
        {
            return new Product();
        }

        public void Save(Product product)
        {
            
        }
    }
}