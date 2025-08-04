using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Part01.Q3
{
    internal class Complex
    {
        public double Real { get; set; }
        public double Img { get; set; }

        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = c1.Real + c2.Real,
                Img = c1.Img + c2.Img
            };
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex()
            {
                Real = c1.Real - c2.Real,
                Img = c1.Img - c2.Img
            };
        }

    }
}
