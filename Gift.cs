using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class Gift : IGift
    {
        public Candy[] candies = new Candy[10];

        int Weight { get; set; }
        public void CollectAGift(Candy candy, int index)
        {
            candies[index] = candy;
        }

        public int WeightOfTheGift(Candy[] candies)
        {
            foreach (var item in candies)
            {
                Weight += item.WeightInGrams;
            }

            return Weight;
        }

        public void PrintGift(Candy[] candies)
        {

            foreach (var item in candies)
            {
                Console.WriteLine($"{item.Name} ({item.Manufacturer}) {item.WeightInGrams} grams - {item.Price}$");
            }

            Console.WriteLine();
            Console.WriteLine($"Weight of the gift is {WeightOfTheGift(candies)} grams");
        }
    }
}
