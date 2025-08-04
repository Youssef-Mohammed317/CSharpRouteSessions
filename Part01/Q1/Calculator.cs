using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Part01.Q1
{
    internal class Calculator
    {

        // Overloaded Add methods
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
}
