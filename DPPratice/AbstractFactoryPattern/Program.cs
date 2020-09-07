using AbstractFactoryPattern.Factory;
using AbstractFactoryPattern.Interfaces;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
			Factory1 factory = new VNFactory();
			IAdress address = factory.createAddress();
			IPhone phone = factory.createPhone();

			Console.WriteLine("Create Object by VNFactory");
			address.Show();
			phone.Show();






			factory = new USFactory();
			address = factory.createAddress();
			phone = factory.createPhone();

			Console.WriteLine("Create Object by USFactory");
			address.Show();
			phone.Show();

			Console.ReadKey();
			
        }
    }
}
