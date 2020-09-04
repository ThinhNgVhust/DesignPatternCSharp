using Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    class Single : People, ISingle
    {
        public List<IFan> myFans { get; set; }
        public List<String> Album { get; set; }
        public Single(string name) : base(name)
        {
            myFans = new List<IFan>();
            Album = new List<string>();
            Name = name;
        }

        public void AtachFan(IFan aFan)
        {
            if (!myFans.Contains(aFan))
            {
                myFans.Add(aFan);
                Console.WriteLine(String.Format("{0} dang ki la fan cua {1} thanh cong", (aFan as Fan).Name, Name));
            }
            else
            {
                Console.WriteLine(String.Format("{0} da la fan cua {1}", (aFan as Fan).Name, Name));
            }
        }

        public void DetachFan(IFan aFan)
        {
            myFans.Remove(aFan);
        }

        public void Notify()
        {
            foreach (IFan item in myFans)
            {
                item.Update(Album[Album.Count-1]);
            };
        }

        public void ReleaseAlbum(String albumName)
        {
            Album.Add(albumName);
            Console.WriteLine("Singe {0} thong bao cho tat ca cac fans: ", Name);
            Console.WriteLine(String.Format("Hey fans! Toi vua moi ra album moi {0}, moi nguoi cung mua ve nghe nha!!!!", albumName));
            Console.WriteLine("--------------------------------------\n\n");
            Notify();
        }
    }
}
