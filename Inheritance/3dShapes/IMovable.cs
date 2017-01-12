using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
     interface IMovable
    {
        void MoveBy(float d);
        void MoveTo(float x, float y, float z);
        void MoveTo(Coordinate3D cord);
        
    }
}
