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
        Unit v = new Unit(200, 50, 50, 100);

        List<Unit> b = a.participants;

        b.Add(u);
        b.Add(v);

        foreach (Unit m in b)
        {
            Console.WriteLine(m);
        }

        u.Attack(v);
        Console.WriteLine(v.Health);

        u.Attack(v);
        Console.WriteLine(v.Health);

        Console.WriteLine(u.Defense);
        u.Guard();
        Console.WriteLine(u.Defense);
        u.Guard();
        Console.WriteLine(u.Defense);



        Console.Read();
        }
    }
