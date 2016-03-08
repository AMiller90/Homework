using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> playas = new List<Player>();

            playas.Add(new Player("Andrew", 18));
            playas.Add(new Player("TK", 17));

            Console.WriteLine("Before Sorting\n");

            foreach (Player s in playas)
            {
                Console.WriteLine((s.name + ": " + s.age));
            }

            Console.WriteLine("\nAfter Sorting\n");

            playas.Sort();


            foreach (Player s in playas)
            {
                Console.WriteLine((s.name + ": " + s.age));
            }


            Player p1 = new Player("Hey", 13);
            Player p2 = new Player("Boo", 12);


            Object ob = p2.Clone();

            Player p = ob as Player;

            p1.CompareTo(p2);

            Console.WriteLine(p.name);
            
            Console.Read();
        }
    }
}
