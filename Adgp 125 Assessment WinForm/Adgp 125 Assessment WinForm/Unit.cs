using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Soap;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public class Unit : IStats, IActions<Unit>
{
   
    public string stuffText;
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
    private List<Unit> m_Participants = new List<Unit>();


    public Unit()
    {


    }

    public Unit(string name, int hp, int strength, int defense, int speed, int exp, string type)
    {
        m_uName = name;
        m_uHealth = hp;
        m_uStrength = strength;
        m_uDefense = defense;
        m_uSpeed = speed;
        m_uExperience = exp;
        m_uType = type;
        m_Life = true;
        m_uLevel = 1;
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

    public string Name
    {
        get
        {
            return m_uName;
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
            this.Health = m_uHealth;
            this.Health += 10;
            this.Strength += 5;
            this.Defense += 5;
            this.Speed += 2;

        }
    }

    public Unit ChooseWhoToAttack(List<Unit> eParty)
    {

        Console.WriteLine("Who Do You Want To Attack? Type in the Number of target: \n");
        for (int i = 0; i < eParty.Count; i++)
        {
            Console.WriteLine(eParty[i].Name);
        }

        Console.Write("\n");
        string input;
        input = Console.ReadLine();


        for (int i = 0; i < eParty.Count; i++)
        {
            if (input == eParty[i].Name && eParty[i].Life == true)
            {
                m_uTarget = eParty[i];
                return m_uTarget;
            }
            else if (input == eParty[i].Name && eParty[i].Life == false)
            {
                Console.WriteLine(eParty[i].Name + " is already dead!\n");
                ChooseWhoToAttack(eParty);
            }

        }

        return null;
    }

    /// <summary>
    /// override the previous enemyrandomtarget function with a recursive base case
    /// 
    /// </summary>
    /// <param name="party"></param>
    /// <param name="dead"></param>
    /// <returns></returns>
    /// 
    public Unit EnemyRandomTarget(List<Unit> party, int dead)
    {
        dead++;
        //dis is bad
        //you will only ever roll an enemy attack for however many members are in the group
        //figure it out
        //recursive calls must have a base case that they use to break out
        //can either use tail recursion or head recursion
        //you do not know what those are... can look it up or alternatively just keep track of how many
        //party members are dead and break when that count is equal to the number of party members
        if (dead >= party.Count)
        {
            return null;
        }
            
        else
        {
            EnemyRandomTarget(party, dead);
        }
            

        return null;

    }

    public Unit EnemyRandomTarget(List<Unit> party)
    {
        int deadCount = 0;
        Random r = new Random();
        
        int index = r.Next(0, party.Count);
        Unit defender = party[index];

        if (defender.Life)
        {
            return defender;

        }
        else
        {
            EnemyRandomTarget(party, deadCount);
            
        }

        return null;
    }

}

