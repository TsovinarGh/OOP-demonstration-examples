using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public abstract class Geometric3Dshapes
    {
        public Coordinate3D Location { get; set; }
        public abstract float SurfaceArea { get; }
        public abstract float Volume { get; }







    }
}
