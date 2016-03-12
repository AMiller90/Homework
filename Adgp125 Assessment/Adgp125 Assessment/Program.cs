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
            bool gameLoop = true;
            FiniteStateMachine<e_STATES> fsm = new FiniteStateMachine<e_STATES>();

            fsm.AddStates(e_STATES.INIT);
            fsm.AddStates(e_STATES.SEARCH);
            fsm.AddStates(e_STATES.TURN);
            fsm.AddStates(e_STATES.DEAD);

            fsm.Addtransition(e_STATES.INIT, e_STATES.SEARCH);
            fsm.Addtransition(e_STATES.SEARCH, e_STATES.TURN);
            fsm.Addtransition(e_STATES.TURN, e_STATES.DEAD);

            bool readytofight = false;
            //fsm.info();
            GameManager manager = new GameManager();
            Player Andrew = new Player("Andrew",100, 10, 10, 30);
            Enemy Ghost = new Enemy("Ghost", 100, 10, 10, 15);

            while (gameLoop)
            {
                switch(fsm.state)
                {
                    case e_STATES.INIT:
                        fsm.ChangeStates(e_STATES.SEARCH);
                        break;

                    case e_STATES.SEARCH:
                        readytofight = manager.checkForSpeed(Andrew, Ghost);
                        fsm.ChangeStates(e_STATES.TURN);
                        break;

                    case e_STATES.TURN:
                        manager.Timetofight(readytofight, Andrew, Ghost);
                        manager.Statsofobjects(Andrew, Ghost);
                        break;

                    case e_STATES.DEAD:
                        manager.Statsofobjects(Andrew, Ghost);
                        gameLoop = false;
                        break;

                    default:
                        break;
                }
            }
            
            
            

            
          



            Console.Read();
        }
    }
}
