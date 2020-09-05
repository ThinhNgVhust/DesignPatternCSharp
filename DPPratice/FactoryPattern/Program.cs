using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory.GetShape(Const.ShapeType.Circle).Draw();
            ShapeFactory.GetShape(Const.ShapeType.Rectangle).Draw();
            ShapeFactory.GetShape(Const.ShapeType.Square).Draw();
            ShapeFactory.GetShape(Const.ShapeType.Triangle).Draw();
            Console.ReadKey();
        }
    }
}
