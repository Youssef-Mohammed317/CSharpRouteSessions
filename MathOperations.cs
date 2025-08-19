using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Project
{
    internal static class MathOperations
    {
        public static double Add(double Num1,double Num2)
        {
            return Num1 + Num2;
        }
        public static double Subtract(double Num1,double Num2)
        {
            return (Num1 - Num2);
        }
        public static double Multiply(double Num1,double Num2)
        {
            return Num1 * Num2;
        }
        public static double Divide(double Num1,double Num2)
        {
            if (Num2 == 0) return double.MaxValue;
            return Num1 / Num2;
        }
    }
}
