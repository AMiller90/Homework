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
    bool bIsDone = false;
    //public int variable to represent the index of a given list
    public int iIndex;
    //public int variable to compare the index too
    int iCount;
    //Create an instance of a Unit object
    public Unit a = new Unit();
    //public CanvasScript object
    public CanvasScript canvasScript;
    //public Canvas object
    public Canvas cCanvas;
    //public Canvas object
    public Canvas cBattleCanvas;
    //Public Canvas object
    public Canvas cEnemyWon;
    //public InputField object
    public InputField ifBattleBox;
    //public InputField object
    public InputField ifBattleOrderText;
    //public InputField object
    public InputField ifStatsField;
    //public Button object
    public Button bEnemy1Button;
    //public Button object
    public Button bEnemy2Button;
    //public Button object
    public Button bEnemy3Button;
    //public Canvas object
    public Canvas cSaveMenu;
    //public Button object
    public Button bYesButton;
    //public Button object
    public Button bNoButton;
    //public Button object
    public Button bNewGameButton;
    //public Button object
    public Button bLoadGameButton;
    //public FiniteStateMachine object
    public FiniteStateMachine<e_GameStates> fsm = new FiniteStateMachine<e_GameStates>();
    //public List<Unit> object
    public List<Unit> ulEnemyParty;
    //public List<Unit> object
    public List<Unit> ulPlayerParty;

	// Use this for initialization
	void Start ()
    {//Set index to 0
        iIndex = 0;
        //Create the new list
        ulEnemyParty = new List<Unit>();
        //Create the new list
        ulPlayerParty = new List<Unit>();
        //Set count to the Participants List Count - 1
        iCount = a.ulParticipants.Count - 1;

        //Disable the EnemyWon Canvas
        cEnemyWon.enabled = false;
        //Disable save menu
        cSaveMenu.enabled = false;
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
        bEnemy1Button.enabled = false;
        //Disable the Enemy2Button
        bEnemy2Button.enabled = false;
        //Disable the Enemy3Button
        bEnemy3Button.enabled = false;

        //Give input to the machine
        fsm.Feed("auto");
        //Print out the current State
        Debug.Log(fsm.sCurrentState.eName.ToString());
    }

    //Function used to check which object goes first based on higher speed stat
    public List<Unit> sortBySpeed(List<Unit> List)
    {
        //Create a new list<Unit>
        List<Unit> sortedlist = new List<Unit>();
        //Set the new list to the passed in list ordered by highest speed stat first
        sortedlist = List.OrderByDescending(u => u.iSpeed).ToList<Unit>();
        //Return the new sorted list
        return sortedlist;
    }

    //Function called in the start State
    private void startState()
    {//Set index to 0
        iIndex = 0;
        //If the a.Participants list Count is greater than or equal to 1
        if (a.ulParticipants.Count >= 1)
        {//Remove all elements in the List
            a.ulParticipants.RemoveRange(0, a.ulParticipants.Count);
        }
        //If the enemyParty list Count is greater than or equal to 1
        if (ulEnemyParty.Count >= 1)
        {//Remove all elements in the List
            ulEnemyParty.RemoveRange(0, ulEnemyParty.Count);
        }
        //If the PlayerParty list Count is greater than or equal to 1
        if (ulPlayerParty.Count >= 1)
        {//Remove all elements in the List
            ulPlayerParty.RemoveRange(0, ulPlayerParty.Count);
        }
        //Set battle text to
        ifBattleBox.text = "";
        //Set BattleOrderText to 
        ifBattleOrderText.text = "Battle Order:";
        //Set statsText to
        manager.statsText = "";
        //Print out the current State
        Debug.Log(fsm.sCurrentState.eName.ToString());

    }

    //Function called in the search State
    private void searchState()
    {//Print out the current State
        Debug.Log(fsm.sCurrentState.eName.ToString());
        //Battle party sorted by speed to produce attack order 
        a.ulParticipants = sortBySpeed(canvasScript.ulBattleReadyParty);
        //Loop through the list
        for (int i = 0; i < a.ulParticipants.Count; i++)
        {//Set the BattleOrderTextBox text to a newline with the current units name
            ifBattleOrderText.text += "\n" + a.ulParticipants[i].sName;
        }
        //Foreach unit in the list
        foreach (Unit i in a.ulParticipants)
        {//If the current unit is of type Player
            if (i.sType == "Player")
            {//Add the unit to this party
                ulPlayerParty.Add(i);

            }
            //If the current unit is of type Enemy
            if (i.sType == "Enemy")
            {//Add the unit to this party
                ulEnemyParty.Add(i);
            }

        }

        //Set the player1Name text to the given index of the playerParty list
        canvasScript.tPlayer1Name.text = ulPlayerParty[0].sName;
        //Set the player2Name text to the given index of the playerParty list
        canvasScript.tPlayer2Name.text = ulPlayerParty[1].sName;
        //Set the player3Name text to the given index of the playerParty list
        canvasScript.tPlayer3Name.text = ulPlayerParty[2].sName;

        //Set the enemy1Name text to the given index of the enemyParty list
        canvasScript.tEnemy1Name.text = ulEnemyParty[0].sName;
        //Set the enemy2Name text to the given index of the enemyParty list
        canvasScript.tEnemy2Name.text = ulEnemyParty[1].sName;
        //Set the enemy3Name text to the given index of the enemyParty list
        canvasScript.tEnemy3Name.text = ulEnemyParty[2].sName;
        //Set images to loaded in party
        canvasScript.LoadedGameImages(a.ulParticipants);

        //Call Function to print out the stats of all objects in battle
        manager.StatsOfObjects(a.ulParticipants);
        //Set the StatsField text variable to the data in the statsText variable
        ifStatsField.text = manager.statsText;

        //Load Battle Scene Canvas
        cBattleCanvas.enabled = true;

        //Call the FirstAttack function to get the battle started
        FirstAttack(a.ulParticipants);
    }

    //Function called in the battle State
    private void battleState()
    {
        //Set the stats text to ""
        manager.statsText = "";
        //Call the StatsOfObjects function to print stats of objects that are in the battle
        manager.StatsOfObjects(a.ulParticipants);
        //StatsField text is set to the data stored in the statsText variable
        ifStatsField.text = manager.statsText;
       
    }

    //Function called in the player State
    private void playerState()
    {//Print out the current State
        Debug.Log(fsm.sCurrentState.eName.ToString());

        //Enable the Enemy1Button to true
        bEnemy1Button.enabled = true;
        //Enable the Enemy2Button to true
        bEnemy2Button.enabled = true;
        //Enable the Enemy3Button to true
        bEnemy3Button.enabled = true;


    }

    //Function called in the enemy State
    private void enemyState()
    {//Set variable to false
        bIsDone = false;
        //Print out current State
        Debug.Log(fsm.sCurrentState.eName.ToString());

        //Enable the Enemy1Button to false
        bEnemy1Button.enabled = false;
        //Enable the Enemy2Button to false
        bEnemy2Button.enabled = false;
        //Enable the Enemy3Button to false
        bEnemy3Button.enabled = false;

        //Print out current State
        Debug.Log(fsm.sCurrentState.eName.ToString());
        //If the current enemy in the enemyParty is alive
        if (a.ulParticipants[iIndex].sType == "Enemy" && a.ulParticipants[iIndex].bLife == true)
        {//Create a unit and set it to the current unit
            Unit Attacker = a.ulParticipants[iIndex];
            //Create a unit and set it to the target unit
            Unit Defender = Attacker.EnemyRandomTarget(ulPlayerParty);

            //The current unit will attack
            Attacker.Attack(Defender);
            //Set the battleBox text to stufftext data
            ifBattleBox.text += Attacker.sStuffText;
            //If the index is equal to the count variable
            if (iIndex == iCount)
            {//Set index to 0
                iIndex = 0;
            }
            //If the index is not equal to the count variable
            else
            {//Increment the index by 1
                iIndex += 1;
            }
        }
        //If the CheckForVictory function returns true 
        if (manager.CheckForVictory(ulPlayerParty, ulEnemyParty) == true)
        {//Set the battleBox text to the winText
            ifBattleBox.text = manager.winText;
            //Set the statsText to ""
            manager.statsText = "";
            //Call this function to print out the Stats of the objects in battle
            manager.StatsOfObjects(a.ulParticipants);
            //Set the StatsField text to the statsText
            ifStatsField.text = manager.statsText;
            //Enable the gameCanvas
            canvasScript.cGameCanvas.enabled = true;
            //Disable the battleCanvas
            canvasScript.cBattleCanvas.enabled = false;
            //Enable the EnemyWon canvas
            cEnemyWon.enabled = true;
            //Set isDone to true
            bIsDone = true;
            //Feed the machine
            fsm.Feed("enemytostart");

        }
        //If isDone is equal to false
        if (bIsDone == false)
        {//Call the process turn function 
            processTurn(iIndex);
        }
    }

    //Function called when play button is clicked
    public void Play()
    {//Disable party canvas
        cCanvas.enabled = false;
        //Then switch states
        fsm.Feed("search");
    }

    //Function called when the Exit game button is clicked
    public void ExitGame()
    {//Feed the machine
        fsm.Feed("exit");
        //Print out the current State
        Debug.Log(fsm.sCurrentState.eName.ToString());
    }

    //Function called to determine the next units turn
    private void processTurn(int number)
    {//If number is equal to the count of the participants list
        if (number == a.ulParticipants.Count)
        {//Set number to 0
            number = 0;
            //Set index to 0
            iIndex = 0;
        }
        //if(The current states name is not the same as the BATTLE State
        if (fsm.sCurrentState.eName != e_GameStates.BATTLE as Enum)
        {//Feed the machine
            fsm.Feed("battle");
        }
        //If the current unit is of type Player and is alive
        if (a.ulParticipants[number].sType == "Player" && a.ulParticipants[number].bLife == true)
        {
            //Add It is The current units names turn! and a newline to the battleBox text
            ifBattleBox.text += "It is " + a.ulParticipants[number].sName + "'s turn!\n";
            //Feed the machine
            fsm.Feed("battletoplayer");

        }
        //else if the current unit is of type Enemy and is alive
        else if (a.ulParticipants[number].sType == "Enemy" && a.ulParticipants[number].bLife == true)
        {
            //Add It is The current units names turn! and a newline to the battleBox text
            ifBattleBox.text += "It is " + a.ulParticipants[number].sName + "'s turn!\n";
            //Feed the machine
            fsm.Feed("battletoenemy");

        }
        //If the current unit is not of Type player or enemy or the unit is not alive
        else
        {//Increment the index by 1
            iIndex += 1;
            //Call processTurn function again with the index passed in so the next unit can have its turn
            processTurn(iIndex);
        }

    }

    //Function activated when the Enemy1Attack button is clicked - Gives user option of attacking specific unit
    public void AttackEnemy1()
    {//Set isDone to false
        bIsDone = false;
        //If the current enemy in the enemyParty is alive
        if (ulEnemyParty[0].bLife == true)
        {//The current unit will attack that enemy
            a.ulParticipants[iIndex].Attack(ulEnemyParty[0]);
            //Set the battleBox text to stufftext data
            ifBattleBox.text = a.ulParticipants[iIndex].sStuffText;
            //If the index is equal to the count variable
            if (iIndex == iCount)
            {//Set index to 0
                iIndex = 0;
            }
            //If the index is not equal to the count variable
            else
            {//Increment the index by 1
                iIndex += 1;
            }
        }

        //If the CheckForVictory function returns true 
        if (manager.CheckForVictory(ulPlayerParty, ulEnemyParty) == true)
        {//Set the battleBox text to winText data
            ifBattleBox.text = manager.winText;
            //Set the statsText to ""
            manager.statsText = "";
            //Call this function to print out the Stats of the objects in battle
            manager.StatsOfObjects(a.ulParticipants);
            //Set the StatsField text to the statsText
            ifStatsField.text = manager.statsText;

            //Disable the Enemy1Button
            bEnemy1Button.enabled = false;
            //Disable the Enemy2Button
            bEnemy2Button.enabled = false;
            //Disable the Enemy3Button
            bEnemy3Button.enabled = false;
            //Enable the save menu
            cSaveMenu.enabled = true;
            //Set isDone to true
            bIsDone = true;
           
        }
        //If isDone is equal to false
        if (bIsDone == false)
        {//Call the process turn function 
            processTurn(iIndex);
        }
        
    }

    //Function activated when the Enemy2Attack button is clicked - Gives user option of attacking specific unit
    public void AttackEnemy2()
    {//Set isDone to false
        bIsDone = false;
        //If the current enemy in the enemyParty is alive
        if (ulEnemyParty[1].bLife == true)
        {//The current unit will attack that enemy
            a.ulParticipants[iIndex].Attack(ulEnemyParty[1]);
            //Set the battleBox text to stufftext data
            ifBattleBox.text = a.ulParticipants[iIndex].sStuffText;
            //If the index is equal to the count variable
            if (iIndex == iCount)
            {//Set index to 0
                iIndex = 0;
            }
            //If the index is not equal to the count variable
            else
            {//Increment the index by 1
                iIndex += 1;
            }
        }
        //If the CheckForVictory function returns true
        if (manager.CheckForVictory(ulPlayerParty, ulEnemyParty) == true)
        {
            
               //Set isDone to true
               bIsDone = true;
            //Set the battleBox text to winText data
            ifBattleBox.text = manager.winText;
            //Set the statsText to ""
            manager.statsText = "";
            //Call this function to print out the Stats of the objects in battle
            manager.StatsOfObjects(a.ulParticipants);
            //Set the StatsField text to the statsText
            ifStatsField.text = manager.statsText;

            //Disable the Enemy1Button
            bEnemy1Button.enabled = false;
            //Disable the Enemy2Button
            bEnemy2Button.enabled = false;
            //Disable the Enemy3Button
            bEnemy3Button.enabled = false;
            //Enable the save menu
            cSaveMenu.enabled = true;
            

        }
        //If isDone is equal to false
        if (bIsDone == false)
        {//Call the process turn function 
            processTurn(iIndex);
        }
    }

    //Function activated when the Enemy3Attack button is clicked - Gives user option of attacking specific unit
    public void AttackEnemy3()
    {//Set isDone to false
        bIsDone = false;
        //If the current enemy in the enemyParty is alive
        if (ulEnemyParty[2].bLife == true)
        {//The current unit will attack that enemy
            a.ulParticipants[iIndex].Attack(ulEnemyParty[2]);
            //Set the battleBox text to stufftext data
            ifBattleBox.text = a.ulParticipants[iIndex].sStuffText;
            //If the index is equal to the count variable
            if (iIndex == iCount)
            {//Set index to 0
                iIndex = 0;
            }
            //If the index is not equal to the count variable
            else
            {//Increment the index by 1
                iIndex += 1;
            }
        }
        //If the CheckForVictory function returns true
        if (manager.CheckForVictory(ulPlayerParty, ulEnemyParty) == true)
        {//Set the battleBox text to winText data
            ifBattleBox.text = manager.winText;
            //Set the statsText to ""
            manager.statsText = "";
            //Call this function to print out the Stats of the objects in battle
            manager.StatsOfObjects(a.ulParticipants);
            //Set the StatsField text to the statsText
            ifStatsField.text = manager.statsText;

            //Disable the Enemy1Button
            bEnemy1Button.enabled = false;
            //Disable the Enemy2Button
            bEnemy2Button.enabled = false;
            //Disable the Enemy3Button
            bEnemy3Button.enabled = false;
            //Enable the save menu
            cSaveMenu.enabled = true;
            //Set isDone to true
            bIsDone = true;

        }
        //If isDone is equal to false
        if (bIsDone == false)
        {//Call the process turn function 
            processTurn(iIndex);
        }
    }

    //Function called to start the battle
    public void FirstAttack(List<Unit> uList)
    {//Add the battleBox to "It is then the current units name's turn! then a newline
        ifBattleBox.text += "It is " + uList[iIndex].sName + "'s turn!\n";
        //if the current units type is an enemy and it is alive
        if (uList[iIndex].sType == "Enemy" && uList[iIndex].bLife == true)
        {//Feed the machine
            fsm.Feed("ENEMYTURN");

        }
        //if the current units type is a player and it is alive
        if (uList[iIndex].sType == "Player" && uList[iIndex].bLife == true)
        {//Feed the machine
            fsm.Feed("PLAYERTURN");
        }
        //Set the StatsField text to the statsText variable data
        ifStatsField.text = manager.statsText;
    }

    //Function called in the exit State
    private void exitState()
    {//Disable the New Game Button
        bNewGameButton.enabled = false;
        //Disable the Load Game Button
        bLoadGameButton.enabled = false;
        //Call the instance of the fileManger and call OnApplication function
        fileManager.Instance.OnApplicationQuit();
        //Quit the application
        Application.Quit();
    }

    //Function called when the Yes button is clicked
    public void ClickYes()
    {//Disable the save menu
        cSaveMenu.enabled = false;
        //Create a new instance of a party object
        Party party = new Party();
        //Set the list in the party object to the player Party list
        party.ulUnits = ulPlayerParty;
        //Loop through the list
        foreach (Unit u in party.ulUnits)
        {//Reset health
            u.iHealth = u.iMaxHp;
            //Bring life to true 
            u.bLife = true;
        }

        //string ppartyfile = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/VictoryParty", "Enter a filename here for your party", "xml");
        //Store the file path in this variable
        string ppartyfile = Application.dataPath + "/GameData/VictoryParty/WinningParty.xml";
        //Serialize the data
        File.Serialize(ppartyfile, party);
        //Enable the gameCanvas
        canvasScript.cGameCanvas.enabled = true;
        //Disable the battleCanvas
        canvasScript.cBattleCanvas.enabled = false;
        //Enable the SavedFilePrompt Canvas
        canvasScript.cSavedFilePrompt.enabled = true;
        //Feed the machine
        fsm.Feed("playertostart");
    }

    //Function called when the No button is clicked
    public void ClickNo()
    {//Disable the save menu
        cSaveMenu.enabled = false;
        //Enable the gameCanvas
        canvasScript.cGameCanvas.enabled = true;
        //Disable the battleCanvas
        canvasScript.cBattleCanvas.enabled = false;
        //Feed the machine
        fsm.Feed("playertostart");
    }

    //Function called when ok button is clicked on the EnemyWon Canvas
    public void eEnemyWon()
    {//Disable the Enemy Won canvas
        cEnemyWon.enabled = false;

    }

    //Function called when the main menu button is clicked
    public void MainMenu()
    {//Disable the battle canvas
        cBattleCanvas.enabled = false;
        //Enable the gameCanvas
        canvasScript.cGameCanvas.enabled = true;
        //Feed machine
        fsm.Feed("playertostart");
    }
    
}
