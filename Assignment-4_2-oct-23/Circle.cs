using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_2_oct_23
{
    internal class Circle : Shape,IDrawable
    {
        public Circle(int radius)
        {
            Radius = radius;
        }

        public int Radius {  get; set; }
        public override double CaculateArea()
        {
            return Radius * Radius * 3.14;
        }

        public override double CalculatePerimeter()
        {
            return 3.14 * Radius * 2;
        }

        public void Display()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("Area : {0} \t Perimeter : {1} \t ", CaculateArea(), CalculatePerimeter());
        }
    }
}
