using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Part01.Q4
{
    internal class Employee
    {
        // virtual method for overriding
        public virtual void Work01()
        {
            Console.WriteLine("Employee is working from 01");
        }

        // new keyword hides the base class method
        public void Work02()
        {
            Console.WriteLine("Employee is  working from 02");
        }
    }
}
