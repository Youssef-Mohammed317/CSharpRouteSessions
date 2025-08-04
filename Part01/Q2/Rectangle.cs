using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions.Part01.Q2
{
    internal class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }
        Rectangle(int side)
        {
            Length = side;
            Width = side;
        }
    }
}
