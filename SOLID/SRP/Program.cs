using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{

    public class Jeans 
    {
        public void Pricing()
        {

        }
    }


    public class Shirt
    {
        public void Pricing()
        {

        }
    }

    public class Sale
    {
        public void GetPrice(object[] products)
        {
            foreach (var product in products)
            {

                if (product is Jeans)
                {
                    var jeans = (Jeans)product;
                    jeans.Pricing();
                }

                if (product is Shirt)
                {
                    var shirt = (Shirt)product;
                    shirt.Pricing();
                }
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
