using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class Warrior
    {
        protected string name;
        protected int health;

        public Warrior()
        {

        }

        public virtual int getHp()
        {
            return health;
        }

        public virtual void SayName()
        {
            //Console.Write("My Name Is...");
        }

        public virtual void Fight(Warrior w1)
        {
            //Console.Write("I am a warrior");
        }

    }

    public class Ninja : Warrior
    {
        public Ninja(int hp, string n)
        {
            health = hp;
            name = n;
        }

        public override int getHp()
        {
            return health;
        }

        public override void Fight(Warrior w1)
        {
            //base.Fight(w);
           
            if (getHp() > w1.getHp())
            {
                Console.WriteLine("I am a Ninja and I win!");
            }
        }

        public override void SayName()
        {
            Console.Write("My Name Is..." + name);

        }
    }

    public class Duck : Warrior
    {
        public Duck(int hp, string n)
        {
            health = hp;
            name = n;
        }

        public override int getHp()
        {
            return health;
        }

        public override void Fight(Warrior w1)
        {
            //base.Fight(w);
            
            if(getHp() > w1.getHp())
            {
                Console.WriteLine("I am a duck and I win!");
            }


        }

        public override void SayName()
        {
            Console.Write("My Name Is..." + name);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Warrior> warriors = new List<Warrior>();

            for (int i = 0; i < 50; i++)
            {
                Duck d = new Duck(i + 6, "Duck\n" + "Index: " + i);
                Ninja n = new Ninja(i + 5, "Ninja\n" + "Index: " + i);

                //if (d.getHp() > n.getHp())
                //{
                //    warriors.Add(d);
                //}
                //else if (n.getHp() > d.getHp())
                //{
                //    warriors.Add(n);
                //}
                //else
                //{
                //    warriors.Add(d);
                //    warriors.Add(n);
                //}

                warriors.Add(d);
                warriors.Add(n);

                d.Fight(n);
                n.Fight(d);

            }

            foreach (Warrior w in warriors)
            {
                w.SayName();
                Console.Write("\n");

            }


            Console.ReadLine();
        }
    }





}
