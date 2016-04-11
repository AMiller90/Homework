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
    ImagesScript iImageList;
    //Create public List<Unit>
    public List<Unit> ulBattleReadyParty;
    //Public Canvas object
    public Canvas cGameCanvas;
    //Public Canvas object
    public Canvas cGeneratePartyCanvas;
    //Public Canvas object
    public Canvas cBattleCanvas;
    //Public Canvas object
    public Canvas cSavedFilePrompt;
    //public Button object
    public Button bPlayButton;
    //public InputField object
    public InputField ifP1Name;
    //public InputField object
    public InputField ifP1Health;
    //public InputField object
    public InputField ifP1Strength;
    //public InputField object
    public InputField ifP1Defense;
    //public InputField object
    public InputField ifP1Speed;
    //public InputField object
    public InputField ifP1Level;
    //public RawImage object
    public RawImage riPlayer1;

    //public InputField object
    public InputField ifP2Name;
    //public InputField object
    public InputField ifP2Health;
    //public InputField object
    public InputField ifP2Strength;
    //public InputField object
    public InputField ifP2Defense;
    //public InputField object
    public InputField ifP2Speed;
    //public InputField object
    public InputField ifP2Level;
    //public RawImage object
    public RawImage riPlayer2;

    //public InputField object
    public InputField ifP3Name;
    //public InputField object
    public InputField ifP3Health;
    //public InputField object
    public InputField ifP3Strength;
    //public InputField object
    public InputField ifP3Defense;
    //public InputField object
    public InputField ifP3Speed;
    //public InputField object
    public InputField ifP3Level;
    //public RawImage object
    public RawImage riPlayer3;

    //public Text object
    public Text tPlayer1Name;
    //public Text object
    public Text tPlayer2Name;
    //public Text object
    public Text tPlayer3Name;
    //public RawImage object
    public RawImage riP1;
    //public RawImage object
    public RawImage riP2;
    //public RawImage object
    public RawImage riP3;

    //public Text object
    public Text tEnemy1Name;
    //public Text object
    public Text tEnemy2Name;
    //public Text object
    public Text tEnemy3Name;
    //public RawImage object
    public RawImage riE1;
    //public RawImage object
    public RawImage riE2;
    //public RawImage object
    public RawImage riE3;

    // Use this for initialization
    void Start ()
    {//Set List to new list
        ulBattleReadyParty = new List<Unit>();
        //Get proper component
        iImageList = GetComponent<ImagesScript>();
        //Enable cGameCanvas
        cGameCanvas.enabled = true;
        //Disable cGeneratePartyCanvas
        cGeneratePartyCanvas.enabled = false;
        //Disable cBattleCanvas
        cBattleCanvas.enabled = false;
        //Disable the bPlayButton
        bPlayButton.enabled = false;
        //Disable the cSavedFilePrompt
        cSavedFilePrompt.enabled = false;
    }

    //Function called when newGame Button is clicked
    public void newGame()
    {//Disable play button
        bPlayButton.enabled = false;

        //Set player textures to null
        riPlayer1.texture = null;
        riPlayer2.texture = null;
        riPlayer3.texture = null;

        //Set p1 name text to 
        ifP1Name.text = "";
        //Set riPlayer1name text to 
        tPlayer1Name.text = "";
        //Set p1 Health text to 
        ifP1Health.text = "";
        //Set p1 Strength text to 
        ifP1Strength.text = "";
        //Set p1 Defense text to 
        ifP1Defense.text = "";
        //Set p1 Speed text to 
        ifP1Speed.text = "";
        //Set p1 Level text to 
        ifP1Level.text = "";

        //Set p2 name text to 
        ifP2Name.text = "";
        //Set ifPlayer2name text to 
        tPlayer2Name.text = "";
        //Set p2 Health text to 
        ifP2Health.text = "";
        //Set p2 Strength text to 
        ifP2Strength.text = "";
        //Set p2 Defense text to 
        ifP2Defense.text = "";
        //Set p2 Speed text to 
        ifP2Speed.text = "";
        //Set p2 Level text to 
        ifP2Level.text = "";

        //Set p3 name text to 
        ifP3Name.text = "";
        //Set player3name text to 
        tPlayer3Name.text = "";
        //Set p3 Health text to 
        ifP3Health.text = "";
        //Set p3 Strength text to 
        ifP3Strength.text = "";
        //Set p3 Defense text to 
        ifP3Defense.text = "";
        //Set p3 Speed text to 
        ifP3Speed.text = "";
        //Set p3 Level text to 
        ifP3Level.text = "";

        //Disable cGameCanvas
        cGameCanvas.enabled = false;
        //Enable cGeneratePartyCanvas
        cGeneratePartyCanvas.enabled = true;
    }

    //Function used to generate a random party
    public void GenerateParty()
    {//Enable play button to true
        bPlayButton.enabled = true;
        //Create a new list 
        List<Unit> ulAllObjects = new List<Unit>();
        //Create a new list
        List<Unit> ulPlayers = new List<Unit>();
        //Create a new list
        List<Unit> ulEnemies = new List<Unit>();

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
        ulAllObjects.Add(Cloud);
        ulAllObjects.Add(Barret);
        ulAllObjects.Add(Tifa);
        ulAllObjects.Add(Aerith);
        ulAllObjects.Add(RedXIII);
        ulAllObjects.Add(Cait);
        ulAllObjects.Add(Cid);
        ulAllObjects.Add(Yuffie);
        ulAllObjects.Add(Vincent);

        ulAllObjects.Add(TwoFaced);
        ulAllObjects.Add(AncientDragon);
        ulAllObjects.Add(Ghost);
        ulAllObjects.Add(IceGolem);
        ulAllObjects.Add(Zuu);
        ulAllObjects.Add(ToxicFrog);
        ulAllObjects.Add(DeathClaw);
        ulAllObjects.Add(MasterTonberry);
        ulAllObjects.Add(Behemoth);

        //Loop through the list
        foreach (Unit i in ulAllObjects)
        {//Check if current unit is a player type
            if (i.sType == "Player")
            {//If true then add to player party
                ulPlayers.Add(i);
            }
            //Check if current unit is an enemy
            if (i.sType == "Enemy")
            {//If true then add to enemy party
                ulEnemies.Add(i);
            }

        }
        //Call function to randomize the objects
        RandomizeAllParties(ulPlayers, ulEnemies);

    }

    //Function that randomizes both the player and enemy parties
    private void RandomizeAllParties(List<Unit> ulP, List<Unit> ulE)
    {//If count of the ulBattleReadyParty is greater than or equal to 1
        if (ulBattleReadyParty.Count >= 1)
        {//Remove all elements of the current ulBattleReadyParty list
            ulBattleReadyParty.RemoveRange(0, ulBattleReadyParty.Count);
        }

        //Create random class instance
        System.Random r = new System.Random();
        //call Next() 3 times giving random selection for party members
        int p1 = r.Next(0, ulP.Count - 1);
        int p2 = r.Next(0, ulP.Count - 1);
        int p3 = r.Next(0, ulP.Count - 1);

        //while p1 is equal to p2
        while (p1 == p2)
        {//randomize p2
            p2 = r.Next(0, ulP.Count - 1);
        }
        //while p2 == p3
        while (p2 == p3)
        {//randomize p3
            p3 = r.Next(0, ulP.Count - 1);
        }
        //while p3 == p1
        while (p3 == p1)
        {//randomize p1
            p1 = r.Next(0, ulP.Count - 1);
            //while p1 == p2
            while (p1 == p2)
            {//randomize p1
                p1 = r.Next(0, ulP.Count - 1);
            }
        }
        //Set proper text variables to proper values
        ifP1Name.text = ulP[p1].sName;
        tPlayer1Name.text = ulP[p1].sName;
        ifP1Health.text = ulP[p1].iHealth.ToString();
        ifP1Strength.text = ulP[p1].iStrength.ToString();
        ifP1Defense.text = ulP[p1].iDefense.ToString();
        ifP1Speed.text = ulP[p1].iSpeed.ToString();
        ifP1Level.text = ulP[p1].iLevel.ToString();
        //Add unit to list
        ulBattleReadyParty.Add(ulP[p1]);

        //Set proper text variables to proper values
        ifP2Name.text = ulP[p2].sName;
        tPlayer2Name.text = ulP[p2].sName;
        ifP2Health.text = ulP[p2].iHealth.ToString();
        ifP2Strength.text = ulP[p2].iStrength.ToString();
        ifP2Defense.text = ulP[p2].iDefense.ToString();
        ifP2Speed.text = ulP[p2].iSpeed.ToString();
        ifP2Level.text = ulP[p2].iLevel.ToString();
        //Add unit to list
        ulBattleReadyParty.Add(ulP[p2]);

        //Set proper text variables to proper values
        ifP3Name.text = ulP[p3].sName;
        tPlayer3Name.text = ulP[p3].sName;
        ifP3Health.text = ulP[p3].iHealth.ToString();
        ifP3Strength.text = ulP[p3].iStrength.ToString();
        ifP3Defense.text = ulP[p3].iDefense.ToString();
        ifP3Speed.text = ulP[p3].iSpeed.ToString();
        ifP3Level.text = ulP[p3].iLevel.ToString();
        //Add unit to list
        ulBattleReadyParty.Add(ulP[p3]);
        //Call function to setImages to the units in the list
        setImages(ulBattleReadyParty);

        //Create random class instance
        System.Random a = new System.Random();

        //call Next() 3 times giving random selection for enemy party members
        int e1 = a.Next(0, ulE.Count - 1);
        int e2 = a.Next(0, ulE.Count - 1);
        int e3 = a.Next(0, ulE.Count - 1);

        //while e1 is equal to e2
        while (e1 == e2)
        {//Randomize e2
            e2 = a.Next(0, ulE.Count - 1);
        }
        //while e2 is equal to e1
        while (e2 == e3)
        {//Randomize e3
            e3 = a.Next(0, ulE.Count - 1);
        }
        //while e3 is equal to e1
        while (e3 == e1)
        {//Randomize e1
            e1 = a.Next(0, ulE.Count - 1);
            //while e1 is equal to e2
            while (e1 == e2)
            {//Randomize e1
                e1 = a.Next(0, ulE.Count - 1);
            }
        }
        //Add unit to list
        ulBattleReadyParty.Add(ulE[e1]);
        //Add unit to list
        ulBattleReadyParty.Add(ulE[e2]);
        //Add unit to list
        ulBattleReadyParty.Add(ulE[e3]);

    }

    //Function that loads the unit party
    public void loadParty()
    {//Create instance of FileIOS object
        FileIOS File = new FileIOS();
        //Create an instance of a new Party object
        Party Team = new Party();

        //If count of the ulBattleReadyParty is greater than or equal to 1
        if (ulBattleReadyParty.Count >= 1)
        {//Remove all elements of the current ulBattleReadyParty list
            ulBattleReadyParty.RemoveRange(0, ulBattleReadyParty.Count);
        }

        //string victoryParty = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData/VictoryParty", "xml");
        //Store file path into the string variable
        string victoryParty = Application.dataPath + "/GameData/VictoryParty/WinningParty.xml";
        //Deserialize the the object in the path and store into party variable
        Team = File.Deserialize<Party>(victoryParty);

        //Set proper text variables to proper values
        ifP1Name.text = Team.ulUnits[0].sName;
        ifP1Name.text = Team.ulUnits[0].sName;
        ifP1Health.text = Team.ulUnits[0].iHealth.ToString();
        ifP1Strength.text = Team.ulUnits[0].iStrength.ToString();
        ifP1Defense.text = Team.ulUnits[0].iDefense.ToString();
        ifP1Speed.text = Team.ulUnits[0].iSpeed.ToString();
        ifP1Level.text = Team.ulUnits[0].iLevel.ToString();

        //Add unit to list
        ulBattleReadyParty.Add(Team.ulUnits[0]);

        //Set proper text variables to proper values
        ifP2Name.text = Team.ulUnits[1].sName;
        ifP2Name.text = Team.ulUnits[1].sName;
        ifP2Health.text = Team.ulUnits[1].iHealth.ToString();
        ifP2Strength.text = Team.ulUnits[1].iStrength.ToString();
        ifP2Defense.text = Team.ulUnits[1].iDefense.ToString();
        ifP2Speed.text = Team.ulUnits[1].iSpeed.ToString();
        ifP2Level.text = Team.ulUnits[1].iLevel.ToString();

        //Add unit to list
        ulBattleReadyParty.Add(Team.ulUnits[1]);

        //Set proper text variables to proper values
        ifP3Name.text = Team.ulUnits[2].sName;
        ifP3Name.text = Team.ulUnits[2].sName;
        ifP3Health.text = Team.ulUnits[2].iHealth.ToString();
        ifP3Strength.text = Team.ulUnits[2].iStrength.ToString();
        ifP3Defense.text = Team.ulUnits[2].iDefense.ToString();
        ifP3Speed.text = Team.ulUnits[2].iSpeed.ToString();
        ifP3Level.text = Team.ulUnits[2].iLevel.ToString();

        //Add unit to list
        ulBattleReadyParty.Add(Team.ulUnits[2]);

        //Set images to passed in list
        setImages(ulBattleReadyParty);

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
        List<Unit> ulE = new List<Unit>();

        //Add the Enemy Types to the list
        ulE.Add(TwoFaced);
        ulE.Add(AncientDragon);
        ulE.Add(Ghost);
        ulE.Add(IceGolem);
        ulE.Add(Zuu);
        ulE.Add(ToxicFrog);
        ulE.Add(DeathClaw);
        ulE.Add(MasterTonberry);
        ulE.Add(Behemoth);

        //Creat an instance of Random class
        System.Random a = new System.Random();

        //call Next() 3 times giving random selection for enemy party members
        int e1 = a.Next(0, ulE.Count - 1);
        int e2 = a.Next(0, ulE.Count - 1);
        int e3 = a.Next(0, ulE.Count - 1);

        //while e1 is equal to ee2
        while (e1 == e2)
        {//Randomize e2
            e2 = a.Next(0, ulE.Count - 1);
        }
        //while e2 is equal to e3
        while (e2 == e3)
        {//Randomize e3
            e3 = a.Next(0, ulE.Count - 1);
        }
        //while e3 is equal to e1
        while (e3 == e1)
        {//Randomize e1
            e1 = a.Next(0, ulE.Count - 1);
            //while e1 is equal to e2
            while (e1 == e2)
            {//Randomize e1
                e1 = a.Next(0, ulE.Count - 1);
            }
        }
        //Add unit to list
        ulBattleReadyParty.Add(ulE[e1]);
        //Add unit to list
        ulBattleReadyParty.Add(ulE[e2]);
        //Add unit to list
        ulBattleReadyParty.Add(ulE[e3]);
        //Enable play button
        bPlayButton.enabled = true;
    }
    
    //Function for setting game images to loaded in list
    public void LoadedGameImages(List<Unit> ulUnits)
    {//Loop through the number of units in the list
        for (int i = 0; i < ulUnits.Count; i++)
        {//If the unit at the current indexes name is the same as the riPlayer1Name.Text
            //Player Images
            if (ulUnits[i].sName == tPlayer1Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the p1.texture to the proper picture
                    case "Cloud":
                        riP1.texture = iImageList.tCloud;
                        break;
                    case "Barret":
                        riP1.texture = iImageList.tBarrett;
                        break;
                    case "Cait Sith":
                        riP1.texture = iImageList.tCaitSith;
                        break;
                    case "Aerith":
                        riP1.texture = iImageList.tAerith;
                        break;
                    case "Yuffie":
                        riP1.texture = iImageList.tYuffie;
                        break;
                    case "Vincent":
                        riP1.texture = iImageList.tVincent;
                        break;
                    case "Cid":
                        riP1.texture = iImageList.tCid;
                        break;
                    case "Red XIII":
                        riP1.texture = iImageList.tRedXIII;
                        break;
                    case "Tifa":
                        riP1.texture = iImageList.tTifa;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the ifPlayer2Name.Text
            if (ulUnits[i].sName == tPlayer2Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the p2.texture to the proper picture
                    case "Cloud":
                        riP2.texture = iImageList.tCloud;
                        break;
                    case "Barret":
                        riP2.texture = iImageList.tBarrett;
                        break;
                    case "Cait Sith":
                        riP2.texture = iImageList.tCaitSith;
                        break;
                    case "Aerith":
                        riP2.texture = iImageList.tAerith;
                        break;
                    case "Yuffie":
                        riP2.texture = iImageList.tYuffie;
                        break;
                    case "Vincent":
                        riP2.texture = iImageList.tVincent;
                        break;
                    case "Cid":
                        riP2.texture = iImageList.tCid;
                        break;
                    case "Red XIII":
                        riP2.texture = iImageList.tRedXIII;
                        break;
                    case "Tifa":
                        riP2.texture = iImageList.tTifa;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the player3Name.Text
            if (ulUnits[i].sName == tPlayer3Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the p3.texture to the proper picture
                    case "Cloud":
                        riP3.texture = iImageList.tCloud;
                        break;
                    case "Barret":
                        riP3.texture = iImageList.tBarrett;
                        break;
                    case "Cait Sith":
                        riP3.texture = iImageList.tCaitSith;
                        break;
                    case "Aerith":
                        riP3.texture = iImageList.tAerith;
                        break;
                    case "Yuffie":
                        riP3.texture = iImageList.tYuffie;
                        break;
                    case "Vincent":
                        riP3.texture = iImageList.tVincent;
                        break;
                    case "Cid":
                        riP3.texture = iImageList.tCid;
                        break;
                    case "Red XIII":
                        riP3.texture = iImageList.tRedXIII;
                        break;
                    case "Tifa":
                        riP3.texture = iImageList.tTifa;
                        break;
                    default:
                        break;
                }

            }
            //If the unit at the current indexes name is the same as the enemy1Name.Text
            //Enemy Images
            if (ulUnits[i].sName == tEnemy1Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the e1.texture to the proper picture
                    case "2Faced":
                        riE1.texture = iImageList.tTwoFaced;
                        break;
                    case "Ice Golem":
                        riE1.texture = iImageList.tIceGolem;
                        break;
                    case "Ancient Dragon":
                        riE1.texture = iImageList.tAncientDragon;
                        break;
                    case "Behemoth":
                        riE1.texture = iImageList.tBehemoth;
                        break;
                    case "Death Claw":
                        riE1.texture = iImageList.tDeathClaw;
                        break;
                    case "Master Tonberry":
                        riE1.texture = iImageList.tMasterTonberry;
                        break;
                    case "Toxic Frog":
                        riE1.texture = iImageList.tToxicFrog;
                        break;
                    case "Zuu":
                        riE1.texture = iImageList.tZuu;
                        break;
                    case "Ghost":
                        riE1.texture = iImageList.tGhost;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the enemy2Name.Text
            if (ulUnits[i].sName == tEnemy2Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the e2.texture to the proper picture
                    case "2Faced":
                        riE2.texture = iImageList.tTwoFaced;
                        break;
                    case "Ice Golem":
                        riE2.texture = iImageList.tIceGolem;
                        break;
                    case "Ancient Dragon":
                        riE2.texture = iImageList.tAncientDragon;
                        break;
                    case "Behemoth":
                        riE2.texture = iImageList.tBehemoth;
                        break;
                    case "Death Claw":
                        riE2.texture = iImageList.tDeathClaw;
                        break;
                    case "Master Tonberry":
                        riE2.texture = iImageList.tMasterTonberry;
                        break;
                    case "Toxic Frog":
                        riE2.texture = iImageList.tToxicFrog;
                        break;
                    case "Zuu":
                        riE2.texture = iImageList.tZuu;
                        break;
                    case "Ghost":
                        riE2.texture = iImageList.tGhost;
                        break;
                    default:
                        break;
                }

            }
            //If the unit at the current indexes name is the same as the enemy3Name.Text
            if (ulUnits[i].sName == tEnemy3Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the e3.texture to the proper picture
                    case "2Faced":
                        riE3.texture = iImageList.tTwoFaced;
                        break;
                    case "Ice Golem":
                        riE3.texture = iImageList.tIceGolem;
                        break;
                    case "Ancient Dragon":
                        riE3.texture = iImageList.tAncientDragon;
                        break;
                    case "Behemoth":
                        riE3.texture = iImageList.tBehemoth;
                        break;
                    case "Death Claw":
                        riE3.texture = iImageList.tDeathClaw;
                        break;
                    case "Master Tonberry":
                        riE3.texture = iImageList.tMasterTonberry;
                        break;
                    case "Toxic Frog":
                        riE3.texture = iImageList.tToxicFrog;
                        break;
                    case "Zuu":
                        riE3.texture = iImageList.tZuu;
                        break;
                    case "Ghost":
                        riE3.texture = iImageList.tGhost;
                        break;
                    default:
                        break;
                }

            }
        }
    }
    
    //Function for setting the images of new game objects
    public void setImages(List<Unit> ulUnits)
    {//Loop through the number of units in the list
        for (int i = 0; i < ulUnits.Count; i++)
        {//If the unit at the current indexes name is the same as the riPlayer1Name.Text
            //Player Images
            if (ulUnits[i].sName == tPlayer1Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the riPlayer1.texture to the proper picture
                    case "Cloud":
                        riPlayer1.texture = iImageList.tCloud;
                        riP1.texture = iImageList.tCloud;
                        break;
                    case "Barret":
                        riPlayer1.texture = iImageList.tBarrett;
                        riP1.texture = iImageList.tBarrett;
                        break;
                    case "Cait Sith":
                        riPlayer1.texture = iImageList.tCaitSith;
                        riP1.texture = iImageList.tCaitSith;
                        break;
                    case "Aerith":
                        riPlayer1.texture = iImageList.tAerith;
                        riP1.texture = iImageList.tAerith;
                        break;
                    case "Yuffie":
                        riPlayer1.texture = iImageList.tYuffie;
                        riP1.texture = iImageList.tYuffie;
                        break;
                    case "Vincent":
                        riPlayer1.texture = iImageList.tVincent;
                        riP1.texture = iImageList.tVincent;
                        break;
                    case "Cid":
                        riPlayer1.texture = iImageList.tCid;
                        riP1.texture = iImageList.tCid;
                        break;
                    case "Red XIII":
                        riPlayer1.texture = iImageList.tRedXIII;
                        riP1.texture = iImageList.tRedXIII;
                        break;
                    case "Tifa":
                        riPlayer1.texture = iImageList.tTifa;
                        riP1.texture = iImageList.tTifa;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the ifPlayer2Name.Text
            if (ulUnits[i].sName == tPlayer2Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the ifPlayer2.texture to the proper picture
                    case "Cloud":
                        riPlayer2.texture = iImageList.tCloud;
                        riP2.texture = iImageList.tCloud;
                        break;
                    case "Barret":
                        riPlayer2.texture = iImageList.tBarrett;
                        riP2.texture = iImageList.tBarrett;
                        break;
                    case "Cait Sith":
                        riPlayer2.texture = iImageList.tCaitSith;
                        riP2.texture = iImageList.tCaitSith;
                        break;
                    case "Aerith":
                        riPlayer2.texture = iImageList.tAerith;
                        riP2.texture = iImageList.tAerith;
                        break;
                    case "Yuffie":
                        riPlayer2.texture = iImageList.tYuffie;
                        riP2.texture = iImageList.tYuffie;
                        break;
                    case "Vincent":
                        riPlayer2.texture = iImageList.tVincent;
                        riP2.texture = iImageList.tVincent;
                        break;
                    case "Cid":
                        riPlayer2.texture = iImageList.tCid;
                        riP2.texture = iImageList.tCid;
                        break;
                    case "Red XIII":
                        riPlayer2.texture = iImageList.tRedXIII;
                        riP2.texture = iImageList.tRedXIII;
                        break;
                    case "Tifa":
                        riPlayer2.texture = iImageList.tTifa;
                        riP2.texture = iImageList.tTifa;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the player3Name.Text
            if (ulUnits[i].sName == tPlayer3Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the player3.texture to the proper picture
                    case "Cloud":
                        riPlayer3.texture = iImageList.tCloud;
                        riP3.texture = iImageList.tCloud;
                        break;
                    case "Barret":
                        riPlayer3.texture = iImageList.tBarrett;
                        riP3.texture = iImageList.tBarrett;
                        break;
                    case "Cait Sith":
                        riPlayer3.texture = iImageList.tCaitSith;
                        riP3.texture = iImageList.tCaitSith;
                        break;
                    case "Aerith":
                        riPlayer3.texture = iImageList.tAerith;
                        riP3.texture = iImageList.tAerith;
                        break;
                    case "Yuffie":
                        riPlayer3.texture = iImageList.tYuffie;
                        riP3.texture = iImageList.tYuffie;
                        break;
                    case "Vincent":
                        riPlayer3.texture = iImageList.tVincent;
                        riP3.texture = iImageList.tVincent;
                        break;
                    case "Cid":
                        riPlayer3.texture = iImageList.tCid;
                        riP3.texture = iImageList.tCid;
                        break;
                    case "Red XIII":
                        riPlayer3.texture = iImageList.tRedXIII;
                        riP3.texture = iImageList.tRedXIII;
                        break;
                    case "Tifa":
                        riPlayer3.texture = iImageList.tTifa;
                        riP3.texture = iImageList.tTifa;
                        break;
                    default:
                        break;
                }

            }
            //If the unit at the current indexes name is the same as the enemy1Name.Text
            //Enemy Images
            if (ulUnits[i].sName == tEnemy1Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the e1.texture to the proper picture
                    case "2Faced":
                        riE1.texture = iImageList.tTwoFaced;
                        break;
                    case "Ice Golem":
                        riE1.texture = iImageList.tIceGolem;
                        break;
                    case "Ancient Dragon":
                        riE1.texture = iImageList.tAncientDragon;
                        break;
                    case "Behemoth":
                        riE1.texture = iImageList.tBehemoth;
                        break;
                    case "Death Claw":
                        riE1.texture = iImageList.tDeathClaw;
                        break;
                    case "Master Tonberry":
                        riE1.texture = iImageList.tMasterTonberry;
                        break;
                    case "Toxic Frog":
                        riE1.texture = iImageList.tToxicFrog;
                        break;
                    case "Zuu":
                        riE1.texture = iImageList.tZuu;
                        break;
                    case "Ghost":
                        riE1.texture = iImageList.tGhost;
                        break;
                    default:
                        break;
                }
            }
            //If the unit at the current indexes name is the same as the enemy2Name.Text
            if (ulUnits[i].sName == tEnemy2Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the e2.texture to the proper picture
                    case "2Faced":
                        riE2.texture = iImageList.tTwoFaced;
                        break;
                    case "Ice Golem":
                        riE2.texture = iImageList.tIceGolem;
                        break;
                    case "Ancient Dragon":
                        riE2.texture = iImageList.tAncientDragon;
                        break;
                    case "Behemoth":
                        riE2.texture = iImageList.tBehemoth;
                        break;
                    case "Death Claw":
                        riE2.texture = iImageList.tDeathClaw;
                        break;
                    case "Master Tonberry":
                        riE2.texture = iImageList.tMasterTonberry;
                        break;
                    case "Toxic Frog":
                        riE2.texture = iImageList.tToxicFrog;
                        break;
                    case "Zuu":
                        riE2.texture = iImageList.tZuu;
                        break;
                    case "Ghost":
                        riE2.texture = iImageList.tGhost;
                        break;
                    default:
                        break;
                }

            }
            //If the unit at the current indexes name is the same as the enemy3Name.Text
            if (ulUnits[i].sName == tEnemy3Name.text)
            {//Look For the Name in this statement
                switch (ulUnits[i].sName)
                {//If the name is here in a case then set the e3.texture to the proper picture
                    case "2Faced":
                        riE3.texture = iImageList.tTwoFaced;
                        break;
                    case "Ice Golem":
                        riE3.texture = iImageList.tIceGolem;
                        break;
                    case "Ancient Dragon":
                        riE3.texture = iImageList.tAncientDragon;
                        break;
                    case "Behemoth":
                        riE3.texture = iImageList.tBehemoth;
                        break;
                    case "Death Claw":
                        riE3.texture = iImageList.tDeathClaw;
                        break;
                    case "Master Tonberry":
                        riE3.texture = iImageList.tMasterTonberry;
                        break;
                    case "Toxic Frog":
                        riE3.texture = iImageList.tToxicFrog;
                        break;
                    case "Zuu":
                        riE3.texture = iImageList.tZuu;
                        break;
                    case "Ghost":
                        riE3.texture = iImageList.tGhost;
                        break;
                    default:
                        break;
                }

            }
        }
    }

    //Function called when the ok button is clicked on the cSavedFilePrompt canvas
    public void FileSaved()
    {//Disable the cSavedFilePrompt Canvas
        cSavedFilePrompt.enabled = false;
    }
}
