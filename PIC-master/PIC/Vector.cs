using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector.Desktop
{
    public abstract class Vector
    {
        private double _x;
        private double _y;
        private double _z;

        public Vector(double x, double y, double z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public double Z { get => _z; set => _z = value; }
        
     }
}