using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


[Serializable]
public class Unit : IStats, IActions<Unit>
{
    [NonSerialized]public string stuffText;
    private int m_uDefense;
    private int m_uExperience;
    private int m_uHealth;
    private int m_uLevel;
    private int m_uSpeed;
    private int m_uStrength;
    private string m_uType;
    private string m_uName;
    private Unit m_uTarget;
    private bool m_Life;
    private int m_uMaxHp;

    private List<Unit> m_Participants = new List<Unit>();


    public Unit()
    {


    }

    public Unit(string name, int hp, int strength, int defense, int speed, int exp, string type)
    {
        m_uName = name;
        m_uMaxHp = hp;
        m_uStrength = strength;
        m_uDefense = defense;
        m_uSpeed = speed;
        m_uExperience = exp;
        m_uType = type;
        m_Life = true;
        m_uLevel = 1;

        m_uHealth = m_uMaxHp;
    }

    public string Name
    {
        get
        {
            return m_uName;
        }

        set
        {
            m_uName = value;
        }
        
    }

    public int Level
    {
        get
        {
            return m_uLevel;
        }

        set
        {
            m_uLevel = value;
        }
    }

    public int MaxHp
    {
        get
        {
            return m_uMaxHp;
        }
    }

    public int Health
    {
        get
        {
            return m_uHealth;
        }

        set
        {
            m_uHealth = value;
        }
    }

    public int Strength
    {
        get
        {
            return m_uStrength;
        }

        set
        {
            m_uStrength = value;
        }
    }

    public int Defense
    {
        get
        {
            return m_uDefense;
        }

        set
        {
            m_uDefense = value;
        }
    }

    public int Speed
    {
        get
        {
            return m_uSpeed;
        }

        set
        {
            m_uSpeed = value;
        }
    }

    public int Experience
    {
        get
        {
            return m_uExperience;
        }

        set
        {
            m_uExperience = value;
        }
    }

    public string Type
    {
        get
        {
            return m_uType;
        }
        set
        {
            m_uType = value;
        }
    }

    public bool Life
    {
        get
        {
            return m_Life;
        }

        set
        {
            m_Life = value;
        }
    }

    public List<Unit> Participants
    {
        get
        {
            return m_Participants;
        }

        set
        {
            m_Participants = value;
        }
    }

    public Unit Target
    {
        get
        {
            return m_uTarget;
        }

        set
        {
            m_uTarget = value;
        }
    }

    public bool Attack(Unit u)
    {
        //is it null?
        //it could be because we return null from EnemyRandomTarget
        if (u == null)
        {
            stuffText += this.Name + "Attack Missed!\n";
            return false;
        }
          
            if (u.Health > 0)
            {

                //Create a perc float variable that will contain the result of the enemies defense multiplied by 0.25
                float perc = u.Defense * 0.25f;
                //Set the enemies health to the players' attacking strength mulitplied by the perc value
                int actualDamage = this.Strength - (int)perc;
                u.Health -= actualDamage;
                stuffText =  this.Name + " Attacked " + u.Name + "\n";
                stuffText += u.Name + " took " + actualDamage + " damage!\n\n";

                if (u.Health <= 0)
                {
                    stuffText += u.Name + " has been killed!\n";
                    u.Life = false;

                    u.Health = 0;

                   if (this.Type == "Player")
                    {
                        //Give player experience points equal to the amount of experience points of the enemy
                        this.Experience += u.Experience;
                        //Check if player has enough experience point to level up
                        this.LevelUp();
                    }
                    return false;
                }

                return true;


            }
            else
            {
            
                stuffText += u.Name + " has been killed!\n";
                u.Life = false;

                if (this.Type == "Player")
                {
                    //Give player experience points equal to the amount of experience points of the enemy
                    this.Experience += u.Experience;
                    //Check if player has enough experience point to level up
                    this.LevelUp();
                }

            if (u.Health < 0)
            {
                u.Health = 0;
            }

            return false;


            }
        

    }

    //Level up
    public void LevelUp()
    {
        if (this.Experience == 50)
        {
            stuffText += "\n" + this.Name + " Leveled Up!\n";
            this.Level++;
            this.Experience = 0;
            this.m_uMaxHp += 20;
            this.Health = m_uMaxHp;
            this.Strength += 5;
            this.Defense += 5;
            this.Speed += 2;

        }
    }

    public Unit EnemyRandomTarget(List<Unit> party)
    {
        Random r = new Random();
        
        int index = r.Next(0, party.Count);
        Unit defender = party[index];

        if (defender.Life)
        {
            return defender;

        }
        else
        {
            //stuffText = this.Name + " attack Missed!\n";
            //EnemyRandomTarget(party);
            
        }

        return null;
    }

}

