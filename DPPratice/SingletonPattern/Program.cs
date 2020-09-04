using System;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Singleton is a creational design pattern that lets you ensure that a class has only one instance, 
             * while providing a global access point to this instance.
             */
            //Singleton a = Singleton.GetInstance();
            //Singleton b = Singleton.GetInstance();
            //Singleton c = Singleton.GetInstance();
            //Singleton d = Singleton.GetInstance();
           
            Thread t1 = new Thread(()=> { DoJob(); });
            Thread t2 = new Thread(() => { DoJob(); });
            Thread t3 = new Thread(() => { DoJob(); });
            Thread t4 = new Thread(() => { DoJob(); });
            t1.Start();
            t2.Start(); t3.Start(); t4.Start();
            Console.ReadKey();
            /*
             * Pros: 
             *  1. You can be sure that a class has only a single instance.
             *  2. You gain a global access point to that instance.
             *  3. The singleton object is initialized only when it’s requested for the first time
             */
        }

        private static void DoJob()
        {
            Singleton a = Singleton.GetInstance;
            Singleton b = Singleton.GetInstance;
            Singleton c = Singleton.GetInstance;
            Singleton d = Singleton.GetInstance;
        }
    }
}
