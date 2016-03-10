using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    class Program
    {

        public enum PlayerStates
        {
            INIT, IDLE, WALK, RUN
        }

        static void Main(string[] args)
        {

            FiniteStateMachine fsm = new FiniteStateMachine(PlayerStates.INIT);
            fsm.AddStates(PlayerStates.INIT);
            fsm.AddStates(PlayerStates.IDLE);
            fsm.AddStates(PlayerStates.WALK);
            fsm.AddStates(PlayerStates.RUN);

            fsm.Addtransition(PlayerStates.INIT, PlayerStates.IDLE);
            fsm.Addtransition(PlayerStates.IDLE, PlayerStates.WALK);
            fsm.Addtransition(PlayerStates.WALK, PlayerStates.IDLE);
            fsm.Addtransition(PlayerStates.WALK, PlayerStates.RUN);
            fsm.Addtransition(PlayerStates.RUN, PlayerStates.WALK);


            fsm.info();

            fsm.ChangeStates(PlayerStates.WALK);

            Console.Read();
        }

        
    
    }
}
