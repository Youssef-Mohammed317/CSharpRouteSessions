using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions
{
    internal class Plane : Vehicle
    {
        public override void Move(double speed)
        {
            Console.WriteLine($"Plane is Moving...\nWith Speed:{speed}");
        }
    }
}
