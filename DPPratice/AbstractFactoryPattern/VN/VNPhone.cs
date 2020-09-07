using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.VN
{
   public class VNPhone : IPhone
    {
        public void Show()
        {
            Console.WriteLine("Viet Nam phone");
        }
    }
}
