using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Ellipsoid : Geometric3Dshapes, IMovable
    {
        protected float A { get; set; }
        protected float B { get; set; }
        protected float C { get; set; }
        
        public Ellipsoid(float a, float b, float c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public Ellipsoid(float a, float b, float c, Coordinate3D gravityCenter ):this( a, b, c)
        {
            this.Location = gravityCenter;
        }

        public Ellipsoid(float a, float b, float c, float x, float y, float z) : this(a, b, c)
        {
            this.Location = new Coordinate3D(x,y,z);
        }



        public override float SurfaceArea
        {
            get
            {
                float p = 1.6075f;
                return 4f * (float)Math.PI * (float)Math.Pow(Math.Pow(A * B, p) + Math.Pow(A * C, p) + Math.Pow(B * C, p), 1f / p);
            }

        }

        public override float Volume
        {
            get
            {
                return 4f / 3f * (float)Math.PI * A * B * C;
            }

        }
        public override string ToString()
        {
            if (this.Location.X == 0 && this.Location.Y == 0 && this.Location.Z == 0)
                return ($"Ellipsoid parameters are: {A}; {B}; {C}");
            else
            return ($"Ellipsoid parameters are: {A}; {B}; {C}; {Location}");
        }

        
        public void MoveBy(float d)
        {
            this.Location = new Coordinate3D(this.Location.X + d, this.Location.Y + d, this.Location.Z + d); 
        }

        public void MoveTo(float x, float y, float z)
        {
            this.Location = new Coordinate3D(x,y,z);
        }

        public void MoveTo(Coordinate3D cord)
        {
            this.Location=cord;
        }

        
    }
}
