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
        Player plist = new Player();
        Enemy eList = new Enemy();
        List<Unit> sortedlist = new List<Unit>();

       sortedlist = List.OrderByDescending(u => u.Speed).ToList<Unit>();

        foreach (Unit i in sortedlist)
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

        Console.WriteLine(sortedlist.ElementAt(0).Name + " attacks first!\n");

        return sortedlist;
    }

    //Function used for the fighting between objects
    public void Timetofight(bool b, List<Unit> uList, FiniteStateMachine<e_STATES> fsm)
    {
        //bool check = false;
        char input;
        Player plist = new Player();
        Enemy eList = new Enemy();
        Unit a = new Unit();


        for (int i = 0; i < uList.Count; i++)
        {
            if(uList.ElementAt(i).Type == "Player")
            {
                Console.Write("Do You Want To Attack or Guard? A or G: \n");
                input = (char)Console.Read();

                if(input == 'a' || input == 'A')
                {
                    //a.ChooseWhoToAttack(eList.EnemyParty);
                    if (uList.ElementAt(i).Attack(a.ChooseWhoToAttack(eList.EnemyParty)) == true)
                    {
                        //Next unit in the lists turn
                        break;
                    }
                }

            }
            else if (uList.ElementAt(i).Type == "Enemy")
            {

            }
            ////If b returned true then its a players turn 
            //if (b == true)
            //{
            //    Console.Write("Do You Want To Attack or Guard? A or G: \n");
            //    input = (char)Console.Read();


                //    if (input == 'a' || input == 'A')
                //    {
                //        a.ChooseWhoToAttack(eList.EnemyParty);
                //        if (uList.ElementAt(i).Attack(a.ChooseWhoToAttack(eList.EnemyParty)) == true)
                //        {//Call function again with a value set to false so the other object can have its turn
                //            Timetofight(false, uList, fsm);

                //        }
                //        //If attack function returns false that means enemy is dead
                //        else
                //        {

                //            fsm.ChangeStates(e_STATES.DEAD);
                //            // break;
                //        }
                //    }
                //    Console.WriteLine(plist.Party.ElementAt(i).Name + " attacked!");

                //}

                ////if b is false
                //else
                //{

                //    //Call attack function on the player object and if it returns true
                //    if (uList.ElementAt(i).Attack(a.EnemyRandomTarget(plist.Party)) == true)
                //    {//Call function again with a value set to true so the other object can have its turn
                //        Timetofight(true, uList, fsm);
                //    }
                //    //If attack function returns false that means the player is dead
                //    else
                //    {

                //        break;
                //        //if (Checkforvictory(check, plist.Party, eList.EnemyParty) == true)
                //        //{
                //        //    fsm.ChangeStates(e_STATES.DEAD);
                //        //}

                //    }
                //}
        }

    }

    //Function used to print out the current stats of all objects
    public void Statsofobjects(List<Unit> ulist)
    {
        //Print current stats
        Console.WriteLine("\nPlayer Stats:\n");

        for(int i = 0; i < ulist.Count; i++)
        {
            //Print player object name
            Console.WriteLine(ulist.ElementAt(i).Name + " Stats: \n");
            //Print player level, health, strength, defense, speed and experience
            Console.WriteLine("Level: " + ulist.ElementAt(i).Level + " Health: " + ulist.ElementAt(i).Health + " Strength: " + ulist.ElementAt(i).Strength + " Defense: " + ulist.ElementAt(i).Defense + " Speed: " + ulist.ElementAt(i).Speed + " Exp: " + ulist.ElementAt(i).Experience + "\n");
        }
    }

    public bool Checkforvictory(bool b, List<Player> plist, List<Enemy> elist)
    {
        int count = 0;
        int counts = 0;
        foreach(Player p in plist)
        {
            if(p.Life == false)
            {
                count++;
                if(plist.Count == count)
                {//No players alive in party
                    b = true;
                    //return b;
                }
            }
        }

       foreach(Enemy e in elist)
        {
            
            if(e.Life == false)
            {
                counts++;
                if (elist.Count == count)
                {//No enemies alive in party
                    b = true;
                    //return b;
                }
            }
        }

        return b;
    }
}

