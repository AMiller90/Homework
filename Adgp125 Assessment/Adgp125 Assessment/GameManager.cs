using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GameManager : IManage<Player, Enemy>
{
      public GameManager()
    {

    }

    public bool checkForSpeed(Player p, Enemy e)
    {

        if (p.Speed > e.Speed)
        {
            p.Turn = true;
            e.Turn = false;
            return true;
        }
        else
        {
            e.Turn = true;
            p.Turn = false;
            return false; 
            
        }
    }

    public void Timetofight(bool b, Player p, Enemy e)
    {
        if (b == true)
        {
            if(p.Attack(e) == true)
            {
                Timetofight(false, p, e);
            }
           
           
        }
        else
        {
            if(e.Attack(p) == true)
            {
                Timetofight(true, p, e);
            }
           
            
           
        }
    }

    public void Statsofobjects(Player p, Enemy e)
    {
        Console.WriteLine("\nCurrent Stats:\n");
        Console.WriteLine(p.Name + " Stats: \n");
        Console.WriteLine("Level: " + p.Level + " Health: " + p.Health + " Strength: " + p.Strength + " Defense: " + p.Defense + " Speed: " + p.Speed + " Exp: " + p.Experience);

        Console.WriteLine("\nCurrent Stats:\n");
        Console.WriteLine(e.Name + " Stats: \n");
        Console.WriteLine("Level: " + e.Level + " Health: " + e.Health + " Strength: " + e.Strength + " Defense: " + e.Defense + " Speed: " + e.Speed + " Exp: " + e.Experience);
    }

    
}

