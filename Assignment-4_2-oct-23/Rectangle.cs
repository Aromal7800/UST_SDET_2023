using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_2_oct_23
{
    internal class Rectangle : Shape,IDrawable
    {
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int Length {  get; set; }
        public int Width { get; set; }
        public override double CaculateArea()
        {
            return (Length * Width);
        }

        public override double CalculatePerimeter()
        {
            return ((Length + Width)*2);
        }

        public void Display()
        {
            Console.WriteLine("Rectangle");
            Console.WriteLine("Area : {0} \t Perimeter : {1} \t ", CaculateArea(), CalculatePerimeter());

        }
    }
}
