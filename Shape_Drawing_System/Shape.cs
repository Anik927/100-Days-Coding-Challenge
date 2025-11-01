using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_Drawing_System
{
    internal class Shape
    {
        protected string shapeName;
        protected string shapeType;

        protected static int totalShapes;

        public string ShapeName
        {
            get { return shapeName; }
            set { shapeName = value; }
        }

       public string ShapeType
        {
            get { return shapeType; }
            set { shapeType = value; }
        }

        public static int TotalShapes
        {
            get { return totalShapes; }
            set { totalShapes = value; }
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("----------------Details---------------");
            Console.WriteLine(shapeName);
            Console.WriteLine(shapeType);
            Console.WriteLine(totalShapes);
        }

        public Shape()
        {
            totalShapes++;
        }

        public Shape(string shapeName, string shapeType)
        {
            this.shapeName = shapeName;
            this.shapeType = shapeType;
            totalShapes++;
        }
    }
}
