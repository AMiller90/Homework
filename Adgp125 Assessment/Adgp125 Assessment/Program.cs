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
    BATTLE,
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
            fsm.AddStates(e_STATES.BATTLE);
            fsm.AddStates(e_STATES.DEAD);

            fsm.Addtransition(e_STATES.INIT, e_STATES.SEARCH);
            fsm.Addtransition(e_STATES.SEARCH, e_STATES.BATTLE);
            fsm.Addtransition(e_STATES.BATTLE, e_STATES.DEAD);

            bool readytofight = true;
         
            GameManager manager = GameManager.instance;

            Unit a = new Unit();

            Player plist = new Player();
            Enemy eList = new Enemy();

            Player Cloud = new Player("Cloud", 200, 10, 10, 30, "Player");
            Player Tifa= new Player("Tifa", 200, 10, 10, 35, "Player");

            Enemy Ghost = new Enemy("Ghost", 20, 10, 10, 15, "Enemy");
            Enemy Spook = new Enemy("Spook", 20, 10, 10, 6, "Enemy");

           
            a.Participants.Add(Cloud);
            a.Participants.Add(Tifa);
            a.Participants.Add(Ghost);
            a.Participants.Add(Spook);

            List<Unit> BattleGroup = new List<Unit>();

            while (gameLoop)
            {
                switch (fsm.state)
                {
                    case e_STATES.INIT:
                        fsm.ChangeStates(e_STATES.SEARCH);
                        break;

                    case e_STATES.SEARCH:
                        BattleGroup = manager.sortBySpeed(a.Participants);
                        fsm.ChangeStates(e_STATES.BATTLE);
                        break;

                    case e_STATES.BATTLE:
                        manager.Timetofight(readytofight, BattleGroup, fsm);
                        break;

                    case e_STATES.DEAD:
                        manager.Statsofobjects(a.Participants);
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
