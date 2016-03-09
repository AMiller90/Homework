using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
        

        Unit a = new Unit();
        Unit u = new Unit(100, 100, 100, 100);
        Unit v = new Unit(200, 100, 100, 100);

        a.participants.Add(u);
        a.participants.Add(v);

        foreach(Unit m in a.participants)
        {
            Console.WriteLine(m.Health);
        }

        List<Unit>b = a.participants;

        foreach (Unit m in b)
        {
            Console.WriteLine(m);
        }

        Console.Read();
        }
    }
