using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    internal class Chocolate : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Hot chocolate is served."); 
        }
    }
}
