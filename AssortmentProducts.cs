using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_6
{
    public class AssortmentProducts
    {
        private string[] _products = new string[10];
        public AssortmentProducts()
        {
            _products[0] = "Frame";
            _products[1] = "Motherboard";
            _products[2] = "CPU";
            _products[3] = "Video card";
            _products[4] = "RAM";
            _products[5] = "Power unit";
            _products[6] = "SSD";
            _products[7] = "HDD";
            _products[8] = "Cooling system";
            _products[9] = "Expansion board";
        }

        public string[] Products
        {
            get { return _products; }
            set { _products = value; }
        }

        public void VisualizationProducts()
        {
            Console.WriteLine("Welcome to PCStore");
            Console.WriteLine(new string('-', 70));

            for (int i = 0; i < _products.Length; i++)
            {
                Console.WriteLine($"{i + 1}:{_products[i]}");
            }

            Console.WriteLine(new string('-', 70));
        }
    }
}
