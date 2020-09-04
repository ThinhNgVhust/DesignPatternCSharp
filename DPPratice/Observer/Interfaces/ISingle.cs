using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Interfaces
{
   public interface ISingle
    {
        void ReleaseAlbum(String albumName);
        void Notify();
        void AtachFan(IFan aFan);
        void DetachFan(IFan aFan);
    }
}
