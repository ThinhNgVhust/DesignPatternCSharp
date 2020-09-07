using AbstractFactoryPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryPattern.Factory
{
   public abstract class Factory1
    {
		virtual public IAdress createAddress()
		{
			return null;
		}
		virtual public IPhone createPhone()
		{
			return null;
		}
	}
}
