using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoticeMeSenpai
{
    class Program
    {
        static void Main(string[] args)
        {
            Protaginist sitsByWindow = new Protaginist(4, 5, 12, "NightWing", "AIE");
            SadTwist childFriend = new SadTwist(5, 20, "AIE");

            childFriend.SenpaiNotice(sitsByWindow);
            sitsByWindow.ItsaAngle(childFriend);

            Console.ReadLine();
        }
    }
}
