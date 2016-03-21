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

    //Function used for the fighting between objects
    public void Timetofight(List<Unit> uList, FiniteStateMachine<e_STATES> fsm)
    {

    //    Player plist = new Player();
    //    Enemy eList = new Enemy();
    //    List<Player> currentParty = new List<Player>();
    //    List<Enemy> enemyParty = new List<Enemy>();
    //    //Unit a = new Unit();

    //    foreach (Unit i in uList)
    //    {
    //        if (i.Type == "Player")
    //        {
    //            currentParty.Add((Player)i);

    //        }
    //        if (i.Type == "Enemy")
    //        {
    //            enemyParty.Add((Enemy)i);
    //        }

       }



    //    for (int i = 0; i < uList.Count; i++)
    //    {
    //        if (uList[i].Life == true)
    //        {
    //            Console.WriteLine("It is " + uList[i].Name + "'s turn!\n");
                
    //        }

    //        if (uList[i].Type == "Player" && uList[i].Life == true)
    //        {

    //            uList[i].ChooseWhoToAttack(enemyParty);
    //            uList[i].Attack(uList[i].Target);

    //        }
    //        if (uList[i].Type == "Enemy" && uList[i].Life == true)
    //        {
    //            // so much accessing
    //            // simplify code clarity by accessing what you want

    //            Unit Defender = uList[i].EnemyRandomTarget(currentParty);
    //            Unit Attacker = uList[i];

    //            //use your boolean checks to determine if you should break the loop
    //            if (!Attacker.Attack(Defender))
    //            {
    //                break;
    //            }
                   

    //        }


    //    }

    //    if (Checkforvictory(currentParty, enemyParty) == true)
    //    {
    //        fsm.ChangeStates(e_STATES.EXIT);

            
    //    }

    

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

