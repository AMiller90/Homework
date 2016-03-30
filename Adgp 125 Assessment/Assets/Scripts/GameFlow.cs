using UnityEngine;
using System.Collections;
using System.Collections.Generic;
//Namespace used to reference finite state machine
using FiniteStateMachine;
//Namespace used to reference unit class, interfaces and ame manager singleton
using Adgp125_Assessment_Library;
//Namespace used to reference the FileIO class that will allow serialization and deserialization
using FileIO;
using System.Linq;

public enum e_GameStates
{
    INIT,
    START,
    SEARCH,
    BATTLE,
    PLAYERTURN,
    ENEMYTURN,
    EXIT
}

public class GameFlow : MonoBehaviour {

    Unit a = new Unit();
    public FiniteStateMachine<e_GameStates> fsm = new FiniteStateMachine<e_GameStates>();
    private List<Unit> BattleReadyParty = new List<Unit>();


	// Use this for initialization
	void Start ()
    {
        Handler searchHandler = searchState;
        //Handler battleHandler;
        //Handler playerturnHandler;
        //Handler enemyturnHandler;
        //Handler exitHandler;
       
        fsm.State(e_GameStates.INIT, null);
        fsm.State(e_GameStates.START, null);
        fsm.State(e_GameStates.SEARCH, searchHandler);

        fsm.AddTransition(e_GameStates.INIT, e_GameStates.START, "auto");
        fsm.AddTransition(e_GameStates.START, e_GameStates.SEARCH, "search");
        fsm.AddTransition(e_GameStates.SEARCH, e_GameStates.BATTLE, "battle");
        fsm.AddTransition(e_GameStates.SEARCH, e_GameStates.PLAYERTURN, "PLAYERTURN");
        fsm.AddTransition(e_GameStates.SEARCH, e_GameStates.ENEMYTURN, "ENEMYTURN");
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.PLAYERTURN, "batttleplayer");
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.ENEMYTURN, "battletoenemy");
        fsm.AddTransition(e_GameStates.PLAYERTURN, e_GameStates.EXIT, "playertoexit");
        fsm.AddTransition(e_GameStates.ENEMYTURN, e_GameStates.EXIT, "enemytoexit");

        fsm.Feed("auto");
        Debug.Log(fsm.currentState.name.ToString());
    }
	
	// Update is called once per frame
	void Update ()
    {
       
	}
    //Function used to check which object goes first based on higher speed stat
    public List<Unit> sortBySpeed(List<Unit> List)
    {
        //Create a new list<Unit>
        List<Unit> sortedlist = new List<Unit>();
        //Set the new list to the passed in list ordered by highest speed stat first
        sortedlist = List.OrderByDescending(u => u.Speed).ToList<Unit>();
        //Return the new sorted list
        return sortedlist;
    }

    private void searchState()
    {
        BattleReadyParty = sortBySpeed(a.Participants);

        foreach (Unit u in BattleReadyParty)
        {
            Debug.Log(u.Name.ToString());
        }
    }

    public void Play()
    {//Disable party canvas
        Debug.Log(fsm.currentState.name.ToString());
        //Load Battle Scene Canvas

        //Then switch states
        fsm.Feed("search");
    }



}
