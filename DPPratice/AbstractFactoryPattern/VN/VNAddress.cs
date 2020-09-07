using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.VN
{
   public class VNAddress : IAdress
    {
        public void Show()
        {
            Console.WriteLine("Viet Nam address");
        }
    }
}
