using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Candy
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int WeightInGrams { get; set; }

        public Candy(string name, string manufacturer, int weightInGrams, int price)
        {
            Name = name;
            Manufacturer = manufacturer;
            WeightInGrams = weightInGrams;
            Price = price;
        }
    }
}
