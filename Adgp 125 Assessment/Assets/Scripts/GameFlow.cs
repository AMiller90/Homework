using UnityEngine;
using UnityEngine.UI;
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

[Serializable]
public class GameFlow : MonoBehaviour {

    Files _Save;
    GameManager manager = GameManager.instance;
    int index;
    int count;
    Unit a = new Unit();
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

    
    public FiniteStateMachine<e_GameStates> fsm = new FiniteStateMachine<e_GameStates>();

    private List<Unit> enemyParty;
    private List<Unit> playerParty;

	// Use this for initialization
	void Start ()
    {
        index = 0;
        count = a.Participants.Count - 1;
        enemyParty = new List<Unit>();
        playerParty = new List<Unit>();
        SaveMenu.enabled = false;
        Handler searchHandler = searchState;
        Handler battleHandler = battleState;
        Handler playerturnHandler = playerState;
        Handler enemyturnHandler = enemyState;
        Handler exitHandler = exitState;

        fsm.State(e_GameStates.INIT, null);
        fsm.State(e_GameStates.START, null);
        fsm.State(e_GameStates.SEARCH, searchHandler);
        fsm.State(e_GameStates.BATTLE, battleHandler);
        fsm.State(e_GameStates.PLAYERTURN, playerturnHandler);
        fsm.State(e_GameStates.ENEMYTURN, enemyturnHandler);
        fsm.State(e_GameStates.EXIT, exitHandler);

        fsm.AddTransition(e_GameStates.INIT, e_GameStates.START, "auto");
        fsm.AddTransition(e_GameStates.START, e_GameStates.SEARCH, "search");
        fsm.AddTransition(e_GameStates.SEARCH, e_GameStates.PLAYERTURN, "PLAYERTURN");
        fsm.AddTransition(e_GameStates.SEARCH, e_GameStates.ENEMYTURN, "ENEMYTURN");
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.PLAYERTURN, "battletoplayer");
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.ENEMYTURN, "battletoenemy");
        fsm.AddTransition(e_GameStates.PLAYERTURN, e_GameStates.BATTLE, "battle");
        fsm.AddTransition(e_GameStates.ENEMYTURN, e_GameStates.BATTLE, "battle");
        fsm.AddTransition(e_GameStates.PLAYERTURN, e_GameStates.EXIT, "playertoexit");
        fsm.AddTransition(e_GameStates.ENEMYTURN, e_GameStates.EXIT, "enemytoexit");

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

        canvasScript.setImages(a.Participants);

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
        //if (a.Participants[index].Type == "Enemy" && a.Participants[index].Life == true)
        //{
        //    fsm.Feed("battletoenemy");

        //}

        //if (a.Participants[index].Type == "Player" && a.Participants[index].Life == true)
        //{
        //    fsm.Feed("battletoplayer");
        //}
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

            fsm.Feed("enemytoexit");

        }
        processTurn(index);

    }

    public void Play()
    {//Disable party canvas
        canvas.enabled = false;
        //Then switch states
        fsm.Feed("search");
    }

    private void processTurn(int number)
    {
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

            //Party party = new Party();

            // party.units = playerParty;

            //foreach (Unit u in party.units)
            //{//Reset health
            //    u.Health = u.MaxHp;
            //    //Bring life to true 
            //    u.Life = true;
            //}
            foreach (Unit u in playerParty)
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

            //DialogResult = MessageBox.Show("Would you like to save your current party?\n", "Save Party", MessageBoxButtons.YesNo);

            //if (DialogResult == DialogResult.Yes)
            //{
            //    _Save.Serialize("Party", party);
            //    Application.Exit();

            //}

            SaveMenu.enabled = true;
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
            battleBox.text = manager.winText;

            //Party party = new Party();

            // party.units = playerParty;

            //foreach (Unit u in party.units)
            //{//Reset health
            //    u.Health = u.MaxHp;
            //    //Bring life to true 
            //    u.Life = true;
            //}
            foreach (Unit u in playerParty)
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

            //DialogResult = MessageBox.Show("Would you like to save your current party?\n", "Save Party", MessageBoxButtons.YesNo);

            //if (DialogResult == DialogResult.Yes)
            //{
            //    _Save.Serialize("Party", party);
            //    Application.Exit();

            //}

            SaveMenu.enabled = true;

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
            battleBox.text = manager.winText;

            //Party party = new Party();

            // party.units = playerParty;

            //foreach (Unit u in party.units)
            //{//Reset health
            //    u.Health = u.MaxHp;
            //    //Bring life to true 
            //    u.Life = true;
            //}
            foreach (Unit u in playerParty)
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

            //DialogResult = MessageBox.Show("Would you like to save your current party?\n", "Save Party", MessageBoxButtons.YesNo);

            //if (DialogResult == DialogResult.Yes)
            //{
            //    _Save.Serialize("Party", party);
            //    Application.Exit();

            //}


            SaveMenu.enabled = true;

        }

        processTurn(index);
    }

    private void FirstAttack(List<Unit> uList)
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
        Debug.Log(fsm.currentState.name.ToString());
        Application.Quit();
    }

    public void ClickYes()
    {
        //_Save.Serialize();
        //_Save.SerializeToSave("GameData", fsm.currentState.ToString());
        SaveMenu.enabled = false;
    }
    public void ClickNo()
    {
        fsm.Feed("playertoexit");
    }
}
