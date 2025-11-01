using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Drawing_System
{
    internal class Rectangle:Shape
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(length);
            Console.WriteLine(width);
        }

        public bool IsSquare()
        {
            return length == width;
        }

        public double GetPerimeter()
        {
            return 2 * (length + width);
        }

        public string GetPerimeter(string unit)
        {
            string a = "Perimeter: " + (2 * (length + width)) + unit;
            return a;
        }

        public Rectangle()
        {

        }

        public Rectangle(string shapeName, string shapeType, double length, double width):base(shapeName, shapeType)
        {
            this.length = length;
            this.width = width;
        }

    }
}
