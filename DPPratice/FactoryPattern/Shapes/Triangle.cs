using FactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Shapes
{
    public class Triangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Triangle draw");
        }
    }
}
