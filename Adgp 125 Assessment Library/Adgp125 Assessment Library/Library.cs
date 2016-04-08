using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Xml.Serialization;

namespace Adgp125_Assessment_Library
{

    //Public interface for actions - T Generic type that can be passed as a parameter
    public interface IActions<T>
    {
        //Function used for the battling between units
        bool Attack(T a_tU);

    }
    //Public interface for stats
    public interface IStats
    {//Property used for Level
        int iLevel { get; set; }
        //Property used for MaxHp
        int iMaxHp { get; }
        //Property used for Health
        int iHealth { get; set; }
        //Property used for Strength
        int iStrength { get; set; }
        //Property used for Speed
        int iSpeed { get; set; }
        //Property used for Defense
        int iDefense { get; set; }
        //Property used for Experience
        int iExperience { get; set; }
        //Property used for Type
        string sType { get; set; }
        //Property used for Name
        string sName { get; set; }
    }
    //Public interface for Managing - T Generic type that can be passed as a parameter
    public interface IManage<T>
    {//Function used to print the stats of objects in the game
        void StatsOfObjects(T a_tU);
        //Function used to check for victory
        bool CheckForVictory(T a_tP, T a_tE);
    }

    //Gamemanager class - Made into a singleton pattern - sealed does not allow class to be inherited from
    public sealed class GameManager : IManage<List<Unit>>
    {
       
        //Public property that can be called to instaniate once or reference to this class
        static public GameManager instance
        {
            get
            {
                //lazy instantiation
                //if it's null or doesn't exist then make it
                if (sm_oInstance == null)
                {//Create instance of GameManager
                    sm_oInstance = new GameManager();
                }
                //always return the private instance
                return sm_oInstance;
            }
        }

        //Default constructor
        private GameManager() { }

        //Private variable that will be used in class only
        static private GameManager sm_oInstance;

        //Public variable used to store the winning text data of which party wins
        public string winText;

        //Public variable used to store the stats of all objects in battle
        public string statsText;

        //Function used to print out the current stats of all objects
        public void StatsOfObjects(List<Unit> a_ulList)
        {//Loop through the passed in list
            for (int i = 0; i < a_ulList.Count; i++)
            {//Print all objects level, health, strength, defense, speed and experience
                statsText += a_ulList[i].sName + " Stats: \n" + "Level: " + a_ulList[i].iLevel + " Health: " + a_ulList[i].iHealth + " Strength: " + a_ulList[i].iStrength + " Defense: " + a_ulList[i].iDefense + " Speed: " + a_ulList[i].iSpeed + " Exp: " + a_ulList[i].iExperience + "\n";
            }
        }

        //Function used to check for victory (plist - List<unit> composed of players, elist - List<unit> composed of enemies)
        public bool CheckForVictory(List<Unit> a_ulPlist, List<Unit> a_ulElist)
        {
            //Create and int variable to keep track of the count of players dead
            int pcount = 0;
            //Create and int variable to keep track of the count of enemies dead
            int ecount = 0;
            //Loop through the plist 
            foreach (Unit p in a_ulPlist)
            {//If the current units life is false
                if (p.bLife == false)
                {//Increase the p count by 1
                    pcount++;
                    //If pcount is equal to the count of the player party
                    if (a_ulPlist.Count == pcount)
                    {//No players alive in party
                        winText = "Game Over! Enemy Wins!\n";
                        //Return true
                        return true;

                    }
                }
            }
            //Loop through the elist 
            foreach (Unit e in a_ulPlist)
            {//If the current units life is false
                if (e.bLife == false)
                {//Increase the e count by 1
                    ecount++;
                    //If ecount is equal to the count of the enemy party
                    if (a_ulPlist.Count == ecount)
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

    //Inherits from IStats and IActions<Unit>
    //[Serializable]
    //Public class used for units to create objects
    public class Unit : IStats, IActions<Unit>
    {//private int for defense
        private int m_iDefense;
        //private int for experience
        private int m_iExperience;
        //private int for health
        private int m_iHealth;
        //private int for Level
        private int m_iLevel;
        //private int for speed
        private int m_iSpeed;
        //private int for strength
        private int m_iStrength;
        //private string for Type
        private string m_sType;
        //private string for Name
        private string m_sName;
        //private bool for Life
        private bool m_bLife;
        //private int for MaxhP
        private int m_iMaxHp;
        //private list<Unit>
        private List<Unit> m_ulParticipants = new List<Unit>();
        //public string stuffText - Any text involved in battling other than stats 
        [XmlIgnoreAttribute]
        public string sStuffText;

        //public Constructor
        public Unit()
        {


        }

        //public constructor used to construct objects
        public Unit(string name, int hp, int strength, int defense, int speed, int exp, string type)
        {//Set name to passed in variable
            m_sName = name;
            //Set Maxhp to passed in variable
            m_iMaxHp = hp;
            //Set strength to passed in variable
            m_iStrength = strength;
            //Set defense to passed in variable
            m_iDefense = defense;
            //Set speed to passed in variable
            m_iSpeed = speed;
            //Set experience to passed in variable
            m_iExperience = exp;
            //Set Type to passed in variable
            m_sType = type;
            //Set life to true
            m_bLife = true;
            //Set Level to 1
            m_iLevel = 1;
            //Set health to passed in variable
            m_iHealth = hp;
        }
        //public string Name property
        public string sName
        {
            get
            {
                return m_sName;
            }

            set
            {
                m_sName = value;
            }

        }
        //public int LEvel property
        public int iLevel
        {
            get
            {
                return m_iLevel;
            }

            set
            {
                m_iLevel = value;
            }
        }
        //public int MaxHp property
        public int iMaxHp
        {
            get
            {
                return m_iMaxHp;
            }

            set
            {
                m_iMaxHp = value;
            }
        }
        //public int Health property
        public int iHealth
        {
            get
            {
                return m_iHealth;
            }

            set
            {
                m_iHealth = value;
            }
        }
        //public int Strength property
        public int iStrength
        {
            get
            {
                return m_iStrength;
            }

            set
            {
                m_iStrength = value;
            }
        }
        //public int Defense property
        public int iDefense
        {
            get
            {
                return m_iDefense;
            }

            set
            {
                m_iDefense = value;
            }
        }
        //public int Speed property
        public int iSpeed
        {
            get
            {
                return m_iSpeed;
            }

            set
            {
                m_iSpeed = value;
            }
        }
        //public int Experience property
        public int iExperience
        {
            get
            {
                return m_iExperience;
            }

            set
            {
                m_iExperience = value;
            }
        }
        //public string Type property
        public string sType
        {
            get
            {
                return m_sType;
            }
            set
            {
                m_sType = value;
            }
        }
        //public bool Life property
        public bool bLife
        {
            get
            {
                return m_bLife;
            }

            set
            {
                m_bLife = value;
            }
        }
        //public List<Unit> property
        public List<Unit> ulParticipants
        {
            get
            {
                return m_ulParticipants;
            }

            set
            {
                m_ulParticipants = value;
            }
        }
        //public bool function used for attacking (Unit - takes in a unit variable to attack)
        public bool Attack(Unit a_uU)
        {
            //If passed in unit is null 
            if (a_uU == null)
            {//Print attack missed
                sStuffText = this.sName + "Attack Missed!\n";
                //Return false
                return false;
            }
            //If the passed in units health is greater than 0
            if (a_uU.iHealth > 0)
            {
                //Create a perc float variable that will contain the result of the passed in units defense multiplied by 0.25
                float perc = a_uU.iDefense * 0.25f;
                //Set an int variable to the value of the object that is calling this functions strength minus the perc variable
                int actualDamage = this.iStrength - (int)perc;
                //Set the passed in units health minus equal to the actualDamage variable
                a_uU.iHealth -= actualDamage;
                //Set stuffText variable to the attacking unit attacked the passed in units name and an endline
                sStuffText = this.sName + " Attacked " + a_uU.sName + "\n";
                //Add the passed in units name took actualDamage value and 2 new lines to the stuffText variable
                sStuffText += a_uU.sName + " took " + actualDamage + " damage!\n\n";
                //If passed in units health is less than or equal to 0
                if (a_uU.iHealth <= 0)
                {//Add The Passed in units name has been killed with a new line to the stuffText variable
                    sStuffText += a_uU.sName + " has been killed!\n";
                    //Set the passed in units life to false
                    a_uU.bLife = false;
                    //Set the passed in units health to 0 - just so it doesnt show a negative number
                    a_uU.iHealth = 0;
                    //If the unit that called the function is of type player
                    if (this.sType == "Player")
                    {//Give the player unit experience points equal to the amount of experience points of the enemy
                        this.iExperience += a_uU.iExperience;
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
                sStuffText += a_uU.sName + " has been killed!\n";
                //Set the passed in units life to false
                a_uU.bLife = false;
                //If the unit that called the function is of type player
                if (this.sType == "Player")
                {//Give the player unit experience points equal to the amount of experience points of the enemy
                    this.iExperience += a_uU.iExperience;
                    //Check if player has enough experience point to level up
                    this.LevelUp();
                }
                //If the passed in units health is less than 0
                if (a_uU.iHealth < 0)
                {//Set the passed in units health to 0 - just so it doesnt show a negative number
                    a_uU.iHealth = 0;
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
            int xpGoalToLevelUp = this.iLevel * 50;
            //If the current unit attackings experience is greater than or equal to the xpGoalToLevelUp variable
            if (this.iExperience >= xpGoalToLevelUp)
            {//Add a new line and the name of the current unit and leveled up with another new line
                sStuffText += "\n" + this.sName + " Leveled Up!\n";
                //Incerement the units level by 1
                this.iLevel++;
                //Set experience points back to 0
                this.iExperience = 0;
                //Increment Max Hp by 20
                this.iMaxHp += 20;
                //Set health to Max Hp - This restores health when leveling up
                this.iHealth = m_iMaxHp;
                //Increment Strength by 5
                this.iStrength += 5;
                //Increment Defense by 5
                this.iDefense += 5;
                //Increment Speed by 2
                this.iSpeed += 2;

            }
        }

        //public function used for the enemy targeting a player
        public Unit EnemyRandomTarget(List<Unit> a_ulParty)
        {//Create instance of a random object
            Random r = new Random();
            //Int variable used to store the random number that is between 0 and the max number of units in the list
            int index = r.Next(0, a_ulParty.Count);
            //Create a unit variable to store the current unit at the index of the party list
            Unit defender = a_ulParty[index];

            //If the defender units life is true
            if (defender.bLife)
            {//Return that unit
                return defender;

            }
            //Return null if unit is dead
            return null;
        }

    }

    //Public class used for containing units
    [XmlRoot("Party")]
    public class Party
    {//Public constructor
        public Party()
        {//Initialize a unit list with each instance of a party object
            m_ulUnits = new List<Unit>();

        }
        //Private list of units variable
        private List<Unit> m_ulUnits;

        //Sets the name of the Array to party, Sets the items in the array as Unit type and gives the element name as Unit
        [XmlArray("Party"), XmlArrayItem(typeof(Unit), ElementName = "Unit")]
        //Public List<Unit> property
        public List<Unit> ulUnits
        {
            get
            {//return units variable
                return m_ulUnits;
            }

            set
            {//give the units variable a value
                m_ulUnits = value;
            }
        }

    }

}
