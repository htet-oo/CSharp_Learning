using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kadai2_1C30JT_HtetOoWaiYan
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        
        public Product(string name,int price)
        {
            Name = name;
            if (price > 0)
            {
                Price = price;
            }
            else
            {
                price = 0;
            }

        }

    }
}
