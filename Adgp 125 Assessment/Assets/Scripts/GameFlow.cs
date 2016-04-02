using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;
//Namespace used to reference finite state machine
using FiniteStateMachine;
//Namespace used to reference unit class, interfaces and ame manager singleton
using Adgp125_Assessment_Library;
//Namespace used to reference the FileIO class that will allow serialization and deserialization
using FileIO;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

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

//[Serializable()]
public class GameFlow : MonoBehaviour {

    public GameManager manager = GameManager.instance;

    FileIOS File = new FileIOS();

    public int index;
    int count;
    public Unit a = new Unit();
    public CanvasScript canvasScript;
    public Canvas canvas;
    public Canvas BattleCanvas;
    public InputField battleBox;
    public InputField BattleOrderText;
    public InputField StatsField;
    public Button Enemy1Button;
    public Button Enemy2Button;
    public Button Enemy3Button;
    public Canvas SaveMenu;
    public Button YesButton;
    public Button NoButton;
    public Button NewGameButton;
    public Button LoadGameButton;
    
    public FiniteStateMachine<e_GameStates> fsm = new FiniteStateMachine<e_GameStates>();

    public List<Unit> enemyParty;
    public List<Unit> playerParty;

	// Use this for initialization
	void Start ()
    {
        index = 0;
        enemyParty = new List<Unit>();
        playerParty = new List<Unit>();
        count = a.Participants.Count - 1;

        SaveMenu.enabled = false;
        Handler startHandler = startState;
        Handler searchHandler = searchState;
        Handler battleHandler = battleState;
        Handler playerturnHandler = playerState;
        Handler enemyturnHandler = enemyState;
        Handler exitHandler = exitState;

        fsm.State(e_GameStates.INIT, null);
        fsm.State(e_GameStates.START, startHandler);
        fsm.State(e_GameStates.SEARCH, searchHandler);
        fsm.State(e_GameStates.BATTLE, battleHandler);
        fsm.State(e_GameStates.PLAYERTURN, playerturnHandler);
        fsm.State(e_GameStates.ENEMYTURN, enemyturnHandler);
        fsm.State(e_GameStates.EXIT, exitHandler);

        fsm.AddTransition(e_GameStates.INIT, e_GameStates.START, "auto");
        fsm.AddTransition(e_GameStates.START, e_GameStates.SEARCH, "search");
        fsm.AddTransition(e_GameStates.START, e_GameStates.PLAYERTURN, "PLAYERTURN");
        fsm.AddTransition(e_GameStates.START, e_GameStates.EXIT, "exit");
        fsm.AddTransition(e_GameStates.SEARCH, e_GameStates.PLAYERTURN, "PLAYERTURN");
        fsm.AddTransition(e_GameStates.SEARCH, e_GameStates.ENEMYTURN, "ENEMYTURN");
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.PLAYERTURN, "battletoplayer");
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.ENEMYTURN, "battletoenemy");
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.START, "battletostart");
        fsm.AddTransition(e_GameStates.PLAYERTURN, e_GameStates.BATTLE, "battle");
        fsm.AddTransition(e_GameStates.ENEMYTURN, e_GameStates.BATTLE, "battle");
        fsm.AddTransition(e_GameStates.PLAYERTURN, e_GameStates.START, "playertostart");
        fsm.AddTransition(e_GameStates.ENEMYTURN, e_GameStates.START, "enemytostart");

        Enemy1Button.enabled = false;
        Enemy2Button.enabled = false;
        Enemy3Button.enabled = false;

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
        index = 0; 

        if (a.Participants.Count >= 1)
        {
            a.Participants.RemoveRange(0, enemyParty.Count);
        }
        if (enemyParty.Count >= 1)
        {
            enemyParty.RemoveRange(0, enemyParty.Count);
        }
        if (playerParty.Count >= 1)
        {
            playerParty.RemoveRange(0, playerParty.Count);
        }

        battleBox.text = "";
        BattleOrderText.text = "Battle Order:";
        manager.statsText = "";

        Debug.Log(fsm.currentState.name.ToString());

    }

    private void searchState()
    {
        Debug.Log(fsm.currentState.name.ToString());

        a.Participants = sortBySpeed(canvasScript.BattleReadyParty);

        for (int i = 0; i < a.Participants.Count; i++)
        {
            BattleOrderText.text += "\n" + a.Participants[i].Name;
        }

        foreach (Unit i in a.Participants)
        {
            if (i.Type == "Player")
            {
                playerParty.Add(i);

            }
            if (i.Type == "Enemy")
            {
                enemyParty.Add(i);
            }

        }

        canvasScript.player1Name.text = playerParty[0].Name;
        canvasScript.player2Name.text = playerParty[1].Name;
        canvasScript.player3Name.text = playerParty[2].Name;

        canvasScript.enemy1Name.text = enemyParty[0].Name;
        canvasScript.enemy2Name.text = enemyParty[1].Name;
        canvasScript.enemy3Name.text = enemyParty[2].Name;

        canvasScript.LoadedGameImages(a.Participants);


        manager.Statsofobjects(a.Participants);
        StatsField.text = manager.statsText;

        //Load Battle Scene Canvas
        BattleCanvas.enabled = true;

        FirstAttack(a.Participants);
    }

    private void battleState()
    {

        manager.statsText = "";
        manager.Statsofobjects(a.Participants);
        StatsField.text = manager.statsText;
       
    }

    private void playerState()
    {
        Debug.Log(fsm.currentState.name.ToString());

        Enemy1Button.enabled = true;
        Enemy2Button.enabled = true;
        Enemy3Button.enabled = true;


    }

    private void enemyState()
    {
        Debug.Log(fsm.currentState.name.ToString());

        Enemy1Button.enabled = false;
        Enemy2Button.enabled = false;
        Enemy3Button.enabled = false;

        Debug.Log(fsm.currentState.name.ToString());

        if (a.Participants[index].Type == "Enemy" && a.Participants[index].Life == true)
        {
            Unit Attacker = a.Participants[index];
            Unit Defender = Attacker.EnemyRandomTarget(playerParty);


            Attacker.Attack(Defender);

            battleBox.text += Attacker.stuffText;
            if (index == count)
            {
                index = 0;
            }
            else
            {
                index += 1;
            }
        }

        if (manager.Checkforvictory(playerParty, enemyParty) == true)
        {
            battleBox.text = manager.winText;

            manager.statsText = "";
            manager.Statsofobjects(a.Participants);
            StatsField.text = manager.statsText;

            Debug.Log(fsm.currentState.name.ToString());

            fsm.Feed("enemytostart");

        }
        processTurn(index);

    }

    public void Play()
    {//Disable party canvas
        canvas.enabled = false;
        //Then switch states
        fsm.Feed("search");
    }

    public void ExitGame()
    {
        fsm.Feed("exit");
        Debug.Log(fsm.currentState.name.ToString());
    }

    private void processTurn(int number)
    {
        if (manager.Checkforvictory(playerParty, enemyParty) == true)
        {
            //number = 0;
            //index = 0;
            fsm.Feed("battletostart");

        }
            if (number == a.Participants.Count)
        {
            number = 0;
            index = 0;
        }

        if (fsm.currentState.name != e_GameStates.BATTLE as Enum)
        {
            fsm.Feed("battle");
        }

        if (a.Participants[number].Type == "Player" && a.Participants[number].Life == true)
        {

            battleBox.text += "It is " + a.Participants[number].Name + "'s turn!\n";

            fsm.Feed("battletoplayer");

        }
        else if (a.Participants[number].Type == "Enemy" && a.Participants[number].Life == true)
        {

            battleBox.text += "It is " + a.Participants[number].Name + "'s turn!\n";

            fsm.Feed("battletoenemy");

        }

        else
        {
            index += 1;
            processTurn(index);
        }

    }

    public void AttackEnemy1()
    {
        if (enemyParty[0].Life == true)
        {
            a.Participants[index].Attack(enemyParty[0]);
            battleBox.text = a.Participants[index].stuffText;

            if (index == count)
            {
                index = 0;
            }
            else
            {
                index += 1;
            }
        }

        if (manager.Checkforvictory(playerParty, enemyParty) == true)
        {
            battleBox.text = manager.winText;


            Party party = new Party();
            party.units = playerParty;

            foreach (Unit u in party.units)
            {//Reset health
                u.Health = u.MaxHp;
                //Bring life to true 
                u.Life = true;
            }


            manager.statsText = "";
            manager.Statsofobjects(a.Participants);
            StatsField.text = manager.statsText;

            Enemy1Button.enabled = false;
            Enemy2Button.enabled = false;
            Enemy3Button.enabled = false;
            Debug.Log(fsm.currentState.name.ToString());

            string ppartyfile = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/VictoryParty", "Enter a filename here for your party", "xml");
            File.Serialize(ppartyfile, party);

            canvasScript.gameCanvas.enabled = true;
            canvasScript.battleCanvas.enabled = false;

            Debug.Log(fsm.currentState.name.ToString());
        }

        processTurn(index);
    }

    public void AttackEnemy2()
    {
        if (enemyParty[1].Life == true)
        {
            a.Participants[index].Attack(enemyParty[1]);
            battleBox.text = a.Participants[index].stuffText;

            if (index == count)
            {
                index = 0;
            }
            else
            {
                index += 1;
            }
        }
        if (manager.Checkforvictory(playerParty, enemyParty) == true)
        {
            Party party = new Party();
            party.units = playerParty;

            foreach (Unit u in party.units)
            {//Reset health
                u.Health = u.MaxHp;
                //Bring life to true 
                u.Life = true;
            }


            manager.statsText = "";
            manager.Statsofobjects(a.Participants);
            StatsField.text = manager.statsText;

            Enemy1Button.enabled = false;
            Enemy2Button.enabled = false;
            Enemy3Button.enabled = false;
            Debug.Log(fsm.currentState.name.ToString());

            string ppartyfile = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/VictoryParty", "Enter a filename here for your party", "xml");
            File.Serialize(ppartyfile, party);

            canvasScript.gameCanvas.enabled = true;
            canvasScript.battleCanvas.enabled = false;

            Debug.Log(fsm.currentState.name.ToString());

        }

        processTurn(index);
    }

    public void AttackEnemy3()
    {
        if (enemyParty[2].Life == true)
        {
            a.Participants[index].Attack(enemyParty[2]);
            battleBox.text = a.Participants[index].stuffText;

            if (index == count)
            {
                index = 0;
            }
            else
            {
                index += 1;
            }
        }
        if (manager.Checkforvictory(playerParty, enemyParty) == true)
        {
            Party party = new Party();
            party.units = playerParty;

            foreach (Unit u in party.units)
            {//Reset health
                u.Health = u.MaxHp;
                //Bring life to true 
                u.Life = true;
            }


            manager.statsText = "";
            manager.Statsofobjects(a.Participants);
            StatsField.text = manager.statsText;

            Enemy1Button.enabled = false;
            Enemy2Button.enabled = false;
            Enemy3Button.enabled = false;
            Debug.Log(fsm.currentState.name.ToString());

            string ppartyfile = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/VictoryParty", "Enter a filename here for your party", "xml");
            File.Serialize(ppartyfile, party);

            canvasScript.gameCanvas.enabled = true;
            canvasScript.battleCanvas.enabled = false;

            Debug.Log(fsm.currentState.name.ToString());

        }

        processTurn(index);
    }

    public void FirstAttack(List<Unit> uList)
    {
        battleBox.text += "It is " + uList[index].Name + "'s turn!\n";

        if (uList[index].Type == "Enemy" && uList[index].Life == true)
        {
            fsm.Feed("ENEMYTURN");

        }

        if (uList[index].Type == "Player" && uList[index].Life == true)
        {
            fsm.Feed("PLAYERTURN");
        }

        StatsField.text = manager.statsText;
    }

    private void exitState()
    {
        NewGameButton.enabled = false;
        LoadGameButton.enabled = false;

        Application.Quit();
    }

}
