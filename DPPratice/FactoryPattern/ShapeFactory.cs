using FactoryPattern.Interfaces;
using FactoryPattern.Shapes;
using System;
using System.Collections.Generic;
using System.Text;
using static FactoryPattern.Const;

namespace FactoryPattern
{
    public static class ShapeFactory
    {

        public static Shape GetShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Circle:
                    return new Circle();
                case ShapeType.Square:
                    return new Square();
                case ShapeType.Rectangle:
                    return new Rectangle();
                case ShapeType.Triangle:
                    return new Triangle();
                default:
                    return null;
            }

        }
    }
}
