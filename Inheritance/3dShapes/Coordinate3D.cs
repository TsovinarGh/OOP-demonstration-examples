using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public struct Coordinate3D
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Coordinate3D (float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;

        }
        public override string ToString()
        {
            return ($"Gravity center coordinates are: {X}; {Y}; {Z}");
        }




    }
}
