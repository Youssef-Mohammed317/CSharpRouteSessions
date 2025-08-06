using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions
{
    internal class Car : Vehicle
    {
        public new void Move(double speed)
        {
            Console.WriteLine($"Car is Moving...\nWith Speed:{speed}");
        }
    }
}
