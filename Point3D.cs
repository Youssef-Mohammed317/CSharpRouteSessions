using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Point3D : ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x,double y,double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public Point3D(double x,double y):this(x,y,0.0) { }
        public Point3D(double x):this(x,0.0,0.0) { }
        public Point3D():this(0.0,0.0,0.0) { }

        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public object Clone()
        {
            return new Point3D(X,Y,Z);
        }

        public static bool operator==(Point3D a,Point3D b)
        {
            return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
        }
        public static bool operator !=(Point3D a,Point3D b)
        {
            return !(a.X == b.X && a.Y == b.Y && a.Z == b.Z);
        }
    }
}
