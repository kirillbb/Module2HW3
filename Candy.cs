using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2HW3
{
    public class Candy : IComparable<Candy>
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


        public virtual void EatCandy(Candy candy)
        {
            Console.WriteLine($"Candy \"{candy.Name}\" eaten!");
        }

        public int CompareTo(Candy candy)
        {
            return string.Compare(this.Name, candy.Name);
        }
    }
}
