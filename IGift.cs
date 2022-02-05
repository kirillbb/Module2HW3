using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public interface IGift
    {
        public int WeightOfTheGift(Candy[] candies);
        public void PrintGift(Candy[] candies);
    }
}
