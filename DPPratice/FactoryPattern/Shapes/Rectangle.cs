using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Shapes
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double w,double height)
        {
            Width = w;Height = h;
        }
        public void Draw()
        {
            Console.WriteLine("Rectangle draw");
        }
    }
}
