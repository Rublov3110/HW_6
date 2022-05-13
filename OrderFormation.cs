using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    public class OrderFormation
    {
        private string[] _products = new string[10];
        private int[] _productsUser = new int[5];

        public string[] Products
        {
            get { return _products; }
            set { _products = value; }
        }

        public int[] ProductsUser
        {
            get { return _productsUser; }
            set { _productsUser = value; }
        }

        public void SetOrder(string[] products, int[] productUser)
        {
           _products = products;
           _productsUser = productUser;
        }

        public void Order()
        {
            Console.WriteLine("Your order:");

            for (int i = 0; i < _productsUser.Length; i++)
            {
               for (int j = 0; j < _products.Length; j++)
                {
                    if (_productsUser[i] == j)
                    {
                        Console.WriteLine($"{i + 1}:{_products[j]}");
                    }
                }
            }

            Console.WriteLine($"Order time:{DateTime.Now}");
            Console.WriteLine($"Invoice number:{_productsUser.GetHashCode()}");
        }
    }
}
