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
    GAMEOVER

}
public delegate void Handler();

namespace Adgp125_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            
            FiniteStateMachine<e_STATES> fsm = new FiniteStateMachine<e_STATES>();

            //fsm.info();

            Handler initHandler = p.test;
            Handler searchHandler = p.test2;
            Handler battleHandler = p.test3;
            Handler gameoverHandler = p.test4;

            fsm.State(e_STATES.INIT, initHandler);
            fsm.State(e_STATES.SEARCH, searchHandler);
            fsm.State(e_STATES.BATTLE, battleHandler);
            fsm.State(e_STATES.GAMEOVER, gameoverHandler);
           
            fsm.AddTransition(e_STATES.INIT, e_STATES.SEARCH, 'S');

            fsm.Feed('S');

            //string input =  Console.ReadLine();


            Console.Read();
        }

        void test()
        {
            Console.WriteLine("Init Function");
        }

        void test2()
        {
            Console.WriteLine("Search Function");
        }

        void test3()
        {
            Console.WriteLine("Battle Function");
        }

        void test4()
        {
            Console.WriteLine("Gameover Function");
        }
    }

   
}

