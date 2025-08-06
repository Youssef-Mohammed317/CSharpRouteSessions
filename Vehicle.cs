using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions
{
    internal class Vehicle
    {
        public virtual void Move(double speed)
        {
            Console.WriteLine($"Vehicle is Moving...\nWith Speed:{speed}");
        }
    }
}
