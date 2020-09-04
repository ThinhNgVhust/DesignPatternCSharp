using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        //private static readonly Lazy<Singleton> lazy = new Lazy<Singleton>(() => new Singleton());
        private static readonly Singleton singleton= new Singleton();
        //public static Singleton GetInstance { get { return lazy.Value; } }
        public static Singleton GetInstance { get { return singleton; } }

        private Singleton()
        {
            Console.WriteLine("Khoi tao singleton thanh cong");
        }
    }
}
