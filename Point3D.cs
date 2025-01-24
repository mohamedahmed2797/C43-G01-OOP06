using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G01_OOP06
{
    internal class Point3D : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D() : this(0, 0, 0)
        {
        }
        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return $"{X}, {Y} , {Z}";
        }


        public object Clone()
        {
            return new Point3D(X, Y, Z);


        }

        public static bool operator ==(Point3D P1, Point3D P2)
        {
            if (P1 is null || P2 is null)
            {
                return false;
            }
            return P1.X == P2.X && P1.Y == P2.Y && P1.Z == P2.Z;
        }
        public static bool operator !=(Point3D P1, Point3D P2)
        { return !(P1 == P2); }
        
    }
    

}
