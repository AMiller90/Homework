using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.IO;
//using UnityEditor;
using System.Xml.Serialization;
//Namespace used to reference the FileIO class that will allow serialization and deserialization
using FileIO;
//Reference the library 
using Adgp125_Assessment_Library;
//Class used to handle the FileIOS Instance and load and save a game
public class fileManager : MonoBehaviour
{//Create an instance of the FileIOS class
    FileIOS File = new FileIOS();
    //Create an instance of the GameFlow class
    GameFlow game;

    public Canvas cCanvas;

    //Instance of the fileManager
    private static fileManager instance;
    //Holds the application m_sPath
    private string m_sPath;

    //Default Constructor
    fileManager()
    {

    }

    //On Start
    void Start()
    {//Get the proper component
        game = GetComponent<GameFlow>();
        //Disable the game saved cCanvas
        cCanvas.enabled = false;
        //Create a directory for the data to be stored
        Directory.CreateDirectory(Application.dataPath + "/GameData/State");
        //Create a directory for the data to be stored
        Directory.CreateDirectory(Application.dataPath + "/GameData/PlayerParty");
        //Create a directory for the data to be stored
        Directory.CreateDirectory(Application.dataPath + "/GameData/EnemyParty");
        //Create a directory for the data to be storedd
        Directory.CreateDirectory(Application.dataPath + "/GameData");
        //Create a directory for the data to be stored
        Directory.CreateDirectory(Application.dataPath + "/GameData/VictoryParty");
    }

    //Property to create or get and instance of fileManager
    public static fileManager Instance
    {
        get
        {//If instance is null
            if (instance == null)
            {//Create an instance
                instance = new fileManager();
            }
            //else just return the instance
            return instance;
        }
    }
    
    //When application quits 
    public void OnApplicationQuit()
    {//Destory the instance
        destroyInstance();
    }

    //Destroy the instance
    public void destroyInstance()
    {//Set instance to null
        instance = null;
    }

    //Initialize the fileManager
    public void initialize()
    {
        //Set Path to the current directory
        m_sPath = Application.dataPath;
    }

    //Save a game to an xml file
    public void SaveGame()
    {//Create a Party instance
        Party Players = new Party();
        //Create a Party instance
        Party Enemies = new Party();

        //Add playerParty to new Players Party units 
        Players.ulUnits = game.ulPlayerParty;
        //Add enemyParty to new Enemies units 
        Enemies.ulUnits = game.ulEnemyParty;

        //Open the file Path and store it in this variable
        string currentState = Application.dataPath + "/GameData/State/s.xml";
        //Serialize the data
        File.Serialize(currentState, game.fsm.sCurrentState.eName.ToString());

        //Open the file Path and store it in this variable
        string ppartyfile = Application.dataPath + "/GameData/PlayerParty/p.xml";
        //Serialize the data
        File.Serialize(ppartyfile, Players);

        //Open the file Path and store it in this variable
        string epartyfile = Application.dataPath + "/GameData/EnemyParty/e.xml";
        //Serialize the data
        File.Serialize(epartyfile, Enemies);

        //Open the file Path and store it in this variable
        string currentUnitIndex = Application.dataPath + "/GameData/index.xml";
        //Serialize the data
        File.Serialize(currentUnitIndex, game.iIndex);

        //Enable the game saved cCanvas
        cCanvas.enabled = true;
    }

    //Load a game from an xml file
    public void LoadGame()
    {//Create a Party instance
        Party EnemyE = new Party();
        //Create a Party instance
        Party PlayerP = new Party();

        //Open the file Path and store it in this variable
        string playerParty = Application.dataPath + "/GameData/PlayerParty/p.xml";

        //Open the file Path and store it in this variable
        string enemyParty = Application.dataPath + "/GameData/EnemyParty/e.xml";

        //Open the file Path and store it in this variable
        string currentstate = Application.dataPath + "/GameData/State/s.xml";

        //Open the file Path and store it in this variable
        string currentUnit = Application.dataPath + "/GameData/index.xml";

        //Deserialize the data as a Party object and store into this variable
        PlayerP = File.Deserialize<Party>(playerParty);
        //Deserialize the data as a Party object and store into this variable
        EnemyE = File.Deserialize<Party>(enemyParty);
        //Deserialize the data as a string object and store into this variable
        string state = File.Deserialize<string>(currentstate);
        //Deserialize the data as an int object and store into this variable
        game.iIndex = File.Deserialize<int>(currentUnit);

        //If the BattleReadyPartys count is greater than or equal to 1
        if (game.canvasScript.ulBattleReadyParty.Count >= 1)
        {//Remove all elements from the list
            game.canvasScript.ulBattleReadyParty.RemoveRange(0, game.canvasScript.ulBattleReadyParty.Count);
        }

        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.ulBattleReadyParty.Add(PlayerP.ulUnits[0]);
        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.ulBattleReadyParty.Add(PlayerP.ulUnits[1]);
        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.ulBattleReadyParty.Add(PlayerP.ulUnits[2]);

        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.ulBattleReadyParty.Add(EnemyE.ulUnits[0]);
        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.ulBattleReadyParty.Add(EnemyE.ulUnits[1]);
        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.ulBattleReadyParty.Add(EnemyE.ulUnits[2]);
        //Call Function to print out the stats of all objects in battle
        game.a.ulParticipants = game.sortBySpeed(game.canvasScript.ulBattleReadyParty);
        //Loop through the list
        for (int i = 0; i < game.a.ulParticipants.Count; i++)
        {//Set the BattleOrderTextBox text to a newline with the current units name
            game.ifBattleOrderText.text += "\n" + game.a.ulParticipants[i].sName;
        }
        //Foreach unit in the list
        foreach (Unit i in game.a.ulParticipants)
        {//If the current unit is of type Player
            if (i.sType == "Player")
            {//Add the unit to this party
                game.ulPlayerParty.Add(i);

            }
            //If the current unit is of type Enemy
            if (i.sType == "Enemy")
            {//Add the unit to this party
                game.ulEnemyParty.Add(i);
            }

        }
        //Set the player1Name text to the given index of the PlayerP list
        game.canvasScript.tPlayer1Name.text = PlayerP.ulUnits[0].sName;
        //Set the player2Name text to the given index of the PlayerP list
        game.canvasScript.tPlayer2Name.text = PlayerP.ulUnits[1].sName;
        //Set the player3Name text to the given index of the PlayerP list
        game.canvasScript.tPlayer3Name.text = PlayerP.ulUnits[2].sName;

        //Set the enemy1Name text to the given index of the EnemyE list
        game.canvasScript.tEnemy1Name.text = EnemyE.ulUnits[0].sName;
        //Set the enemy2Name text to the given index of the EnemyE list
        game.canvasScript.tEnemy2Name.text = EnemyE.ulUnits[1].sName;
        //Set the enemy3Name text to the given index of the EnemyE list
        game.canvasScript.tEnemy3Name.text = EnemyE.ulUnits[2].sName;

        //Call the function to load in the proper images
        game.canvasScript.LoadedGameImages(game.a.ulParticipants);

        //Call Function to print out the stats of all objects in battle
        game.manager.StatsOfObjects(game.a.ulParticipants);
        //Set the StatsField text variable to the data in the statsText variable
        game.ifStatsField.text = game.manager.statsText;


        //Load Battle Scene cCanvas
        game.cBattleCanvas.enabled = true;
        //Disable the gamecCanvas
        game.canvasScript.cGameCanvas.enabled = false;

        //Print out whose current turn it is
        game.ifBattleBox.text += "It is " + game.a.ulParticipants[game.iIndex].sName + "'s turn!\n";

        //Feed the state machine
        game.fsm.Feed(state);
        

    }

    //Function called when the ok button is clicked on the SavedFilePrompt cCanvas
    public void GameSaved()
    {//Disable the SavedFilePrompt cCanvas
        cCanvas.enabled = false;
    }
}