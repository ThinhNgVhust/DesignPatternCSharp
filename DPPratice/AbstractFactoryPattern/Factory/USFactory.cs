using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.US;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factory
{
   public  class USFactory:Factory1
    {
		public override IAdress createAddress()
		{
			return new USAdress();
		}
		public override IPhone createPhone()
		{
			return new USPhone();
		}
	}
}
