using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Enemy : Unit, IStats, IActions<Player>
{
    
    private string m_ename;
    private int m_elevel = 1;
    private int m_ehp;
    private int m_estr;
    private int m_edef;
    private int m_espd;
    private int m_exp = 50;
    private bool m_eturn;
    private string m_eType;

    public Enemy(string name, int hp, int strength, int defense, int speed, string t)
    {
        m_ename = name;
        m_ehp = hp;
        m_estr = strength;
        m_edef = defense;
        m_espd = speed;
        m_elevel = Level;
        m_exp = Experience;
        Type = t;
    }

    public int Level
    {
        get
        {
            return m_elevel;
        }

        set
        {
            m_elevel = value;
        }
    }

    public int Health
    {
        get
        {
            return m_ehp;
        }

        set
        {
            m_ehp = value;
        }
    }

    public int Strength
    {
        get
        {
            return m_estr;
        }

        set
        {
            m_estr = value;
        }
    }

    public int Defense
    {
        get
        {
            return m_edef;
        }

        set
        {
            m_edef = value;
        }
    }

    public int Speed
    {
        get
        {
            return m_espd;
        }

        set
        {
            m_espd = value;
        }
    }

    public int Experience
    {
        get
        {
            return m_exp;
        }

        set
        {
            m_exp = value;
        }
    }

    public bool Turn
    {
        get
        {
            return m_eturn;
        }

        set
        {
            m_eturn = value;
        }
    }

    public string Name
    {
        get
        {
            return m_ename;
        }
    }

    public bool Attack(Player p)
    {
        //If the player health is greater than 0
        if (p.Health > 0)
        {

            //Create a perc float variable that will contain the result of the enemies defense multiplied by 0.1
            float perc = p.Defense * 0.25f;
            //Set the enemies health to the players' attacking strength mulitplied by the perc value
            p.Health -= this.m_estr * (int)perc;
            Console.WriteLine(p.Name + " took " + this.m_estr * (int)perc + " damage!");
            return true;

        }
        //If player health is equal to or less than 0
        else
        {
            Console.WriteLine(p.Name + " has been killed!");
            //Player is dead return false
            return false;
        }

    }
}

