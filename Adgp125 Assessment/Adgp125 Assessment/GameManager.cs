using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gamemanager class - Made into a singleton pattern - sealed does not allow class to be inherited from
public sealed class GameManager : IManage<List<Unit>, List<Player>, List<Enemy>, FiniteStateMachine<e_STATES>>
{
    //Default constructor
    GameManager() { }

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

        Player plist = new Player();
        Enemy eList = new Enemy();
        Unit a = new Unit();


        foreach (Unit i in uList)
        {
            if (i.Type == "Player")
            {
                plist.Party.Add((Player)i);


            }
            if (i.Type == "Enemy")
            {
                eList.EnemyParty.Add((Enemy)i);
            }

        }

        for (int i = 0; i < uList.Count; i++)
        {
            if (uList[i].Life == true)
            {
                Console.WriteLine("It is " + uList[i].Name + "'s turn!\n");
            }

            if (uList[i].Type == "Player" && uList[i].Life == true)
            {

                uList[i].ChooseWhoToAttack(eList.EnemyParty);
                uList[i].Attack(uList[i].Target);

            }
            if (uList[i].Type == "Enemy" && uList[i].Life == true)
            {
                // so much accessing
                // simplify code clarity by accessing what you want

                Unit Defender = uList[i].EnemyRandomTarget(plist.Party);
                Unit Attacker = uList[i];

                //use your boolean checks to determine if you should break the loop
                if (!Attacker.Attack(Defender))
                {
                    break;
                }
                   

            }


        }

        if (Checkforvictory(plist.Party, eList.EnemyParty) == true)
        {
            fsm.ChangeStates(e_STATES.GAMEOVER);
        }

    }

    //Function used to print out the current stats of all objects
    public void Statsofobjects(List<Unit> ulist)
    {
        //Print current stats
        Console.WriteLine("\nPlayer Stats:\n");

        for (int i = 0; i < ulist.Count; i++)
        {
            //Print player object name
            Console.WriteLine(ulist.ElementAt(i).Name + " Stats: \n");
            //Print player level, health, strength, defense, speed and experience
            Console.WriteLine("Level: " + ulist.ElementAt(i).Level + " Health: " + ulist.ElementAt(i).Health + " Strength: " + ulist.ElementAt(i).Strength + " Defense: " + ulist.ElementAt(i).Defense + " Speed: " + ulist.ElementAt(i).Speed + " Exp: " + ulist.ElementAt(i).Experience + "\n");
        }
    }

    public bool Checkforvictory(List<Player> plist, List<Enemy> elist)
    {
        int pcount = 0;
        int ecount = 0;

        foreach (Player p in plist)
        {
            if (p.Life == false)
            {
                pcount++;
                if (plist.Count == pcount)
                {//No players alive in party
                    Console.WriteLine("Game Over! Enemy Wins!\n");
                    return true;

                }
            }
        }

        foreach (Enemy e in elist)
        {

            if (e.Life == false)
            {
                ecount++;
                if (elist.Count == ecount)
                {//No enemies alive in party
                    Console.WriteLine("Game Over! You Win!\n");
                    return true;

                }
            }
        }

        return false;
    }

}

