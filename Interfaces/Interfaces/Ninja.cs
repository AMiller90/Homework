using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   class Ninja : IAttack, IStats
{

        private int health;
        private string name;

        public Ninja(int hp, string n)
        {
            health = hp;
            name = n;
        }
    
        public void Fight()
        {
             health -= 1;
             Console.WriteLine("Time to fight...Aaaaah!");
        }

        public int Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

}
