using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Part01.Q4
{
    internal class Manager : Employee
    {
        // method overriding
        public override void Work01()
        {
            // base.Work01(); // Optional: Call base class method
            Console.WriteLine("Employee is working from 01");
        }
        // new keyword hides the base class method
        public new void Work02()
        {
            // base.Work02(); // Optional: Call base class method
            Console.WriteLine("Employee is working from 02");
        }
    }
}
