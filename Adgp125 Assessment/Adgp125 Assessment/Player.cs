using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Player : Unit, IStats
{
  
   
    private int m_level = 1;
    private int m_xp = 0;
    private List<Player> m_Party = new List<Player>();

    public Player()
    {

    }

    public Player(string name, int hp, int strength, int defense, int speed, string type)
    {
        Name = name;
        Level = m_level;
        Experience = m_xp;
        Health = hp;
        Strength = strength;
        Defense = defense;
        Speed = speed;
        Type = type;
        Life = true;
      
    }

    public List<Player> Party
    {
        get
        {
            return m_Party;
        }

        set
        {
            m_Party = value;
        }

    }

    //public int Level
    //{
    //    get
    //    {
    //        return m_level;
    //    }

    //    set
    //    {
    //        m_level = value;
    //    }
    //}

    //public int Health
    //{
    //    get
    //    {
    //        return m_hp;
    //    }

    //    set
    //    {
    //        m_hp = value;
    //    }
    //}

    //public int Strength
    //{
    //    get
    //    {
    //        return m_str;
    //    }

    //    set
    //    {
    //        m_str = value;
    //    }
    //}

    //public int Defense
    //{
    //    get
    //    {
    //        return m_def;
    //    }

    //    set
    //    {
    //        m_def = value;
    //    }
    //}

    //public int Speed
    //{
    //    get
    //    {
    //        return m_spd;
    //    }

    //    set
    //    {
    //        m_spd = value;
    //    }
    //}

    //public bool Turn
    //{
    //    get
    //    {
    //        return m_turn;
    //    }

    //    set
    //    {
    //        m_turn = value;
    //    }
    //}

    //public int Experience
    //{
    //    get
    //    {
    //        return m_xp;
    //    }

    //    set
    //    {
    //        m_xp = value;
    //    }
    //}

    //public string Name
    //{
    //    get
    //    {
    //        return m_name;
    //    }


    //}

    //Attack Function

    //public bool Attack(Enemy e)
    //{
    //    if (e.Health > 0)
    //    {

    //        //Create a perc float variable that will contain the result of the enemies defense multiplied by 0.1
    //        float perc = e.Defense * 0.25f;
    //        //Set the enemies health to the players' attacking strength mulitplied by the perc value
    //        e.Health -= this.Strength * (int)perc;
    //        Console.WriteLine(e.Name + " took " + this.Strength * (int)perc + " damage!");
    //        return true;

    //    }
    //    else 
    //    {
    //        Console.WriteLine(e.Name + " has been killed!");
    //        //Give player experience points equal to the amount of experience points of the enemy
    //        this.Experience += e.Experience;
    //        //Check if player has enough experience point to level up
    //        LevelUp();

    //        return false;
    //    }




    //}

    ////Guard Function
    //public void Guard()
    //{
    //        //Set new float variable to the current defense of this player mulitplied by 0.25
    //        float buff = this.Defense * 0.25f;
    //        //Increase current players defense by value stored in increaseD varaiable
    //        this.Defense += (int)buff;

    //}

  
}

