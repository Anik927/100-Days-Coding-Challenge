using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Drawing_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            Shape s2 = new Shape("Nuha","Heart");

            s1.ShapeName = "Anik";
            s1.ShapeType = "Hudai";

            s1.ShowDetails();
            s2.ShowDetails();

            Rectangle r1 = new Rectangle();
            Rectangle r2 = new Rectangle("Meh","Ehh",6,8);

            r1.ShapeName = "Mmm";
            r1.ShapeType = "Ami ki jani";
            r1.Width = 10;
            r1.Length = 10;

            Console.WriteLine(r1.IsSquare());
            Console.WriteLine(r2.IsSquare());

            Console.WriteLine(r2.GetPerimeter());
            Console.WriteLine(r1.GetPerimeter("Cm"));

            r1.ShowDetails();
            r2.ShowDetails();



        }
    }
}
