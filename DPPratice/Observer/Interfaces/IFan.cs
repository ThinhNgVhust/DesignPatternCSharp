using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interfaces
{
    public interface IFan
    {
        void Follow(ISingle aSingle);
        void Update(String albumName);
    }
}
