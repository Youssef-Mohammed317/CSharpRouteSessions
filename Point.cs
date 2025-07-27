using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpRouteSessions
{
    internal struct Point
    {
        #region Attributes
        public int x; // default is private
        public int y;
        #endregion

        #region Constructors
        // special function for:
        // 1. name is same as struct name
        // 2. no return type
        // 3. initialize the struct

        // default constructor [parameterless constructor]
        //public Point()
        //{
        //    x = default;
        //    y = default;
        //}

        // change the default values of the struct
        public Point()
        {
            x = 10; // default value for x
            y = 20; // default value for y
        }

        // parameterized constructor [user defined constructor]
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public Point(int val)
        {
            this.x = this.y = val;
        }



        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Point [x={x}, y={y}]"; // custom string representation of the struct
        }
        #endregion
    }
}
