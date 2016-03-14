using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum e_STATES
{//Upon starting game
    INIT,
    //Searches for who attacks first
    SEARCH,
    //The current turn
    TURN,
    //Out of health
    DEAD

}

namespace Adgp125_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool gameLoop = true;
            FiniteStateMachine<e_STATES> fsm = new FiniteStateMachine<e_STATES>();

            fsm.AddStates(e_STATES.INIT);
            fsm.AddStates(e_STATES.SEARCH);
            fsm.AddStates(e_STATES.TURN);
            fsm.AddStates(e_STATES.DEAD);

            fsm.Addtransition(e_STATES.INIT, e_STATES.SEARCH);
            fsm.Addtransition(e_STATES.SEARCH, e_STATES.TURN);
            fsm.Addtransition(e_STATES.TURN, e_STATES.DEAD);

            //bool readytofight = false;

            List<Unit> unitlist = new List<Unit>();

            GameManager manager = GameManager.instance;
            Player Andrew = new Player("Andrew", 200, 10, 10, 30, "Player");
            Player Andrew2 = new Player("Andrew", 200, 10, 10, 30, "Player");
            Enemy Ghost = new Enemy("Ghost", 100, 10, 10, 15, "Enemy");


            List<Player> Party = new List<Player>();

            unitlist.Add(Andrew);
            unitlist.Add(Ghost);
            unitlist.Add(Andrew2);
            foreach(Unit u in unitlist)
            {
                if (u.Type == "Player")
                {
                    Party.Add((Player)u);
                }
            }

         
            
                Console.WriteLine(unitlist.Count);
            

            //Console.WriteLine(unitlist.ElementAt(2).Type);
            


            //while (gameLoop)
            //{
            //    switch(fsm.state)
            //    {
            //        case e_STATES.INIT:
            //            fsm.ChangeStates(e_STATES.SEARCH);
            //            break;

            //        case e_STATES.SEARCH:
            //            readytofight = manager.checkForSpeed(Andrew, Ghost);
            //            fsm.ChangeStates(e_STATES.TURN);
            //            break;

            //        case e_STATES.TURN:
            //            Console.Write("Do You Want To Attack or Guard? A or G: \n");
            //            manager.Timetofight(readytofight, Andrew, Ghost, fsm);
            //            break;

            //        case e_STATES.DEAD:
            //            manager.Statsofobjects(Andrew, Ghost);
            //            gameLoop = false;  
            //            break;

            //        default:
            //            break;
            //    }
            //}


            Console.Read();
        }
    }
}
