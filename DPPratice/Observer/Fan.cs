using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Fan : People, IFan
    {
        public Fan(string name) : base(name)
        {
            Name = name;
        }

        public void Follow(ISingle aSingle)
        {
            Console.WriteLine(String.Format("{0} bat dau follow {1}", Name, (aSingle as Single).Name));
            aSingle.AtachFan(this);
        }

        public void Update(String name)
        {
            Console.WriteLine(String.Format("{1}: Idol cua toi moi ra album {0}. Mua thoi!!!", name,Name));
        }
    }
}
