using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.US
{
    public class USAdress : IAdress
    {
        public void Show()
        {
            Console.WriteLine("USA Address");
        }
    }
}
