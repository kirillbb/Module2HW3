using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3
{
    public class StuffedChokolate : Chocolate
    {
        public StuffedChokolate(string name, string manufacturer, int weightInGrams, int price) : base(name, manufacturer, weightInGrams, price)
        {
        }
    }
}
