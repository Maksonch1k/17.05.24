using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Notebook
    {
        public string model;
        public string manufacturer;
        public int price;

        public Notebook(string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("model" + model);
            Console.WriteLine("производительность" + manufacturer);
            Console.WriteLine("price" + price);
        }
    }
}
