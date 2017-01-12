using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Paralelipiped : Geometric3Dshapes, IMovable
    {
        protected float A { get; set; }
        protected float B { get; set; }
        protected float H { get; set; }

        public Paralelipiped(float a,float b, float h)
        {
            this.A = a;
            this.B = b;
            this.H = h;
        }
        public Paralelipiped(float a, float b, float h, Coordinate3D gravityCenter):this(a,b,h)
        {
            this.Location = gravityCenter;
        }

        public Paralelipiped(float a, float b, float h, float x, float y, float z): this(a, b, h)
        {
            this.Location = new Coordinate3D(x, y, z);
        }

        public override float SurfaceArea
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override float Volume
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public override string ToString()
        {
            if (this.Location.X == 0 && this.Location.Y == 0 && this.Location.Z == 0)
                return ($"Paralelipiped parameters are: {A}; {B}; {H}");
            else
                return ($"Paralelipiped parameters are: {A}; {B}; {H}; {Location}");
        }

        public void MoveBy(float d)
        {
            this.Location = new Coordinate3D(this.Location.X + d, this.Location.Y + d, this.Location.Z + d);
        }

        public void MoveTo(float x, float y, float z)
        {
            this.Location = new Coordinate3D(x, y, z);
        }

        public void MoveTo(Coordinate3D cord)
        {
            this.Location=cord;
        }
    }
}
