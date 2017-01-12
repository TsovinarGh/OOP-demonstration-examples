using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InheritanceDemo;

namespace ConsoleApplicationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Coordinate3D elipscenter = new Coordinate3D(1.2f, 1.1f, 1.4f);
           
            Ellipsoid elips = new Ellipsoid(2f, 4f, 1.2f, elipscenter);
            Console.WriteLine(elips);
            elips.MoveBy(2);
            Console.WriteLine(elips);
            //elips.MoveTo(elipscenter, 2.2f, 2.1f, 2.4f);
            //Console.WriteLine(elips);
            //elips.MoveBy(elipscenter, 1f);
            //Console.WriteLine(elips);
            //Coordinate3D elipscenter2 = new Coordinate3D(2f, 2f, 2f);
            //elips.MoveTo(elipscenter2);
            //Console.WriteLine(elips);
            //Ellipsoid elips1 = new Ellipsoid(1f, 1f, 1f);
            //Console.WriteLine(elips1);

            //Geometric3Dshapes elips3 = new Ellipsoid(1f, 2f,4f);
           Console.ReadKey();

        }
    }
}
