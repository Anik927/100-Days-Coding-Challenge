using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Drawing_System
{
    internal class Circle:Shape
    {
        private double radius;
        private string color;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

       public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public override void ShowDetails()
        {
            base.ShowDetails();
            Console.WriteLine(radius);
            Console.WriteLine(color);
        }

        public double GetDiameter()
        {
            return radius*2;
        }

        public bool IsLargeCircle()
        {
            return radius > 10;
        }

        public Circle()
        {

        }

        public Circle(string shapeName, string shapeType,double radius, string color):base(shapeName,shapeType)
        {
            this.radius = radius;
            this.color = color;
        }



    }
}
