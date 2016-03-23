using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gamemanager class - Made into a singleton pattern - sealed does not allow class to be inherited from
public sealed class GameManager : IManage<List<Unit>, FiniteStateMachine<e_STATES>>
{
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
            {
                _instance = new GameManager();
            }
            //always return the private instance
            return _instance;
        }
    }

    public string winText;

    public string statsText;

    //Function used to check the which object goes first based on higher speed stat
    public List<Unit> sortBySpeed(List<Unit> List)
    {
        List<Unit> sortedlist = new List<Unit>();

        sortedlist = List.OrderByDescending(u => u.Speed).ToList<Unit>();

        Console.WriteLine(sortedlist.ElementAt(0).Name + " attacks first!\n");

        return sortedlist;
    }

//Function used to print out the current stats of all objects

public void Statsofobjects(List<Unit> ulist)
{
    for (int i = 0; i < ulist.Count; i++)
    {
        //Print player level, health, strength, defense, speed and experience
        statsText += ulist[i].Name + " Stats: \n" + "Level: " + ulist[i].Level + " Health: " + ulist[i].Health + " Strength: " + ulist[i].Strength + " Defense: " + ulist[i].Defense + " Speed: " + ulist[i].Speed + " Exp: " + ulist[i].Experience + "\n";
    }
}

public bool Checkforvictory(List<Unit> plist, List<Unit> elist)
    {
        int pcount = 0;
        int ecount = 0;

        foreach (Unit p in plist)
        {
            if (p.Life == false)
            {
                pcount++;
                if (plist.Count == pcount)
                {//No players alive in party
                    winText = "Game Over! Enemy Wins!\n";
                    return true;

                }
            }
        }

        foreach (Unit e in elist)
        {

            if (e.Life == false)
            {
                ecount++;
                if (elist.Count == ecount)
                {//No enemies alive in party
                    winText = "Game Over! You Win!\n";
                    return true;

                }
            }
        }

        return false;
    }

}

