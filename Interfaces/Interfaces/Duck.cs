using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Duck : IAttack, IStats
{

        private int hp;
        private string name;

        public Duck(int h, string n)
        {
            hp = h;
            name = n;

        }

        public void Fight()
        {
          hp -= 1;
          Console.WriteLine("Time to fight...Quack!");
        }

        public int Health
        {

        get
        {
            return hp;
        }

        set
        {
            hp = value;
        }

        }

}
