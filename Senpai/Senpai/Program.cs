using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senpai
{
    class Program
    {
        static void Main(string[] args)
        {
            Protaginist sitsByWindow = new Protaginist("AIE", 1, "Monster", 10, 10);
            SadTwist childFriend = new SadTwist("AIE", 1, 12);

            bool yes = childFriend.SenpaiNotice(sitsByWindow);
            string hey = sitsByWindow.ItsaAngel(childFriend);

            Console.WriteLine(yes.ToString());
            Console.WriteLine(hey);

            Console.Read();
        }
    }
}
