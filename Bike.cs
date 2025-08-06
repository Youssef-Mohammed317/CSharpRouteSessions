using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions
{
    internal class Bike : Vehicle
    {
        public new void Move(double speed)
        {
            Console.WriteLine($"Bike is Moving...\nWith Speed:{speed}");
        }
    }
}
