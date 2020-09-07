using AbstractFactoryPattern.Interfaces;
using AbstractFactoryPattern.US;
using AbstractFactoryPattern.VN;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factory
{
    public class VNFactory:Factory1
    {
		public override IAdress createAddress()
		{
			return new VNAddress();
		}
		public override IPhone createPhone()
		{
			return new VNPhone();
		}
	}

}
