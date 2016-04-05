using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;
//Namespace used to reference finite state machine
using FiniteStateMachine;
//Namespace used to reference unit class, interfaces and Game manager singleton
using Adgp125_Assessment_Library;
//Namespace used to reference the FileIO class that will allow serialization and deserialization
using FileIO;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

//public enum of states
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
    //Public instance of the GameManager object
    public GameManager manager = GameManager.instance;
    //Instance of the FileIOS class
    FileIOS File = new FileIOS();
    //bool variable
    bool isDone = false;
    //public int variable to represent the index of a given list
    public int index;
    //public int variable to compare the index too
    int count;
    //Create an instance of a Unit object
    public Unit a = new Unit();
    //public CanvasScript object
    public CanvasScript canvasScript;
    //public Canvas object
    public Canvas canvas;
    //public Canvas object
    public Canvas BattleCanvas;
    //public InputField object
    public InputField battleBox;
    //public InputField object
    public InputField BattleOrderText;
    //public InputField object
    public InputField StatsField;
    //public Button object
    public Button Enemy1Button;
    //public Button object
    public Button Enemy2Button;
    //public Button object
    public Button Enemy3Button;
    //public Canvas object
    public Canvas SaveMenu;
    //public Button object
    public Button YesButton;
    //public Button object
    public Button NoButton;
    //public Button object
    public Button NewGameButton;
    //public Button object
    public Button LoadGameButton;
    //public FiniteStateMachine object
    public FiniteStateMachine<e_GameStates> fsm = new FiniteStateMachine<e_GameStates>();
    //public List<Unit> object
    public List<Unit> enemyParty;
    //public List<Unit> object
    public List<Unit> playerParty;

	// Use this for initialization
	void Start ()
    {//Set index to 0
        index = 0;
        //Create the new list
        enemyParty = new List<Unit>();
        //Create the new list
        playerParty = new List<Unit>();
        //Set count to the Participants List Count - 1
        count = a.Participants.Count - 1;

        //Disable save menu
        SaveMenu.enabled = false;
        //Create Delegate object and set function to it
        Handler startHandler = startState;
        //Create Delegate object and set function to it
        Handler searchHandler = searchState;
        //Create Delegate object and set function to it
        Handler battleHandler = battleState;
        //Create Delegate object and set function to it
        Handler playerturnHandler = playerState;
        //Create Delegate object and set function to it
        Handler enemyturnHandler = enemyState;
        //Create Delegate object and set function to it
        Handler exitHandler = exitState;

        //Create a State and give it a State and a delegate 
        fsm.State(e_GameStates.INIT, null);
        //Create a State and give it a State and a delegate 
        fsm.State(e_GameStates.START, startHandler);
        //Create a State and give it a State and a delegate 
        fsm.State(e_GameStates.SEARCH, searchHandler);
        //Create a State and give it a State and a delegate 
        fsm.State(e_GameStates.BATTLE, battleHandler);
        //Create a State and give it a State and a delegate 
        fsm.State(e_GameStates.PLAYERTURN, playerturnHandler);
        //Create a State and give it a State and a delegate 
        fsm.State(e_GameStates.ENEMYTURN, enemyturnHandler);
        //Create a State and give it a State and a delegate 
        fsm.State(e_GameStates.EXIT, exitHandler);

        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.INIT, e_GameStates.START, "auto");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.START, e_GameStates.SEARCH, "search");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.START, e_GameStates.PLAYERTURN, "PLAYERTURN");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.START, e_GameStates.EXIT, "exit");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.SEARCH, e_GameStates.PLAYERTURN, "PLAYERTURN");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.SEARCH, e_GameStates.ENEMYTURN, "ENEMYTURN");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.PLAYERTURN, "battletoplayer");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.ENEMYTURN, "battletoenemy");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.BATTLE, e_GameStates.START, "battletostart");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.PLAYERTURN, e_GameStates.BATTLE, "battle");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.ENEMYTURN, e_GameStates.BATTLE, "battle");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.PLAYERTURN, e_GameStates.START, "playertostart");
        //Add a transition to Machine
        fsm.AddTransition(e_GameStates.ENEMYTURN, e_GameStates.START, "enemytostart");

        //Disable the Enemy1Button
        Enemy1Button.enabled = false;
        //Disable the Enemy2Button
        Enemy2Button.enabled = false;
        //Disable the Enemy3Button
        Enemy3Button.enabled = false;

        //Give input to the machine
        fsm.Feed("auto");
        //Print out the current State
        Debug.Log(fsm.currentState.name.ToString());
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

    //Function called in the start State
    private void startState()
    {//Set index to 0
        index = 0;
        //If the a.Participants list Count is greater than or equal to 1
        if (a.Participants.Count >= 1)
        {//Remove all elements in the List
            a.Participants.RemoveRange(0, a.Participants.Count);
        }
        //If the enemyParty list Count is greater than or equal to 1
        if (enemyParty.Count >= 1)
        {//Remove all elements in the List
            enemyParty.RemoveRange(0, enemyParty.Count);
        }
        //If the PlayerParty list Count is greater than or equal to 1
        if (playerParty.Count >= 1)
        {//Remove all elements in the List
            playerParty.RemoveRange(0, playerParty.Count);
        }
        //Set battle text to
        battleBox.text = "";
        //Set BattleOrderText to 
        BattleOrderText.text = "Battle Order:";
        //Set statsText to
        manager.statsText = "";
        //Print out the current State
        Debug.Log(fsm.currentState.name.ToString());

    }

    //Function called in the search State
    private void searchState()
    {//Print out the current State
        Debug.Log(fsm.currentState.name.ToString());
        //Battle party sorted by speed to produce attack order 
        a.Participants = sortBySpeed(canvasScript.BattleReadyParty);
        //Loop through the list
        for (int i = 0; i < a.Participants.Count; i++)
        {//Set the BattleOrderTextBox text to a newline with the current units name
            BattleOrderText.text += "\n" + a.Participants[i].Name;
        }
        //Foreach unit in the list
        foreach (Unit i in a.Participants)
        {//If the current unit is of type Player
            if (i.Type == "Player")
            {//Add the unit to this party
                playerParty.Add(i);

            }
            //If the current unit is of type Enemy
            if (i.Type == "Enemy")
            {//Add the unit to this party
                enemyParty.Add(i);
            }

        }
        //Set the player1Name text to the given index of the playerParty list
        canvasScript.player1Name.text = playerParty[0].Name;
        //Set the player2Name text to the given index of the playerParty list
        canvasScript.player2Name.text = playerParty[1].Name;
        //Set the player3Name text to the given index of the playerParty list
        canvasScript.player3Name.text = playerParty[2].Name;

        //Set the enemy1Name text to the given index of the enemyParty list
        canvasScript.enemy1Name.text = enemyParty[0].Name;
        //Set the enemy2Name text to the given index of the enemyParty list
        canvasScript.enemy2Name.text = enemyParty[1].Name;
        //Set the enemy3Name text to the given index of the enemyParty list
        canvasScript.enemy3Name.text = enemyParty[2].Name;
        //Set images to loaded in party
        canvasScript.LoadedGameImages(a.Participants);

        //Call Function to print out the stats of all objects in battle
        manager.Statsofobjects(a.Participants);
        //Set the StatsField text variable to the data in the statsText variable
        StatsField.text = manager.statsText;

        //Load Battle Scene Canvas
        BattleCanvas.enabled = true;

        //Call the FirstAttack function to get the battle started
        FirstAttack(a.Participants);
    }

    //Function called in the battle State
    private void battleState()
    {
        //Set the stats text to ""
        manager.statsText = "";
        //Call the Statsofobjects function to print stats of objects that are in the battle
        manager.Statsofobjects(a.Participants);
        //StatsField text is set to the data stored in the statsText variable
        StatsField.text = manager.statsText;
       
    }

    //Function called in the player State
    private void playerState()
    {//Print out the current State
        Debug.Log(fsm.currentState.name.ToString());

        //Enable the Enemy1Button to true
        Enemy1Button.enabled = true;
        //Enable the Enemy2Button to true
        Enemy2Button.enabled = true;
        //Enable the Enemy3Button to true
        Enemy3Button.enabled = true;


    }

    //Function called in the enemy State
    private void enemyState()
    {//Set variable to false
        isDone = false;
        //Print out current State
        Debug.Log(fsm.currentState.name.ToString());

        //Enable the Enemy1Button to false
        Enemy1Button.enabled = false;
        //Enable the Enemy2Button to false
        Enemy2Button.enabled = false;
        //Enable the Enemy3Button to false
        Enemy3Button.enabled = false;

        //Print out current State
        Debug.Log(fsm.currentState.name.ToString());
        //If the current enemy in the enemyParty is alive
        if (a.Participants[index].Type == "Enemy" && a.Participants[index].Life == true)
        {//Create a unit and set it to the current unit
            Unit Attacker = a.Participants[index];
            //Create a unit and set it to the target unit
            Unit Defender = Attacker.EnemyRandomTarget(playerParty);

            //The current unit will attack
            Attacker.Attack(Defender);
            //Set the battleBox text to stufftext data
            battleBox.text += Attacker.stuffText;
            //If the index is equal to the count variable
            if (index == count)
            {//Set index to 0
                index = 0;
            }
            //If the index is not equal to the count variable
            else
            {//Increment the index by 1
                index += 1;
            }
        }
        //If the Checkforvictory function returns true 
        if (manager.Checkforvictory(playerParty, enemyParty) == true)
        {//Set the battleBox text to the winText
            battleBox.text = manager.winText;
            //Set the statsText to ""
            manager.statsText = "";
            //Call this function to print out the Stats of the objects in battle
            manager.Statsofobjects(a.Participants);
            //Set the StatsField text to the statsText
            StatsField.text = manager.statsText;
            //Enable the gameCanvas
            canvasScript.gameCanvas.enabled = true;
            //Disable the battleCanvas
            canvasScript.battleCanvas.enabled = false;
            //Set isDone to true
            isDone = true;
            //Feed the machine
            fsm.Feed("enemytostart");

        }
        //If isDone is equal to false
        if (isDone == false)
        {//Call the process turn function 
            processTurn(index);
        }
    }

    //Function called when play button is clicked
    public void Play()
    {//Disable party canvas
        canvas.enabled = false;
        //Then switch states
        fsm.Feed("search");
    }

    //Function called when the Exit game button is clicked
    public void ExitGame()
    {//Feed the machine
        fsm.Feed("exit");
        //Print out the current State
        Debug.Log(fsm.currentState.name.ToString());
    }

    //Function called to determine the next units turn
    private void processTurn(int number)
    {//If number is equal to the count of the participants list
        if (number == a.Participants.Count)
        {//Set number to 0
            number = 0;
            //Set index to 0
            index = 0;
        }
        //if(The current states name is not the same as the BATTLE State
        if (fsm.currentState.name != e_GameStates.BATTLE as Enum)
        {//Feed the machine
            fsm.Feed("battle");
        }
        //If the current unit is of type Player and is alive
        if (a.Participants[number].Type == "Player" && a.Participants[number].Life == true)
        {
            //Add It is The current units names turn! and a newline to the battleBox text
            battleBox.text += "It is " + a.Participants[number].Name + "'s turn!\n";
            //Feed the machine
            fsm.Feed("battletoplayer");

        }
        //else if the current unit is of type Enemy and is alive
        else if (a.Participants[number].Type == "Enemy" && a.Participants[number].Life == true)
        {
            //Add It is The current units names turn! and a newline to the battleBox text
            battleBox.text += "It is " + a.Participants[number].Name + "'s turn!\n";
            //Feed the machine
            fsm.Feed("battletoenemy");

        }
        //If the current unit is not of Type player or enemy or the unit is not alive
        else
        {//Increment the index by 1
            index += 1;
            //Call processTurn function again with the index passed in so the next unit can have its turn
            processTurn(index);
        }

    }

    //Function activated when the Enemy1Attack button is clicked - Gives user option of attacking specific unit
    public void AttackEnemy1()
    {//Set isDone to false
        isDone = false;
        //If the current enemy in the enemyParty is alive
        if (enemyParty[0].Life == true)
        {//The current unit will attack that enemy
            a.Participants[index].Attack(enemyParty[0]);
            //Set the battleBox text to stufftext data
            battleBox.text = a.Participants[index].stuffText;
            //If the index is equal to the count variable
            if (index == count)
            {//Set index to 0
                index = 0;
            }
            //If the index is not equal to the count variable
            else
            {//Increment the index by 1
                index += 1;
            }
        }
        //If the Checkforvictory function returns true 
        if (manager.Checkforvictory(playerParty, enemyParty) == true)
        {//Set the battleBox text to winText data
            battleBox.text = manager.winText;
            //Set the statsText to ""
            manager.statsText = "";
            //Call this function to print out the Stats of the objects in battle
            manager.Statsofobjects(a.Participants);
            //Set the StatsField text to the statsText
            StatsField.text = manager.statsText;

            //Disable the Enemy1Button
            Enemy1Button.enabled = false;
            //Disable the Enemy2Button
            Enemy2Button.enabled = false;
            //Disable the Enemy3Button
            Enemy3Button.enabled = false;
            //Enable the save menu
            SaveMenu.enabled = true;
           //Set isDone to true
            isDone = true;
           
        }
        //If isDone is equal to false
        if (isDone == false)
        {//Call the process turn function 
            processTurn(index);
        }
        
    }

    //Function activated when the Enemy2Attack button is clicked - Gives user option of attacking specific unit
    public void AttackEnemy2()
    {//Set isDone to false
        isDone = false;
        //If the current enemy in the enemyParty is alive
        if (enemyParty[1].Life == true)
        {//The current unit will attack that enemy
            a.Participants[index].Attack(enemyParty[1]);
            //Set the battleBox text to stufftext data
            battleBox.text = a.Participants[index].stuffText;
            //If the index is equal to the count variable
            if (index == count)
            {//Set index to 0
                index = 0;
            }
            //If the index is not equal to the count variable
            else
            {//Increment the index by 1
                index += 1;
            }
        }
        //If the Checkforvictory function returns true
        if (manager.Checkforvictory(playerParty, enemyParty) == true)
        {//Set the battleBox text to winText data
            battleBox.text = manager.winText;
            //Set the statsText to ""
            manager.statsText = "";
            //Call this function to print out the Stats of the objects in battle
            manager.Statsofobjects(a.Participants);
            //Set the StatsField text to the statsText
            StatsField.text = manager.statsText;

            //Disable the Enemy1Button
            Enemy1Button.enabled = false;
            //Disable the Enemy2Button
            Enemy2Button.enabled = false;
            //Disable the Enemy3Button
            Enemy3Button.enabled = false;
            //Enable the save menu
            SaveMenu.enabled = true;
            //Set isDone to true
            isDone = true;

        }
        //If isDone is equal to false
        if (isDone == false)
        {//Call the process turn function 
            processTurn(index);
        }
    }

    //Function activated when the Enemy3Attack button is clicked - Gives user option of attacking specific unit
    public void AttackEnemy3()
    {//Set isDone to false
        isDone = false;
        //If the current enemy in the enemyParty is alive
        if (enemyParty[2].Life == true)
        {//The current unit will attack that enemy
            a.Participants[index].Attack(enemyParty[2]);
            //Set the battleBox text to stufftext data
            battleBox.text = a.Participants[index].stuffText;
            //If the index is equal to the count variable
            if (index == count)
            {//Set index to 0
                index = 0;
            }
            //If the index is not equal to the count variable
            else
            {//Increment the index by 1
                index += 1;
            }
        }
        //If the Checkforvictory function returns true
        if (manager.Checkforvictory(playerParty, enemyParty) == true)
        {//Set the battleBox text to winText data
            battleBox.text = manager.winText;
            //Set the statsText to ""
            manager.statsText = "";
            //Call this function to print out the Stats of the objects in battle
            manager.Statsofobjects(a.Participants);
            //Set the StatsField text to the statsText
            StatsField.text = manager.statsText;

            //Disable the Enemy1Button
            Enemy1Button.enabled = false;
            //Disable the Enemy2Button
            Enemy2Button.enabled = false;
            //Disable the Enemy3Button
            Enemy3Button.enabled = false;
            //Enable the save menu
            SaveMenu.enabled = true;
            //Set isDone to true
            isDone = true;

        }
        //If isDone is equal to false
        if (isDone == false)
        {//Call the process turn function 
            processTurn(index);
        }
    }

    //Function called to start the battle
    public void FirstAttack(List<Unit> uList)
    {//Add the battleBox to "It is then the current units name's turn! then a newline
        battleBox.text += "It is " + uList[index].Name + "'s turn!\n";
        //if the current units type is an enemy and it is alive
        if (uList[index].Type == "Enemy" && uList[index].Life == true)
        {//Feed the machine
            fsm.Feed("ENEMYTURN");

        }
        //if the current units type is a player and it is alive
        if (uList[index].Type == "Player" && uList[index].Life == true)
        {//Feed the machine
            fsm.Feed("PLAYERTURN");
        }
        //Set the StatsField text to the statsText variable data
        StatsField.text = manager.statsText;
    }

    //Function called in the exit State
    private void exitState()
    {//Disable the New Game Button
        NewGameButton.enabled = false;
        //Disable the Load Game Button
        LoadGameButton.enabled = false;
        //Call the instance of the fileManger and call OnApplication function
        fileManager.Instance.OnApplicationQuit();
        //Quit the application
        Application.Quit();
    }

    //Function called when the Yes button is clicked
    public void ClickYes()
    {//Disable the save menu
        SaveMenu.enabled = false;
        //Create a new instance of a party object
        Party party = new Party();
        //Set the list in the party object to the player Party list
        party.units = playerParty;
        //Loop through the list
        foreach (Unit u in party.units)
        {//Reset health
            u.Health = u.MaxHp;
            //Bring life to true 
            u.Life = true;
        }

        //string ppartyfile = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/VictoryParty", "Enter a filename here for your party", "xml");
        //Store the file path in this variable
        string ppartyfile = Application.dataPath + "/GameData/VictoryParty/WinningParty.xml";
        //Serialize the data
        File.Serialize(ppartyfile, party);
        //Enable the gameCanvas
        canvasScript.gameCanvas.enabled = true;
        //Disable the battleCanvas
        canvasScript.battleCanvas.enabled = false;
        //Feed the machine
        fsm.Feed("playertostart");
    }

    public void ClickNo()
    {//Disable the save menu
        SaveMenu.enabled = false;
        //Enable the gameCanvas
        canvasScript.gameCanvas.enabled = true;
        //Disable the battleCanvas
        canvasScript.battleCanvas.enabled = false;
        //Feed the machine
        fsm.Feed("playertostart");
    }
}
