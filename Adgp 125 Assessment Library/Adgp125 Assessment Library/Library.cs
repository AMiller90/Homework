using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Adgp125_Assessment_Library
{

    //Public interface for actions - T Generic type that can be passed as a parameter
    public interface IActions<T>
    {
        //Function used for the battling between units
        bool Attack(T u);

    }
    //Public interface for stats
    public interface IStats
    {//Property used for Level
        int Level { get; set; }
        //Property used for MaxHp
        int MaxHp { get; }
        //Property used for Health
        int Health { get; set; }
        //Property used for Strength
        int Strength { get; set; }
        //Property used for Speed
        int Speed { get; set; }
        //Property used for Defense
        int Defense { get; set; }
        //Property used for Experience
        int Experience { get; set; }
        //Property used for Type
        string Type { get; set; }
        //Property used for Name
        string Name { get; set; }
    }
    //Public interface for Managing - T Generic type that can be passed as a parameter
    public interface IManage<T>
    {//Function used to print the stats of objects in the game
        void Statsofobjects(T u);
        //Function used to check for victory
        bool Checkforvictory(T p, T e);
    }

    //Make class serializable
    //Inherits from IStats and IActions<Unit>
    [Serializable]
    //Public class used for units to create objects
    public class Unit : IStats, IActions<Unit>
    {//private int for defense
        private int m_uDefense;
        //private int for experience
        private int m_uExperience;
        //private int for health
        private int m_uHealth;
        //private int for Level
        private int m_uLevel;
        //private int for speed
        private int m_uSpeed;
        //private int for strength
        private int m_uStrength;
        //private string for Type
        private string m_uType;
        //private string for Name
        private string m_uName;
        //private bool for Life
        private bool m_Life;
        //private int for MaxhP
        private int m_uMaxHp;
        //private list<Unit>
        private List<Unit> m_Participants = new List<Unit>();
        //public string stuffText - Any text involved in battling other than stats 
        public string stuffText;

        //public Constructor
        public Unit()
        {


        }

        //public constructor used to construct objects
        public Unit(string name, int hp, int strength, int defense, int speed, int exp, string type)
        {//Set name to passed in variable
            m_uName = name;
            //Set Maxhp to passed in variable
            m_uMaxHp = hp;
            //Set strength to passed in variable
            m_uStrength = strength;
            //Set defense to passed in variable
            m_uDefense = defense;
            //Set speed to passed in variable
            m_uSpeed = speed;
            //Set experience to passed in variable
            m_uExperience = exp;
            //Set Type to passed in variable
            m_uType = type;
            //Set life to true
            m_Life = true;
            //Set Level to 1
            m_uLevel = 1;
            //Set health to passed in variable
            m_uHealth = hp;
        }
        //public string Name property
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
        //public int LEvel property
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
        //public int MaxHp property
        public int MaxHp
        {
            get
            {
                return m_uMaxHp;
            }

            set
            {
                m_uMaxHp = value;
            }
        }
        //public int Health property
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
        //public int Strength property
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
        //public int Defense property
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
        //public int Speed property
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
        //public int Experience property
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
        //public string Type property
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
        //public bool Life property
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
        //public List<Unit> property
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
        //public bool function used for attacking (Unit - takes in a unit variable to attack)
        public bool Attack(Unit u)
        {
            //If passed in unit is null 
            if (u == null)
            {//Print attack missed
                stuffText = this.Name + "Attack Missed!\n";
                //Return false
                return false;
            }
            //If the passed in units health is greater than 0
            if (u.Health > 0)
            {
                //Create a perc float variable that will contain the result of the passed in units defense multiplied by 0.25
                float perc = u.Defense * 0.25f;
                //Set an int variable to the value of the object that is calling this functions strength minus the perc variable
                int actualDamage = this.Strength - (int)perc;
                //Set the passed in units health minus equal to the actualDamage variable
                u.Health -= actualDamage;
                //Set stuffText variable to the attacking unit attacked the passed in units name and an endline
                stuffText = this.Name + " Attacked " + u.Name + "\n";
                //Add the passed in units name took actualDamage value and 2 new lines to the stuffText variable
                stuffText += u.Name + " took " + actualDamage + " damage!\n\n";
                //If passed in units health is less than or equal to 0
                if (u.Health <= 0)
                {//Add The Passed in units name has been killed with a new line to the stuffText variable
                    stuffText += u.Name + " has been killed!\n";
                    //Set the passed in units life to false
                    u.Life = false;
                    //Set the passed in units health to 0 - just so it doesnt show a negative number
                    u.Health = 0;
                    //If the unit that called the function is of type player
                    if (this.Type == "Player")
                    {//Give the player unit experience points equal to the amount of experience points of the enemy
                        this.Experience += u.Experience;
                        //Check if player has enough experience point to level up
                        this.LevelUp();
                    }
                    //Return false
                    return false;
                }
                //Return true
                return true;


            }
            else
            {
                //Add The Passed in units name has been killed with a new line to the stuffText variable
                stuffText += u.Name + " has been killed!\n";
                //Set the passed in units life to false
                u.Life = false;
                //If the unit that called the function is of type player
                if (this.Type == "Player")
                {//Give the player unit experience points equal to the amount of experience points of the enemy
                    this.Experience += u.Experience;
                    //Check if player has enough experience point to level up
                    this.LevelUp();
                }
                //If the passed in units health is less than 0
                if (u.Health < 0)
                {//Set the passed in units health to 0 - just so it doesnt show a negative number
                    u.Health = 0;
                }
                //Return false
                return false;


            }


        }

        //Function used to level up the unit
        public void LevelUp()
        {
            //Algorithm
            //int variable this will continusously update
            //Multiply the attacking units level by 50
            //Then store into the xpGoalToLevelUp variable
            int xpGoalToLevelUp = this.Level * 50;
            //If the current unit attackings experience is greater than or equal to the xpGoalToLevelUp variable
            if (this.Experience >= xpGoalToLevelUp)
            {//Add a new line and the name of the current unit and leveled up with another new line
                stuffText += "\n" + this.Name + " Leveled Up!\n";
                //Incerement the units level by 1
                this.Level++;
                //Set experience points back to 0
                this.Experience = 0;
                //Increment Max Hp by 20
                this.m_uMaxHp += 20;
                //Set health to Max Hp - This restores health when leveling up
                this.Health = m_uMaxHp;
                //Increment Strength by 5
                this.Strength += 5;
                //Increment Defense by 5
                this.Defense += 5;
                //Increment Speed by 2
                this.Speed += 2;

            }
        }

        //public function used for the enemy targeting a player
        public Unit EnemyRandomTarget(List<Unit> party)
        {//Create instance of a random object
            Random r = new Random();
            //Int variable used to store the random number that is between 0 and the max number of units in the list
            int index = r.Next(0, party.Count);
            //Create a unit variable to store the current unit at the index of the party list
            Unit defender = party[index];

            //If the defender units life is true
            if (defender.Life)
            {//Return that unit
                return defender;

            }
            //Return null if unit is dead
            return null;
        }

    }

    //Gamemanager class - Made into a singleton pattern - sealed does not allow class to be inherited from
    public sealed class GameManager : IManage<List<Unit>>
    {
        //Default constructor
        private GameManager() { }

        //Private variable that will be used in class only
        static private GameManager _instance;

        //Public property that can be called to instaniate once or reference to this class
        static public GameManager instance
        {
            get
            {
                //lazy instantiation
                //if it's null or doesn't exist then make it
                if (_instance == null)
                {//Create instance of GameManager
                    _instance = new GameManager();
                }
                //always return the private instance
                return _instance;
            }
        }

        //Public variable used to store the winning text data of which party wins
        public string winText;

        //Public variable used to store the stats of all objects in battle
        public string statsText;

        //Function used to print out the current stats of all objects
        public void Statsofobjects(List<Unit> ulist)
        {//Loop through the passed in list
            for (int i = 0; i < ulist.Count; i++)
            {//Print all objects level, health, strength, defense, speed and experience
                statsText += ulist[i].Name + " Stats: \n" + "Level: " + ulist[i].Level + " Health: " + ulist[i].Health + " Strength: " + ulist[i].Strength + " Defense: " + ulist[i].Defense + " Speed: " + ulist[i].Speed + " Exp: " + ulist[i].Experience + "\n";
            }
        }

        //Function used to check for victory (plist - List<unit> composed of players, elist - List<unit> composed of enemies)
        public bool Checkforvictory(List<Unit> plist, List<Unit> elist)
        {
            //Create and int variable to keep track of the count of players dead
            int pcount = 0;
            //Create and int variable to keep track of the count of enemies dead
            int ecount = 0;
            //Loop through the plist 
            foreach (Unit p in plist)
            {//If the current units life is false
                if (p.Life == false)
                {//Increase the p count by 1
                    pcount++;
                    //If pcount is equal to the count of the player party
                    if (plist.Count == pcount)
                    {//No players alive in party
                        winText = "Game Over! Enemy Wins!\n";
                        //Return true
                        return true;

                    }
                }
            }
            //Loop through the elist 
            foreach (Unit e in elist)
            {//If the current units life is false
                if (e.Life == false)
                {//Increase the e count by 1
                    ecount++;
                    //If ecount is equal to the count of the enemy party
                    if (elist.Count == ecount)
                    {//No enemies alive in party
                        winText = "Game Over! You Win!\n";
                        //Return true
                        return true;

                    }
                }
            }
            //Return false meaning at least one enemy and player are still alive
            return false;
        }

    }

}
