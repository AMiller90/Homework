using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {

        Ninja n = new Ninja(25, "Andrew");
        Duck d = new Duck(10, "Programmer");

      
        List<IAttack> atl = new List<IAttack>();

        for (int i = 0; i < 5; i++)
        {
            atl.Add(n);
            atl.Add(d);
        }

        foreach (IAttack aia in atl)
        {
            aia.Fight();
           
        }

        foreach (IStats sta in atl)
        {
            Console.WriteLine("Current objects health is: " + sta.Health.ToString());

        }

        Console.Read();
    }

}