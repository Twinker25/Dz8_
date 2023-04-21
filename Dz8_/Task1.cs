using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz8_
{
    struct Vector
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        public static Vector operator *(Vector a, double b)
        {
            double X = a.x * b;
            double Y = a.y * b;
            double Z = a.z * b;
            return new Vector { x = X, y = Y, z = Z };
        }
        public static Vector operator +(Vector a, Vector b)
        {
            double X = a.x + b.x;
            double Y = a.y + b.y;
            double Z = a.z + b.z;
            return new Vector { x = X, y = Y, z = Z };
        }
        public static Vector operator -(Vector a, Vector b)
        {
            double X = a.x - b.x;
            double Y = a.y - b.y;
            double Z = a.z - b.z;
            return new Vector { x = X, y = Y, z = Z };
        }
    }
}