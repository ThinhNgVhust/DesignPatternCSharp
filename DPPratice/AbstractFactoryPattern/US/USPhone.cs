using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.US
{
    public class USPhone : IPhone
    {
        public void Show()
        {
            Console.WriteLine("USA Phone");
        }
    }
}
