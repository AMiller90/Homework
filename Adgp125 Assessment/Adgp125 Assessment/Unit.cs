using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




public class Unit : IStats , IActions<Unit>
{
    
    private int m_uDefense;
    private int m_uExperience;
    private int m_uHealth;
    private int m_uLevel;
    private int m_uSpeed;
    private int m_uStrength;
    private bool m_uTurn;
    private string m_uType;
    private string m_uName;
    private Unit m_uTarget;
    private bool m_Life;
    private List<Unit> m_Participants = new List<Unit>();


    public Unit()
    {
    

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

    public bool Turn
    {
        get
        {
            return m_uTurn;
        }

        set
        {
            m_uTurn = value;
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

        set
        {
            m_uName = value;
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

        if(this.Type != u.Type)
        {
            if (u.Health > 0)
            {

                //Create a perc float variable that will contain the result of the enemies defense multiplied by 0.1
                float perc = u.Defense * 0.25f;
                //Set the enemies health to the players' attacking strength mulitplied by the perc value
                u.Health -= this.Strength * (int)perc;
                Console.WriteLine(u.Name + " took " + this.Strength * (int)perc + " damage!");
                return true;

            }
            else
            {

                Console.WriteLine(u.Name + " has been killed!");
                u.Life = false;

                if(this.Type == "Player")
                {
                    //Give player experience points equal to the amount of experience points of the enemy
                    this.Experience += u.Experience;
                    //Check if player has enough experience point to level up
                    this.LevelUp();
                }
               

                return false;
            }
        }
        else
        {
            //Console.WriteLine("Can't Attack Own Party Member");
            return false;
        }

    }

    //Level up
    public void LevelUp()
    {
        if (this.Experience == 50)
        {
            Console.Write("Level Up!\n");
            this.Level++;
            this.Experience = 0;
            this.Health += 10;
            this.Strength += 5;
            this.Defense += 5;
            this.Speed += 2;

        }
    }

    public Unit ChooseWhoToAttack(List<Enemy> eParty)
    {
        string Input;
        
        Console.WriteLine("Who Do You Want To Attack? Type in the Name of target: \n");
        for (int i = 0; i < eParty.Count; i++)
        {
            Console.WriteLine(eParty.ElementAt(i).Name);
        }

        
        Input = Console.ReadLine();
        for (int i = 0; i < eParty.Count; i++)
        {
            if (Input == eParty.ElementAt(i).Name && eParty.ElementAt(i).Life == true)
            {
               Target = eParty.ElementAt(i);

            }
            else if(Input == eParty.ElementAt(i).Name && eParty.ElementAt(i).Life == false)
            {
                Console.WriteLine(eParty.ElementAt(i).Name + " is already dead!\n");
                ChooseWhoToAttack(eParty);

            }
            
        }

        return Target;
    }

    public Unit EnemyRandomTarget(List<Player> party)
    {
        Random r = new Random();

        int index = r.Next(0, party.Count);
        
        for (int i = 0; i < party.Count; i++)
        {
            if (index == party.IndexOf(party.ElementAt(i)) && party.ElementAt(i).Life == true)
            {
                Target = party.ElementAt(i);

            }
            else if (index == party.IndexOf(party.ElementAt(i)) && party.ElementAt(i).Life == false)
            {
                Console.WriteLine(party.ElementAt(i).Name + " is already dead!\n");
                EnemyRandomTarget(party);

            }

        }

        return m_uTarget;
    }

}

