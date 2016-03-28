using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gamemanager class - Made into a singleton pattern - sealed does not allow class to be inherited from
public sealed class GameManager : IManage<List<Unit>>
{
    //Create an instance of finite state machine with e_STATES as type
    public FiniteStateMachine<e_STATES> fsm = new FiniteStateMachine<e_STATES>();

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

    //Function used to check the which object goes first based on higher speed stat
    public List<Unit> sortBySpeed(List<Unit> List)
    {
        //Create a new list<Unit>
        List<Unit> sortedlist = new List<Unit>();
        //Set the new list to the passed in list ordered by highest speed stat first
        sortedlist = List.OrderByDescending(u => u.Speed).ToList<Unit>();
        //Return the new sorted list
        return sortedlist;
    }

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

