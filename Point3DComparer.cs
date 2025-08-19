using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Point3DComparer : IComparer<Point3D>
    {
        public int Compare(Point3D? x, Point3D? y)
        {
            if (x.X > y.X) return 1;
            else if (x.X < y.X) return -1;
            else if(x.X == y.X)
                if (x.Y > y.Y) return 1;
                else if (x.Y < y.Y) return -1;
                else if (x.Y == y.Y)
                    if (x.Z > y.Z) return 1;
                    else if (x.Z < y.Z) return -1;
                    else if (x.Z == y.Z)
                        return 0;
            return 0;
        }
    }
}
