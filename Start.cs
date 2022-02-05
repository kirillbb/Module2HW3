using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public static class Start
    {
        public static void Run()
        {
            Gift gift = new();

            gift.CollectAGift(new Caramel("Apple", "roshen", 7, 5), 0);
            gift.CollectAGift(new Chocolate("Choko", "milka", 100, 30), 1);
            gift.CollectAGift(new StuffedChokolate("Nuts", "konti", 50, 15), 2);
            gift.CollectAGift(new Lollipop("Chups", "chupa", 12, 7), 3);
            gift.CollectAGift(new StuffedCaramel("Rak", "roshen", 3, 3), 4);
            gift.CollectAGift(new LiqueurCaramel("DrunkCherry", "avk", 12, 10), 5);
            gift.CollectAGift(new Caramel("apple", "roshen", 8, 5), 6);
            gift.CollectAGift(new Chocolate("ChokoLoko", "milka", 110, 35), 7);
            gift.CollectAGift(new StuffedChokolate("Nuts", "konti", 55, 20), 8);
            gift.CollectAGift(new Lollipop("Chups", "chupa", 13, 8), 9);
            
            gift.PrintGift(gift.candies);
            Console.WriteLine();

            Array.Sort(gift.candies);

            Console.WriteLine("Sorted array:");
            gift.PrintGift(gift.candies);


        }
    }
}
