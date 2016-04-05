using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;
using System.Collections;
//Namespace used to reference unit class, interfaces and Game manager singleton
using Adgp125_Assessment_Library;
using System.Collections.Generic;
//Namespace used to reference the FileIO class that will allow serialization and deserialization
using FileIO;
public class CanvasScript : MonoBehaviour {
    //Create a refernece to the ImageScript
    ImagesScript imageList;
    //Create public List<Unit>
    public List<Unit> BattleReadyParty;
    //Public Canvas object
    public Canvas gameCanvas;
    //Public Canvas object
    public Canvas generatePartyCanvas;
    //Public Canvas object
    public Canvas battleCanvas;

    //public Button object
    public Button PlayButton;
    //public InputField object
    public InputField p1Name;
    //public InputField object
    public InputField p1Health;
    //public InputField object
    public InputField p1Strength;
    //public InputField object
    public InputField p1Defense;
    //public InputField object
    public InputField p1Speed;
    //public InputField object
    public InputField p1Level;
    //public RawImage object
    public RawImage player1;

    //public InputField object
    public InputField p2Name;
    //public InputField object
    public InputField p2Health;
    //public InputField object
    public InputField p2Strength;
    //public InputField object
    public InputField p2Defense;
    //public InputField object
    public InputField p2Speed;
    //public InputField object
    public InputField p2Level;
    //public RawImage object
    public RawImage player2;

    //public InputField object
    public InputField p3Name;
    //public InputField object
    public InputField p3Health;
    //public InputField object
    public InputField p3Strength;
    //public InputField object
    public InputField p3Defense;
    //public InputField object
    public InputField p3Speed;
    //public InputField object
    public InputField p3Level;
    //public RawImage object
    public RawImage player3;

    //public Text object
    public Text player1Name;
    //public Text object
    public Text player2Name;
    //public Text object
    public Text player3Name;
    //public RawImage object
    public RawImage p1;
    //public RawImage object
    public RawImage p2;
    //public RawImage object
    public RawImage p3;

    //public Text object
    public Text enemy1Name;
    //public Text object
    public Text enemy2Name;
    //public Text object
    public Text enemy3Name;
    //public RawImage object
    public RawImage e1;
    //public RawImage object
    public RawImage e2;
    //public RawImage object
    public RawImage e3;

    // Use this for initialization
    void Start ()
    {//Set List to new list
        BattleReadyParty = new List<Unit>();
        //Get proper component
        imageList = GetComponent<ImagesScript>();
        //Enable gameCanvas
        gameCanvas.enabled = true;
        //Disable generatePartyCanvas
        generatePartyCanvas.enabled = false;
        //Disable battleCanvas
        battleCanvas.enabled = false;
        //Disable the PlayButton
        PlayButton.enabled = false;
    }

    //Function called when newGame Button is clicked
    public void newGame()
    {//Disable play button
        PlayButton.enabled = false;

        //Set player textures to null
        player1.texture = null;
        player2.texture = null;
        player3.texture = null;

        //Set p1 name text to 
        p1Name.text = "";
        //Set player1name text to 
        player1Name.text = "";
        //Set p1 Health text to 
        p1Health.text = "";
        //Set p1 Strength text to 
        p1Strength.text = "";
        //Set p1 Defense text to 
        p1Defense.text = "";
        //Set p1 Speed text to 
        p1Speed.text = "";
        //Set p1 Level text to 
        p1Level.text = "";

        //Set p2 name text to 
        p2Name.text = "";
        //Set player2name text to 
        player2Name.text = "";
        //Set p2 Health text to 
        p2Health.text = "";
        //Set p2 Strength text to 
        p2Strength.text = "";
        //Set p2 Defense text to 
        p2Defense.text = "";
        //Set p2 Speed text to 
        p2Speed.text = "";
        //Set p2 Level text to 
        p2Level.text = "";

        //Set p3 name text to 
        p3Name.text = "";
        //Set player3name text to 
        player3Name.text = "";
        //Set p3 Health text to 
        p3Health.text = "";
        //Set p3 Strength text to 
        p3Strength.text = "";
        //Set p3 Defense text to 
        p3Defense.text = "";
        //Set p3 Speed text to 
        p3Speed.text = "";
        //Set p3 Level text to 
        p3Level.text = "";

        //Disable gameCanvas
        gameCanvas.enabled = false;
        //Enable generatePartyCanvas
        generatePartyCanvas.enabled = true;
    }

    //Function used to generate a random party
    public void GenerateParty()
    {//Enable play button to true
        PlayButton.enabled = true;
        //Create a new list 
        List<Unit> AllObjects = new List<Unit>();
        //Create a new list
        List<Unit> players = new List<Unit>();
        //Create a new list
        List<Unit> enemies = new List<Unit>();

        //Create objects
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

        //Add objects to the list
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

        //Loop through the list
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
        //Call function to randomize the objects
        RandomizeAllParties(players, enemies);

    }

    //Function that randomizes both the player and enemy parties
    private void RandomizeAllParties(List<Unit> p, List<Unit> e)
    {//If count of the BattleReadyParty is greater than or equal to 1
        if (BattleReadyParty.Count >= 1)
        {//Remove all elements of the current BattleReadyParty list
            BattleReadyParty.RemoveRange(0, BattleReadyParty.Count);
        }

        //Create random class instance
        System.Random r = new System.Random();
        //call Next() 3 times giving random selection for party members
        int p1 = r.Next(0, p.Count - 1);
        int p2 = r.Next(0, p.Count - 1);
        int p3 = r.Next(0, p.Count - 1);

        //while p1 is equal to p2
        while (p1 == p2)
        {//randomize p2
            p2 = r.Next(0, p.Count - 1);
        }
        //while p2 == p3
        while (p2 == p3)
        {//randomize p3
            p3 = r.Next(0, p.Count - 1);
        }
        //while p3 == p1
        while (p3 == p1)
        {//randomize p1
            p1 = r.Next(0, p.Count - 1);
            //while p1 == p2
            while (p1 == p2)
            {//randomize p1
                p1 = r.Next(0, p.Count - 1);
            }
        }
        //Set proper text variables to proper values
        p1Name.text = p[p1].Name;
        player1Name.text = p[p1].Name;
        p1Health.text = p[p1].Health.ToString();
        p1Strength.text = p[p1].Strength.ToString();
        p1Defense.text = p[p1].Defense.ToString();
        p1Speed.text = p[p1].Speed.ToString();
        p1Level.text = p[p1].Level.ToString();
        //Add unit to list
        BattleReadyParty.Add(p[p1]);

        //Set proper text variables to proper values
        p2Name.text = p[p2].Name;
        player2Name.text = p[p2].Name;
        p2Health.text = p[p2].Health.ToString();
        p2Strength.text = p[p2].Strength.ToString();
        p2Defense.text = p[p2].Defense.ToString();
        p2Speed.text = p[p2].Speed.ToString();
        p2Level.text = p[p2].Level.ToString();
        //Add unit to list
        BattleReadyParty.Add(p[p2]);

        //Set proper text variables to proper values
        p3Name.text = p[p3].Name;
        player3Name.text = p[p3].Name;
        p3Health.text = p[p3].Health.ToString();
        p3Strength.text = p[p3].Strength.ToString();
        p3Defense.text = p[p3].Defense.ToString();
        p3Speed.text = p[p3].Speed.ToString();
        p3Level.text = p[p3].Level.ToString();
        //Add unit to list
        BattleReadyParty.Add(p[p3]);
        //Call function to setImages to the units in the list
        setImages(BattleReadyParty);

        //Create random class instance
        System.Random a = new System.Random();

        //call Next() 3 times giving random selection for enemy party members
        int e1 = a.Next(0, e.Count - 1);
        int e2 = a.Next(0, e.Count - 1);
        int e3 = a.Next(0, e.Count - 1);

        //while e1 is equal to e2
        while (e1 == e2)
        {//Randomize e2
            e2 = a.Next(0, e.Count - 1);
        }
        //while e2 is equal to e1
        while (e2 == e3)
        {//Randomize e3
            e3 = a.Next(0, e.Count - 1);
        }
        //while e3 is equal to e1
        while (e3 == e1)
        {//Randomize e1
            e1 = a.Next(0, e.Count - 1);
            //while e1 is equal to e2
            while (e1 == e2)
            {//Randomize e1
                e1 = a.Next(0, e.Count - 1);
            }
        }
        //Add unit to list
        BattleReadyParty.Add(e[e1]);
        //Add unit to list
        BattleReadyParty.Add(e[e2]);
        //Add unit to list
        BattleReadyParty.Add(e[e3]);

    }

    //Function that loads the unit party
    public void loadParty()
    {//Create instance of FileIOS object
        FileIOS File = new FileIOS();
        //Create an instance of a new Party object
        Party Team = new Party();

        //If count of the BattleReadyParty is greater than or equal to 1
        if (BattleReadyParty.Count >= 1)
        {//Remove all elements of the current BattleReadyParty list
            BattleReadyParty.RemoveRange(0, BattleReadyParty.Count);
        }

        //string victoryParty = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData/VictoryParty", "xml");
        //Store file path into the string variable
        string victoryParty = Application.dataPath + "/GameData/VictoryParty/WinningParty.xml";
        //Deserialize the the object in the path and store into party variable
        Team = File.Deserialize<Party>(victoryParty);

        //Set proper text variables to proper values
        p1Name.text = Team.units[0].Name;
        player1Name.text = Team.units[0].Name;
        p1Health.text = Team.units[0].Health.ToString();
        p1Strength.text = Team.units[0].Strength.ToString();
        p1Defense.text = Team.units[0].Defense.ToString();
        p1Speed.text = Team.units[0].Speed.ToString();
        p1Level.text = Team.units[0].Level.ToString();

        //Add unit to list
        BattleReadyParty.Add(Team.units[0]);

        //Set proper text variables to proper values
        p2Name.text = Team.units[1].Name;
        player2Name.text = Team.units[1].Name;
        p2Health.text = Team.units[1].Health.ToString();
        p2Strength.text = Team.units[1].Strength.ToString();
        p2Defense.text = Team.units[1].Defense.ToString();
        p2Speed.text = Team.units[1].Speed.ToString();
        p2Level.text = Team.units[1].Level.ToString();

        //Add unit to list
        BattleReadyParty.Add(Team.units[1]);

        //Set proper text variables to proper values
        p3Name.text = Team.units[2].Name;
        player3Name.text = Team.units[2].Name;
        p3Health.text = Team.units[2].Health.ToString();
        p3Strength.text = Team.units[2].Strength.ToString();
        p3Defense.text = Team.units[2].Defense.ToString();
        p3Speed.text = Team.units[2].Speed.ToString();
        p3Level.text = Team.units[2].Level.ToString();

        //Add unit to list
        BattleReadyParty.Add(Team.units[2]);

        //Set images to passed in list
        setImages(BattleReadyParty);

        //Create objects
        Unit TwoFaced = new Unit("2Faced", 100, 20, 15, 5, 25, "Enemy");
        Unit AncientDragon = new Unit("Ancient Dragon", 200, 30, 12, 4, 100, "Enemy");
        Unit Ghost = new Unit("Ghost", 80, 20, 15, 5, 30, "Enemy");
        Unit IceGolem = new Unit("Ice Golem", 150, 25, 15, 5, 35, "Enemy");
        Unit Zuu = new Unit("Zuu", 120, 15, 10, 5, 20, "Enemy");
        Unit ToxicFrog = new Unit("Toxic Frog", 180, 22, 12, 5, 30, "Enemy");
        Unit DeathClaw = new Unit("Death Claw", 140, 25, 18, 7, 50, "Enemy");
        Unit MasterTonberry = new Unit("Master Tonberry", 170, 20, 15, 5, 50, "Enemy");
        Unit Behemoth = new Unit("Behemoth", 200, 35, 14, 4, 100, "Enemy");

        //Create a new list
        List<Unit> e = new List<Unit>();

        //Add the Enemy Types to the list
        e.Add(TwoFaced);
        e.Add(AncientDragon);
        e.Add(Ghost);
        e.Add(IceGolem);
        e.Add(Zuu);
        e.Add(ToxicFrog);
        e.Add(DeathClaw);
        e.Add(MasterTonberry);
        e.Add(Behemoth);

        //Creat an instance of Random class
        System.Random a = new System.Random();

        //call Next() 3 times giving random selection for enemy party members
        int e1 = a.Next(0, e.Count - 1);
        int e2 = a.Next(0, e.Count - 1);
        int e3 = a.Next(0, e.Count - 1);

        //while e1 is equal to ee2
        while (e1 == e2)
        {//Randomize e2
            e2 = a.Next(0, e.Count - 1);
        }
        //while e2 is equal to e3
        while (e2 == e3)
        {//Randomize e3
            e3 = a.Next(0, e.Count - 1);
        }
        //while e3 is equal to e1
        while (e3 == e1)
        {//Randomize e1
            e1 = a.Next(0, e.Count - 1);
            //while e1 is equal to e2
            while (e1 == e2)
            {//Randomize e1
                e1 = a.Next(0, e.Count - 1);
            }
        }
        //Add unit to list
        BattleReadyParty.Add(e[e1]);
        //Add unit to list
        BattleReadyParty.Add(e[e2]);
        //Add unit to list
        BattleReadyParty.Add(e[e3]);
        //Enable play button
        PlayButton.enabled = true;
    }
    
    //Function for setting game images to loaded in list
    public void LoadedGameImages(List<Unit> units)
    {//Loop through the number of units in the list
        for (int i = 0; i < units.Count; i++)
        {//If the unit at the current indexes name is the same as the player1Name.Text
            //Player Images
            if (units[i].Name == player1Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the p1.texture to the proper picture
                    case "Cloud":
                        p1.texture = imageList.Cloud;
                        break;
                    case "Barret":
                        p1.texture = imageList.Barrett;
                        break;
                    case "Cait Sith":
                        p1.texture = imageList.CaitSith;
                        break;
                    case "Aerith":
                        p1.texture = imageList.Aerith;
                        break;
                    case "Yuffie":
                        p1.texture = imageList.Yuffie;
                        break;
                    case "Vincent":
                        p1.texture = imageList.Vincent;
                        break;
                    case "Cid":
                        p1.texture = imageList.Cid;
                        break;
                    case "Red XIII":
                        p1.texture = imageList.RedXIII;
                        break;
                    case "Tifa":
                        p1.texture = imageList.Tifa;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the player2Name.Text
            if (units[i].Name == player2Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the p2.texture to the proper picture
                    case "Cloud":
                        p2.texture = imageList.Cloud;
                        break;
                    case "Barret":
                        p2.texture = imageList.Barrett;
                        break;
                    case "Cait Sith":
                        p2.texture = imageList.CaitSith;
                        break;
                    case "Aerith":
                        p2.texture = imageList.Aerith;
                        break;
                    case "Yuffie":
                        p2.texture = imageList.Yuffie;
                        break;
                    case "Vincent":
                        p2.texture = imageList.Vincent;
                        break;
                    case "Cid":
                        p2.texture = imageList.Cid;
                        break;
                    case "Red XIII":
                        p2.texture = imageList.RedXIII;
                        break;
                    case "Tifa":
                        p2.texture = imageList.Tifa;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the player3Name.Text
            if (units[i].Name == player3Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the p3.texture to the proper picture
                    case "Cloud":
                        p3.texture = imageList.Cloud;
                        break;
                    case "Barret":
                        p3.texture = imageList.Barrett;
                        break;
                    case "Cait Sith":
                        p3.texture = imageList.CaitSith;
                        break;
                    case "Aerith":
                        p3.texture = imageList.Aerith;
                        break;
                    case "Yuffie":
                        p3.texture = imageList.Yuffie;
                        break;
                    case "Vincent":
                        p3.texture = imageList.Vincent;
                        break;
                    case "Cid":
                        p3.texture = imageList.Cid;
                        break;
                    case "Red XIII":
                        p3.texture = imageList.RedXIII;
                        break;
                    case "Tifa":
                        p3.texture = imageList.Tifa;
                        break;
                    default:
                        break;
                }

            }
            //If the unit at the current indexes name is the same as the enemy1Name.Text
            //Enemy Images
            if (units[i].Name == enemy1Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the e1.texture to the proper picture
                    case "2Faced":
                        e1.texture = imageList.TwoFaced;
                        break;
                    case "Ice Golem":
                        e1.texture = imageList.IceGolem;
                        break;
                    case "Ancient Dragon":
                        e1.texture = imageList.AncientDragon;
                        break;
                    case "Behemoth":
                        e1.texture = imageList.Behemoth;
                        break;
                    case "Death Claw":
                        e1.texture = imageList.DeathClaw;
                        break;
                    case "Master Tonberry":
                        e1.texture = imageList.MasterTonberry;
                        break;
                    case "Toxic Frog":
                        e1.texture = imageList.ToxicFrog;
                        break;
                    case "Zuu":
                        e1.texture = imageList.Zuu;
                        break;
                    case "Ghost":
                        e1.texture = imageList.Ghost;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the enemy2Name.Text
            if (units[i].Name == enemy2Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the e2.texture to the proper picture
                    case "2Faced":
                        e2.texture = imageList.TwoFaced;
                        break;
                    case "Ice Golem":
                        e2.texture = imageList.IceGolem;
                        break;
                    case "Ancient Dragon":
                        e2.texture = imageList.AncientDragon;
                        break;
                    case "Behemoth":
                        e2.texture = imageList.Behemoth;
                        break;
                    case "Death Claw":
                        e2.texture = imageList.DeathClaw;
                        break;
                    case "Master Tonberry":
                        e2.texture = imageList.MasterTonberry;
                        break;
                    case "Toxic Frog":
                        e2.texture = imageList.ToxicFrog;
                        break;
                    case "Zuu":
                        e2.texture = imageList.Zuu;
                        break;
                    case "Ghost":
                        e2.texture = imageList.Ghost;
                        break;
                    default:
                        break;
                }

            }
            //If the unit at the current indexes name is the same as the enemy3Name.Text
            if (units[i].Name == enemy3Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the e3.texture to the proper picture
                    case "2Faced":
                        e3.texture = imageList.TwoFaced;
                        break;
                    case "Ice Golem":
                        e3.texture = imageList.IceGolem;
                        break;
                    case "Ancient Dragon":
                        e3.texture = imageList.AncientDragon;
                        break;
                    case "Behemoth":
                        e3.texture = imageList.Behemoth;
                        break;
                    case "Death Claw":
                        e3.texture = imageList.DeathClaw;
                        break;
                    case "Master Tonberry":
                        e3.texture = imageList.MasterTonberry;
                        break;
                    case "Toxic Frog":
                        e3.texture = imageList.ToxicFrog;
                        break;
                    case "Zuu":
                        e3.texture = imageList.Zuu;
                        break;
                    case "Ghost":
                        e3.texture = imageList.Ghost;
                        break;
                    default:
                        break;
                }

            }
        }
    }
    
    //Function for setting the images of new game objects
    public void setImages(List<Unit> units)
    {//Loop through the number of units in the list
        for (int i = 0; i < units.Count; i++)
        {//If the unit at the current indexes name is the same as the player1Name.Text
            //Player Images
            if (units[i].Name == player1Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the player1.texture to the proper picture
                    case "Cloud":
                        player1.texture = imageList.Cloud;
                        p1.texture = imageList.Cloud;
                        break;
                    case "Barret":
                        player1.texture = imageList.Barrett;
                        p1.texture = imageList.Barrett;
                        break;
                    case "Cait Sith":
                        player1.texture = imageList.CaitSith;
                        p1.texture = imageList.CaitSith;
                        break;
                    case "Aerith":
                        player1.texture = imageList.Aerith;
                        p1.texture = imageList.Aerith;
                        break;
                    case "Yuffie":
                        player1.texture = imageList.Yuffie;
                        p1.texture = imageList.Yuffie;
                        break;
                    case "Vincent":
                        player1.texture = imageList.Vincent;
                        p1.texture = imageList.Vincent;
                        break;
                    case "Cid":
                        player1.texture = imageList.Cid;
                        p1.texture = imageList.Cid;
                        break;
                    case "Red XIII":
                        player1.texture = imageList.RedXIII;
                        p1.texture = imageList.RedXIII;
                        break;
                    case "Tifa":
                        player1.texture = imageList.Tifa;
                        p1.texture = imageList.Tifa;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the player2Name.Text
            if (units[i].Name == player2Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the player2.texture to the proper picture
                    case "Cloud":
                        player2.texture = imageList.Cloud;
                        p2.texture = imageList.Cloud;
                        break;
                    case "Barret":
                        player2.texture = imageList.Barrett;
                        p2.texture = imageList.Barrett;
                        break;
                    case "Cait Sith":
                        player2.texture = imageList.CaitSith;
                        p2.texture = imageList.CaitSith;
                        break;
                    case "Aerith":
                        player2.texture = imageList.Aerith;
                        p2.texture = imageList.Aerith;
                        break;
                    case "Yuffie":
                        player2.texture = imageList.Yuffie;
                        p2.texture = imageList.Yuffie;
                        break;
                    case "Vincent":
                        player2.texture = imageList.Vincent;
                        p2.texture = imageList.Vincent;
                        break;
                    case "Cid":
                        player2.texture = imageList.Cid;
                        p2.texture = imageList.Cid;
                        break;
                    case "Red XIII":
                        player2.texture = imageList.RedXIII;
                        p2.texture = imageList.RedXIII;
                        break;
                    case "Tifa":
                        player2.texture = imageList.Tifa;
                        p2.texture = imageList.Tifa;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the player3Name.Text
            if (units[i].Name == player3Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the player3.texture to the proper picture
                    case "Cloud":
                        player3.texture = imageList.Cloud;
                        p3.texture = imageList.Cloud;
                        break;
                    case "Barret":
                        player3.texture = imageList.Barrett;
                        p3.texture = imageList.Barrett;
                        break;
                    case "Cait Sith":
                        player3.texture = imageList.CaitSith;
                        p3.texture = imageList.CaitSith;
                        break;
                    case "Aerith":
                        player3.texture = imageList.Aerith;
                        p3.texture = imageList.Aerith;
                        break;
                    case "Yuffie":
                        player3.texture = imageList.Yuffie;
                        p3.texture = imageList.Yuffie;
                        break;
                    case "Vincent":
                        player3.texture = imageList.Vincent;
                        p3.texture = imageList.Vincent;
                        break;
                    case "Cid":
                        player3.texture = imageList.Cid;
                        p3.texture = imageList.Cid;
                        break;
                    case "Red XIII":
                        player3.texture = imageList.RedXIII;
                        p3.texture = imageList.RedXIII;
                        break;
                    case "Tifa":
                        player3.texture = imageList.Tifa;
                        p3.texture = imageList.Tifa;
                        break;
                    default:
                        break;
                }

            }
            //If the unit at the current indexes name is the same as the enemy1Name.Text
            //Enemy Images
            if (units[i].Name == enemy1Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the e1.texture to the proper picture
                    case "2Faced":
                        e1.texture = imageList.TwoFaced;
                        break;
                    case "Ice Golem":
                        e1.texture = imageList.IceGolem;
                        break;
                    case "Ancient Dragon":
                        e1.texture = imageList.AncientDragon;
                        break;
                    case "Behemoth":
                        e1.texture = imageList.Behemoth;
                        break;
                    case "Death Claw":
                        e1.texture = imageList.DeathClaw;
                        break;
                    case "Master Tonberry":
                        e1.texture = imageList.MasterTonberry;
                        break;
                    case "Toxic Frog":
                        e1.texture = imageList.ToxicFrog;
                        break;
                    case "Zuu":
                        e1.texture = imageList.Zuu;
                        break;
                    case "Ghost":
                        e1.texture = imageList.Ghost;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the enemy2Name.Text
            if (units[i].Name == enemy2Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the e2.texture to the proper picture
                    case "2Faced":
                        e2.texture = imageList.TwoFaced;
                        break;
                    case "Ice Golem":
                        e2.texture = imageList.IceGolem;
                        break;
                    case "Ancient Dragon":
                        e2.texture = imageList.AncientDragon;
                        break;
                    case "Behemoth":
                        e2.texture = imageList.Behemoth;
                        break;
                    case "Death Claw":
                        e2.texture = imageList.DeathClaw;
                        break;
                    case "Master Tonberry":
                        e2.texture = imageList.MasterTonberry;
                        break;
                    case "Toxic Frog":
                        e2.texture = imageList.ToxicFrog;
                        break;
                    case "Zuu":
                        e2.texture = imageList.Zuu;
                        break;
                    case "Ghost":
                        e2.texture = imageList.Ghost;
                        break;
                    default:
                        break;
                }

            }
            //If the unit at the current indexes name is the same as the enemy3Name.Text
            if (units[i].Name == enemy3Name.text)
            {//Look For the Name in this statement
                switch (units[i].Name)
                {//If the name is here in a case then set the e3.texture to the proper picture
                    case "2Faced":
                        e3.texture = imageList.TwoFaced;
                        break;
                    case "Ice Golem":
                        e3.texture = imageList.IceGolem;
                        break;
                    case "Ancient Dragon":
                        e3.texture = imageList.AncientDragon;
                        break;
                    case "Behemoth":
                        e3.texture = imageList.Behemoth;
                        break;
                    case "Death Claw":
                        e3.texture = imageList.DeathClaw;
                        break;
                    case "Master Tonberry":
                        e3.texture = imageList.MasterTonberry;
                        break;
                    case "Toxic Frog":
                        e3.texture = imageList.ToxicFrog;
                        break;
                    case "Zuu":
                        e3.texture = imageList.Zuu;
                        break;
                    case "Ghost":
                        e3.texture = imageList.Ghost;
                        break;
                    default:
                        break;
                }

            }
        }
    }
}
