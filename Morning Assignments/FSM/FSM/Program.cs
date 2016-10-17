using System;
    public enum E_STATES
    {
        INIT,
        PLAY,
        GAMEOVER

    }

class Program
{
    static FiniteStateMachine<E_STATES> fsm = new FiniteStateMachine<E_STATES>();

    static public void Init()
     {
        Handler PlayHander = Play;
        PlayHander += DoStuff;

        Handler QuitHandler = Quit;

        fsm.State(E_STATES.INIT, null);
        fsm.State(E_STATES.PLAY, PlayHander);
        fsm.State(E_STATES.GAMEOVER, QuitHandler);

        fsm.AddTransition(E_STATES.INIT, E_STATES.PLAY, "auto");
        fsm.AddTransition(E_STATES.PLAY, E_STATES.GAMEOVER, "quit");

        fsm.Feed("auto");
    }

    static private void Play()
    {
        Console.WriteLine("The Game is now playing\n");
    }
    static private void DoStuff()
    {
        Console.WriteLine("Do Stuff");
    }

    static private void Quit()
    {
        Console.WriteLine("\nGameOver");
        Console.ReadKey();
    }

    static void Main(string[] args)
    {
        Init();

        while(Console.ReadKey().Key != ConsoleKey.Escape)
        {

        }

        fsm.Feed("quit");
    }
}
