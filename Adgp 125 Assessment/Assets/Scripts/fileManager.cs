using UnityEngine;
using System;
using System.Collections;
using System.IO;
using UnityEditor;
using System.Xml.Serialization;
using FileIO;
using Adgp125_Assessment_Library;

public class fileManager : MonoBehaviour
{
    FileIOS File = new FileIOS();
    GameFlow game;

    //Instance of the fileManager
    private static fileManager instance;
    //Holds the application path
    private string path;

    fileManager()
    {

    }

    void Start()
    {
        game = GetComponent<GameFlow>();
    }

    public static fileManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new fileManager();
            }

            return instance;
        }
    }

    public void OnApplicationQuit()
    {
        destroyInstance();
    }

    public void destroyInstance()
    {
        instance = null;
    }

    public void initialize()
    {

        //print("file manager initialized");
        path = Application.dataPath;
    }

    //private bool checkDirectory(string directory)
    //{
    //    if (Directory.Exists(path + "/" + directory))
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //private void createDirectory(string directory)
    //{
    //    if (checkDirectory(directory) == false)
    //    {
    //        print("Creating a directory: " + directory);
    //        Directory.CreateDirectory(path + "/" + directory);
    //    }
    //    else
    //    {
    //        print("Error: You are trying to create the directory " + directory + " but it already exists!");
    //    }


    //}

    //private void deleteDirectory(string directory)
    //{
    //    if (checkDirectory(directory) == true)
    //    {
    //        print("Deleting directory: " + directory);
    //        Directory.Delete(path + "/" + directory, true);
    //    }
    //    else
    //    {
    //        print("Error: You are trying to delete the directory " + directory + " but it does not exist!");

    //    }
    //}

    //private void moveDirectory(string originalD, string newD)
    //{
    //    if (checkDirectory(originalD) == true && checkDirectory(newD) == false)
    //    {
    //        print("Moving directory: " + originalD);
    //        Directory.Move(path + "/" + originalD, path + "/" + newD);
    //    }
    //    else
    //    {
    //        print("Error: You are trying to move a directory but it either does not exist or a folder of the same name already exists");
    //    }
    //}

    //public string[] findSubDirectories(string directory)
    //{
    //    print("Checking directoy: " + directory + " for sub directories");
    //    string[] subdirectoryList = Directory.GetDirectories(path + "/" + directory);
    //    return subdirectoryList;
    //}

    //public string[] findFiles(string directory)
    //{
    //    print("Checking directoy: " + directory + " for files");
    //    string[] fileList = Directory.GetFiles(path + "/" + directory);
    //    return fileList;
    //}

    //public bool checkFile(string filePath)
    //{
    //    if (File.Exists(path + "/" + filePath))
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //public void createFile(string directory, string filename, string filetype, string fileData)
    //{
    //    print("Creating " + directory + "/" + filename + "/" + filetype);
    //    if (checkDirectory(directory) == true)
    //    {
    //        if (checkFile(directory + "/" + filename + "." + filetype) == false)
    //        {
    //            //Create the file
    //            File.WriteAllText(path + "/" + directory + "/" + filename + "." + filetype, fileData);
    //        }
    //        else
    //        {
    //            print("The file " + filename + " akready exists in " + path + "/" + directory);
    //        }
    //    }
    //    else
    //    {
    //        print("Unable to create the file as the directory " + directory + " does not exist");

    //    }


    //}

    //public string readFile(string directory, string filename, string filetype)
    //{
    //    print("Reading " + directory + "/" + filename + "." + filetype);

    //    if (checkDirectory(directory) == true)
    //    {
    //        if (checkFile(directory + "/" + filename + "." + filetype) == true)
    //        {
    //            //Read the file
    //            string fileContents = File.ReadAllText(path + "/" + directory + "/" + filename + "." + filetype);
    //            return fileContents;
    //        }
    //        else
    //        {
    //            print("The file " + filename + " does not exist in " + path + "/" + directory);
    //            return null;
    //        }
    //    }
    //    else
    //    {
    //        print("Unable to read the file as the directory " + directory + " does not exist");
    //        return null;
    //    }
    //}

    //public void deleteFile(string filePath)
    //{
    //    if (File.Exists(path + "/" + filePath))
    //    {
    //        File.Delete(path + "/" + filePath);
    //    }
    //    else
    //    {
    //        print("Unable to delete file as it does not exist");
    //    }
    //}

    //public void updateFile(string directory, string filename, string filetype, string fileData, string mode)
    //{
    //    print("Updating " + directory + "/" + filename + "." + filetype);

    //    if (checkDirectory(directory) == true)
    //    {
    //        if (checkFile(directory + "/" + filename + "." + filetype) == true)
    //        {
    //            if (mode == "replace")
    //            {
    //                File.WriteAllText(path + "/" + directory + "/" + filename + "." + filetype, fileData);
    //            }
    //            if (mode == "append")
    //            {
    //                File.AppendAllText(path + "/" + directory + "/" + filename + "." + filetype, fileData);
    //            }
    //        }
    //        else
    //        {
    //            print("The file " + filename + " does not exist in " + path + "/" + directory);
    //        }
    //    }
    //    else
    //    {
    //        print("Unable to create the file as the directory " + directory + " does not exist");
    //    }
    //}

    //public void processFile(string filepath)
    //{
    //    print("processing " + filepath);

    //    string fileContents = File.ReadAllText(filepath);

    //    print("Read file which contains: " + fileContents);

    //}

    //public void createXMLFile(string directory, string filename, string filetype, string fileData, string mode)
    //{
    //    if (checkDirectory(directory) == true)
    //    {
    //        if (mode == "plaintext")
    //        {
    //            File.WriteAllText(path + "/" + directory + "/" + filename + "." + filetype, fileData);

    //        }
    //    }
    //    else
    //    {
    //        print("Unable to create file as the directory " + directory + " does not exist");
    //    }
    //}

    public void SaveGame()
    {
        Party Players = new Party();
        Party Enemies = new Party();
        Players.units = game.playerParty;
        Enemies.units = game.enemyParty;
 

        string currentState = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/State", "Enter a filename here for state of the game", "xml");
        File.Serialize(currentState, game.fsm.currentState.name.ToString());

        string ppartyfile = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/PlayerParty", "Enter a filename here for your party", "xml");
        File.Serialize(ppartyfile, Players);

        string epartyfile = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData/EnemyParty", "Enter a filename here for the enemy party", "xml");
        File.Serialize(epartyfile, Enemies);

        string currentUnitIndex = EditorUtility.SaveFilePanel("Save File", Application.dataPath + "/GameData", "Enter a filename here for currentUnit taking turn", "xml");
        File.Serialize(currentUnitIndex, game.index);

    }

    public void LoadGame()
    {
        Party EnemyE = new Party();
        Party PlayerP = new Party();

        string playerParty = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData/PlayerParty", "xml");
        string enemyParty = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData/EnemyParty", "xml");
        string currentstate = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData/State", "xml");
        string currentUnit = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData", "xml");

        PlayerP = File.Deserialize<Party>(playerParty);
        EnemyE = File.Deserialize<Party>(enemyParty);
        string state = File.Deserialize<string>(currentstate);
        game.index = File.Deserialize<int>(currentUnit);

        game.canvasScript.BattleReadyParty.Add(PlayerP.units[0]);
        game.canvasScript.BattleReadyParty.Add(PlayerP.units[1]);
        game.canvasScript.BattleReadyParty.Add(PlayerP.units[2]);

        game.canvasScript.BattleReadyParty.Add(EnemyE.units[0]);
        game.canvasScript.BattleReadyParty.Add(EnemyE.units[1]);
        game.canvasScript.BattleReadyParty.Add(EnemyE.units[2]);

        game.a.Participants = game.sortBySpeed(game.canvasScript.BattleReadyParty);

        for (int i = 0; i < game.a.Participants.Count; i++)
        {
            game.BattleOrderText.text += "\n" + game.a.Participants[i].Name;
        }

        foreach (Unit i in game.a.Participants)
        {
            if (i.Type == "Player")
            {
                game.playerParty.Add(i);

            }
            if (i.Type == "Enemy")
            {
                game.enemyParty.Add(i);
            }

        }
        game.canvasScript.player1Name.text = PlayerP.units[0].Name;
        game.canvasScript.player2Name.text = PlayerP.units[1].Name;
        game.canvasScript.player3Name.text = PlayerP.units[2].Name;

        game.canvasScript.enemy1Name.text = EnemyE.units[0].Name;
        game.canvasScript.enemy2Name.text = EnemyE.units[1].Name;
        game.canvasScript.enemy3Name.text = EnemyE.units[2].Name;


        game.canvasScript.LoadedGameImages(game.a.Participants);

        game.manager.Statsofobjects(game.a.Participants);
        game.StatsField.text = game.manager.statsText;


        //Load Battle Scene Canvas
        game.BattleCanvas.enabled = true;
        game.canvasScript.gameCanvas.enabled = false;

        game.battleBox.text += "It is " + game.a.Participants[game.index].Name + "'s turn!\n";

        game.fsm.Feed(state);
        

    }
}