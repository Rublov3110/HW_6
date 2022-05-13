using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    public class ShoppingBasket
    {
        private int[] _productsUser = new int[5];

        public int[] ProductsUser
        {
            get { return _productsUser; }
            set { _productsUser = value; }
        }

        public void Bascet()
        {
            Console.WriteLine("Choose 5 product");

            for (int i = 0; i < _productsUser.Length; i++)
            {
               int user = Convert.ToInt32(Console.ReadLine());

               _productsUser[i] = user - 1;
            }

            Console.WriteLine(new string('-', 70));
        }
    }
}
