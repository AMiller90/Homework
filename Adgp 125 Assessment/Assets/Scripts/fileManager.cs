using UnityEngine;
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

    //Instance of the fileManager
    private static fileManager instance;
    //Holds the application path
    private string path;

    //Default Constructor
    fileManager()
    {

    }

    //On Start
    void Start()
    {//Get the proper component
        game = GetComponent<GameFlow>();
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

        //Set path to the current directory
        path = Application.dataPath;
    }

    //Save a game to an xml file
    public void SaveGame()
    {//Create a Party instance
        Party Players = new Party();
        //Create a Party instance
        Party Enemies = new Party();
        //Add playerParty to new Players Party units 
        Players.units = game.playerParty;
        //Add enemyParty to new Enemies units 
        Enemies.units = game.enemyParty;

        //Open save file panel and type in a name to save the file as or click to overwrite a file then click ok and store the selected currentState file into this string
        //string currentState = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/State", "Enter a filename here for state of the game", "xml");
        //Open the file path and store it in this variable
        string currentState = Application.dataPath + "/GameData/State/s.xml";
        //Serialize the data
        File.Serialize(currentState, game.fsm.currentState.name.ToString());

        //Open save file panel and store the selected playerparty file into this string
        //string ppartyfile = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/PlayerParty", "Enter a filename here for your party", "xml");
        //Open the file path and store it in this variable
        string ppartyfile = Application.dataPath + "/GameData/PlayerParty/p.xml";
        //Serialize the data
        File.Serialize(ppartyfile, Players);

        //Open save file panel and type in a name to save the file as or click to overwrite a file then click ok and store the selected enemyParty file into this string
        //string epartyfile = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/EnemyParty", "Enter a filename here for the enemy party", "xml");
        //Open the file path and store it in this variable
        string epartyfile = Application.dataPath + "/GameData/EnemyParty/e.xml";
        //Serialize the data
        File.Serialize(epartyfile, Enemies);

        //Open save file panel and type in a name to save the file as or click to overwrite a file then click ok and store the selected currentUnitIndex file into this string
        //string currentUnitIndex = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData", "Enter a filename here for currentUnit taking turn", "xml");
        //Open the file path and store it in this variable
        string currentUnitIndex = Application.dataPath + "/GameData/index.xml";
        //Serialize the data
        File.Serialize(currentUnitIndex, game.index);

    }

    //Load a game from an xml file
    public void LoadGame()
    {//Create a Party instance
        Party EnemyE = new Party();
        //Create a Party instance
        Party PlayerP = new Party();

        //Open Open file panel and store the selected file into this string
        //string playerParty = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData/PlayerParty", "xml");
        //Open the file path and store it in this variable
        string playerParty = Application.dataPath + "/GameData/PlayerParty/p.xml";
        //Open Open file panel and store the selected file into this string
        //string enemyParty = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData/EnemyParty", "xml");
        //Open the file path and store it in this variable
        string enemyParty = Application.dataPath + "/GameData/EnemyParty/e.xml";
        //Open Open file panel and store the selected file into this string
        //string currentstate = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData/State", "xml");
        //Open the file path and store it in this variable
        string currentstate = Application.dataPath + "/GameData/State/s.xml";
        //Open Open file panel and store the selected file into this string
        //string currentUnit = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData", "xml");
        //Open the file path and store it in this variable
        string currentUnit = Application.dataPath + "/GameData/index.xml";

        //Deserialize the data as a Party object and store into this variable
        PlayerP = File.Deserialize<Party>(playerParty);
        //Deserialize the data as a Party object and store into this variable
        EnemyE = File.Deserialize<Party>(enemyParty);
        //Deserialize the data as a string object and store into this variable
        string state = File.Deserialize<string>(currentstate);
        //Deserialize the data as an int object and store into this variable
        game.index = File.Deserialize<int>(currentUnit);

        //If the BattleReadyPartys count is greater than or equal to 1
        if (game.canvasScript.BattleReadyParty.Count >= 1)
        {//Remove all elements from the list
            game.canvasScript.BattleReadyParty.RemoveRange(0, game.canvasScript.BattleReadyParty.Count);
        }

        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.BattleReadyParty.Add(PlayerP.units[0]);
        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.BattleReadyParty.Add(PlayerP.units[1]);
        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.BattleReadyParty.Add(PlayerP.units[2]);

        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.BattleReadyParty.Add(EnemyE.units[0]);
        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.BattleReadyParty.Add(EnemyE.units[1]);
        //Add the specified unit to the BattlePartyReady list
        game.canvasScript.BattleReadyParty.Add(EnemyE.units[2]);
        //Call Function to print out the stats of all objects in battle
        game.a.Participants = game.sortBySpeed(game.canvasScript.BattleReadyParty);
        //Loop through the list
        for (int i = 0; i < game.a.Participants.Count; i++)
        {//Set the BattleOrderTextBox text to a newline with the current units name
            game.BattleOrderText.text += "\n" + game.a.Participants[i].Name;
        }
        //Foreach unit in the list
        foreach (Unit i in game.a.Participants)
        {//If the current unit is of type Player
            if (i.Type == "Player")
            {//Add the unit to this party
                game.playerParty.Add(i);

            }
            //If the current unit is of type Enemy
            if (i.Type == "Enemy")
            {//Add the unit to this party
                game.enemyParty.Add(i);
            }

        }
        //Set the player1Name text to the given index of the PlayerP list
        game.canvasScript.player1Name.text = PlayerP.units[0].Name;
        //Set the player2Name text to the given index of the PlayerP list
        game.canvasScript.player2Name.text = PlayerP.units[1].Name;
        //Set the player3Name text to the given index of the PlayerP list
        game.canvasScript.player3Name.text = PlayerP.units[2].Name;

        //Set the enemy1Name text to the given index of the EnemyE list
        game.canvasScript.enemy1Name.text = EnemyE.units[0].Name;
        //Set the enemy2Name text to the given index of the EnemyE list
        game.canvasScript.enemy2Name.text = EnemyE.units[1].Name;
        //Set the enemy3Name text to the given index of the EnemyE list
        game.canvasScript.enemy3Name.text = EnemyE.units[2].Name;

        //Call the function to load in the proper images
        game.canvasScript.LoadedGameImages(game.a.Participants);

        //Call Function to print out the stats of all objects in battle
        game.manager.Statsofobjects(game.a.Participants);
        //Set the StatsField text variable to the data in the statsText variable
        game.StatsField.text = game.manager.statsText;


        //Load Battle Scene Canvas
        game.BattleCanvas.enabled = true;
        //Disable the gameCanvas
        game.canvasScript.gameCanvas.enabled = false;

        //Print out whose current turn it is
        game.battleBox.text += "It is " + game.a.Participants[game.index].Name + "'s turn!\n";

        //Feed the state machine
        game.fsm.Feed(state);
        

    }

}