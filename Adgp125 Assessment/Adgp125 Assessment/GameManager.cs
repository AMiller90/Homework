using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gamemanager class - Made into a singleton pattern - sealed does not allow class to be inherited from
public sealed class GameManager : IManage<Player, Enemy, FiniteStateMachine<e_STATES>>
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
                _instance = new GameManager();
            //always return the private instance
            return _instance;
        }
    }

    //Function used to check the which object goes first based on higher speed stat
    public bool checkForSpeed(Player p, Enemy e)
    {
        //If player object has higher speed stat
        if (p.Speed > e.Speed)
        {
            Console.WriteLine(p.Name + " Goes First!");
            //Return true
            return true;
        }
        //If Enemy object has higher speed stat
        else
        {
            Console.WriteLine(e.Name + " Goes First!");
            //Return false
            return false; 
            
        }
    }

    //Function used for the fighting between objects
    public void Timetofight(bool b, Player p, Enemy e, FiniteStateMachine<e_STATES> fsm)
    {

        //If b is false
        if (b == false)
        {
            e.Turn = true;
            p.Turn = false;
            Console.WriteLine(e.Name + " attacked!");
            //Call attack function on the player object and if it returns true
            if (e.Attack(p) == true)
            {//Call function again with a value set to true so the other object can have its turn
                Timetofight(true, p, e, fsm);
            }
            //If attack function returns false that means the player is dead
            else
            {
                fsm.ChangeStates(e_STATES.DEAD);
            }
        }

        p.Turn = true;
        e.Turn = false;
       
        //Call attack function on the enemy object and if it returns true
        char input = (char)Console.Read();

        if (input == 'a')
        {
            Console.WriteLine(p.Name + " attacked!");
            if (p.Attack(e) == true)
            {//Call function again with a value set to false so the other object can have its turn
                Timetofight(false, p, e, fsm);

            }
            //If attack function returns false that means enemy is dead
            else
            {
                fsm.ChangeStates(e_STATES.DEAD);
            }
        }
        else if(input == 'g')
        {
            p.Guard();
            
        }
       
       

    
      
    }

    //Function used to print out the current stats of all objects
    public void Statsofobjects(Player p, Enemy e)
    {
        //Print current stats
        Console.WriteLine("\nCurrent Stats:\n");
        //Print player object name
        Console.WriteLine(p.Name + " Stats: \n");
        //Print player level, health, strength, defense, speed and experience
        Console.WriteLine("Level: " + p.Level + " Health: " + p.Health + " Strength: " + p.Strength + " Defense: " + p.Defense + " Speed: " + p.Speed + " Exp: " + p.Experience + "\n");

        //Print current stats
        //Console.WriteLine("\nCurrent Stats:\n");
        //Print enemy object name
        Console.WriteLine(e.Name + " Stats: \n");
        //Print enemy level, health, strength, defense, speed and experience
        Console.WriteLine("Level: " + e.Level + " Health: " + e.Health + " Strength: " + e.Strength + " Defense: " + e.Defense + " Speed: " + e.Speed + " Exp: " + e.Experience);
    }

}

