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

    Unit referUnit = new Unit();
   
    FiniteStateMachine<e_GameStates> fsm = new FiniteStateMachine<e_GameStates>();
    private List<Unit> BattleReadyParty = new List<Unit>();


	// Use this for initialization
	void Start ()
    {
        Handler startHandler = startState;
        Handler searchHandler = searchState;
        //Handler battleHandler;
        //Handler playerturnHandler;
        //Handler enemyturnHandler;
        //Handler exitHandler;
       
        fsm.State(e_GameStates.INIT, null);
        fsm.State(e_GameStates.START, startHandler);
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

    private void startState()
    {
        List<Unit> AllObjects = new List<Unit>();
        List<Unit> players = new List<Unit>();
        List<Unit> enemies = new List<Unit>();

        Unit Cloud = new Unit("Cloud", 150, 12, 12, 6, 0, "Player");
        Unit Barret = new Unit("Barret", 220, 15, 13, 5, 0, "Player");
        Unit Tifa = new Unit("Tifa", 215, 11, 11, 7, 0, "Player");
        Unit Aerith = new Unit("Aerith", 170, 10, 11, 5, 0, "Player");
        Unit RedXIII = new Unit("Red XIII", 220, 10, 12, 10, 0, "Player");
        Unit Cait = new Unit("Cait Sith", 220, 10, 11, 5, 0, "Player");
        Unit Cid = new Unit("Cid", 220, 12, 12, 6, 0, "Player");
        Unit Yuffie = new Unit("Yuffie", 150, 10, 10, 8, 0, "Player");
        Unit Vincent = new Unit("Vincent", 170, 9, 10, 5, 0, "Player");


        Unit TwoFaced = new Unit("2Faced", 100, 20, 15, 5, 25, "Enemy");
        Unit AncientDragon = new Unit("Ancient Dragon", 200, 30, 12, 4, 100, "Enemy");
        Unit Ghost = new Unit("Ghost", 80, 20, 15, 5, 30, "Enemy");
        Unit IceGolem = new Unit("Ice Golem", 150, 25, 15, 5, 35, "Enemy");
        Unit Zuu = new Unit("Zuu", 120, 15, 10, 5, 20, "Enemy");
        Unit ToxicFrog = new Unit("Toxic Frog", 180, 22, 12, 5, 30, "Enemy");
        Unit DeathClaw = new Unit("Death Claw", 140, 25, 18, 7, 50, "Enemy");
        Unit MasterTonberry = new Unit("Master Tonberry", 170, 20, 15, 5, 50, "Enemy");
        Unit Behemoth = new Unit("Behemoth", 200, 35, 14, 4, 100, "Enemy");

        AllObjects.Add(Cloud);
        AllObjects.Add(Barret);
        AllObjects.Add(Tifa);
        AllObjects.Add(Aerith);
        AllObjects.Add(RedXIII);
        AllObjects.Add(Cait);
        AllObjects.Add(Cid);
        AllObjects.Add(Yuffie);
        AllObjects.Add(Vincent);

        AllObjects.Add(TwoFaced);
        AllObjects.Add(AncientDragon);
        AllObjects.Add(Ghost);
        AllObjects.Add(IceGolem);
        AllObjects.Add(Zuu);
        AllObjects.Add(ToxicFrog);
        AllObjects.Add(DeathClaw);
        AllObjects.Add(MasterTonberry);
        AllObjects.Add(Behemoth);

        foreach (Unit i in AllObjects)
        {//Check if current unit is a player type
            if (i.Type == "Player")
            {//If true then add to player party
                players.Add(i);
            }
            //Check if current unit is an enemy
            if (i.Type == "Enemy")
            {//If true then add to enemy party
                enemies.Add(i);
            }
        }

        RandomizeAllParties(players, enemies);

    }

    private void searchState()
    {
     
        BattleReadyParty = sortBySpeed(referUnit.Participants);

        foreach(Unit u in BattleReadyParty)
        {
            Debug.Log(u.Name.ToString());
        }
    }

    private void RandomizeAllParties(List<Unit> p, List<Unit> e)
    {
        //Create random class instance
        //Random r = new Random();
        System.Random r = new System.Random();
        //call Next() 3 times giving random selection for party members
        int p1 = r.Next(0, p.Count - 1);
        int p2 = r.Next(0, p.Count - 1);
        int p3 = r.Next(0, p.Count - 1);

        referUnit.Participants.Add(p[p1]);
        referUnit.Participants.Add(p[p2]);
        referUnit.Participants.Add(p[p3]);

        System.Random a = new System.Random();

        int e1 = a.Next(0, e.Count - 1);
        int e2 = a.Next(0, e.Count - 1);
        int e3 = a.Next(0, e.Count - 1);

        referUnit.Participants.Add(e[e1]);
        referUnit.Participants.Add(e[e2]);
        referUnit.Participants.Add(e[e3]);

        fsm.Feed("search");
    }
}
