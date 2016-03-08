using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Player : IComparable, IEquatable<Player>, ICloneable
{
    
    public string name;
    public int age;

    public Player(string Name, int Age)
    {
        this.name = Name;
        this.age = Age;

    }

    public bool Equals(Player other)
    {
        if (other == null)
        {
            Console.WriteLine("Object does not exist");
            return false;
        }
        else if (other.name == this.name)
        {
            Console.WriteLine("They have the same name");
            return true;
        }
        else
        {
            Console.WriteLine("They have different names");
            return true;
        }
    }

    public int CompareTo(object obj)
    {
        //Player p as obj;
        Player p = obj as Player;

        if (p.age == age)
        {
            Console.WriteLine("We are the same age");
            return age;
        }
        if (p.age > age)
        {
            Console.WriteLine("Hi I am " + p.name + " and I am older");
            return age;
        }
        if (p.age < age)
        {
            Console.WriteLine("Hi I am " + p.name + " and I am younger");
            return age;
        }
        else
        {
            return 1;
        }
    }

    public object Clone()
    {
        string n;
        int a;

        n = this.name;
        a = this.age;

        Player clone = new Player(n, a);
        return clone;
    }
}

