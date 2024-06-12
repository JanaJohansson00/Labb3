using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    
    internal class Coffee : IWarmDrink
    {
        public void Consume()
        {
            Console.WriteLine("Hot coffee is served."); 
        }
    }

}
