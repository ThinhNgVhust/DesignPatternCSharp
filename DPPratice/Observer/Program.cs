using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Single danTruong = new Single("Đan Trường");
            Fan thinh = new Fan("Thinh");
            Fan toan = new Fan("Toan");
            Fan tit = new Fan("TIt");
            thinh.Follow(danTruong);
            toan.Follow(danTruong);
            danTruong.ReleaseAlbum("Con mua tinh yeu");
            tit.Follow(danTruong);
            danTruong.ReleaseAlbum("Dong song bang");

            danTruong.DetachFan(thinh);
            danTruong.ReleaseAlbum("Dong mau lac hong");
            Console.ReadKey();
            /* Pros: 
                 Open / Closed Principle.
                  You can introduce new subscriber classes 
                  without having to change the publisher’s 
                  code(and vice versa if there’s a publisher interface).    
            */



            /*
             *  Cons:Subscribers are notified in random order.
             */
        }

    }
}
