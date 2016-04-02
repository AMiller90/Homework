using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using System.Collections;
using Adgp125_Assessment_Library;
using System.Collections.Generic;
using FileIO;
public class CanvasScript : MonoBehaviour {

    ImagesScript imageList;

    public List<Unit> BattleReadyParty;

    public Canvas gameCanvas;
    public Canvas generatePartyCanvas;
    public Canvas battleCanvas;

    public Button PlayButton;
    public InputField p1Name;
    public InputField p1Health;
    public InputField p1Strength;
    public InputField p1Defense;
    public InputField p1Speed;
    public InputField p1Level;
    public RawImage player1;

    public InputField p2Name;
    public InputField p2Health;
    public InputField p2Strength;
    public InputField p2Defense;
    public InputField p2Speed;
    public InputField p2Level;
    public RawImage player2;

    public InputField p3Name;
    public InputField p3Health;
    public InputField p3Strength;
    public InputField p3Defense;
    public InputField p3Speed;
    public InputField p3Level;
    public RawImage player3;

    public Text player1Name;
    public Text player2Name;
    public Text player3Name;
    public RawImage p1;
    public RawImage p2;
    public RawImage p3;

    public Text enemy1Name;
    public Text enemy2Name;
    public Text enemy3Name;
    public RawImage e1;
    public RawImage e2;
    public RawImage e3;

    // Use this for initialization
    void Start ()
    {
        BattleReadyParty = new List<Unit>();
        imageList = GetComponent<ImagesScript>();

        gameCanvas.enabled = true;
        generatePartyCanvas.enabled = false;
        battleCanvas.enabled = false;
        PlayButton.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void newGame()
    {
        gameCanvas.enabled = false;
        generatePartyCanvas.enabled = true;
    }

    public void GenerateParty()
    {
        PlayButton.enabled = true;
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

    private void RandomizeAllParties(List<Unit> p, List<Unit> e)
    {
        if (BattleReadyParty.Count >= 1)
        {
            BattleReadyParty.RemoveRange(0, BattleReadyParty.Count);
        }

        //Create random class instance
        System.Random r = new System.Random();
        //call Next() 3 times giving random selection for party members
        int p1 = r.Next(0, p.Count - 1);
        int p2 = r.Next(0, p.Count - 1);
        int p3 = r.Next(0, p.Count - 1);

        while (p1 == p2)
        {
            p2 = r.Next(0, p.Count - 1);
        }

        while (p2 == p3)
        {
            p3 = r.Next(0, p.Count - 1);
        }

        while (p3 == p1)
        {
            p1 = r.Next(0, p.Count - 1);

            while (p1 == p2)
            {
                p1 = r.Next(0, p.Count - 1);
            }
        }

        p1Name.text = p[p1].Name;
        player1Name.text = p[p1].Name;
        p1Health.text = p[p1].Health.ToString();
        p1Strength.text = p[p1].Strength.ToString();
        p1Defense.text = p[p1].Defense.ToString();
        p1Speed.text = p[p1].Speed.ToString();
        p1Level.text = p[p1].Level.ToString();

        BattleReadyParty.Add(p[p1]);

        p2Name.text = p[p2].Name;
        player2Name.text = p[p2].Name;
        p2Health.text = p[p2].Health.ToString();
        p2Strength.text = p[p2].Strength.ToString();
        p2Defense.text = p[p2].Defense.ToString();
        p2Speed.text = p[p2].Speed.ToString();
        p2Level.text = p[p2].Level.ToString();

        BattleReadyParty.Add(p[p2]);

        p3Name.text = p[p3].Name;
        player3Name.text = p[p3].Name;
        p3Health.text = p[p3].Health.ToString();
        p3Strength.text = p[p3].Strength.ToString();
        p3Defense.text = p[p3].Defense.ToString();
        p3Speed.text = p[p3].Speed.ToString();
        p3Level.text = p[p3].Level.ToString();

        BattleReadyParty.Add(p[p3]);

        setImages(BattleReadyParty);

        System.Random a = new System.Random();

        int e1 = a.Next(0, e.Count - 1);
        int e2 = a.Next(0, e.Count - 1);
        int e3 = a.Next(0, e.Count - 1);


        while (e1 == e2)
        {
            e2 = a.Next(0, e.Count - 1);
        }

        while (e2 == e3)
        {
            e3 = a.Next(0, e.Count - 1);
        }

        while (e3 == e1)
        {
            e1 = a.Next(0, e.Count - 1);

            while (e1 == e2)
            {
                e1 = a.Next(0, e.Count - 1);
            }
        }

        BattleReadyParty.Add(e[e1]);
        BattleReadyParty.Add(e[e2]);
        BattleReadyParty.Add(e[e3]);

    }

    public void loadParty()
    {
        FileIOS File = new FileIOS();
        Party Team = new Party();

        if (BattleReadyParty.Count >= 1)
        {
            BattleReadyParty.RemoveRange(0, BattleReadyParty.Count);
        }

        string victoryParty = EditorUtility.OpenFilePanel("Open File", Application.dataPath + "/GameData/VictoryParty", "xml");
        Team = File.Deserialize<Party>(victoryParty);

        p1Name.text = Team.units[0].Name;
        player1Name.text = Team.units[0].Name;
        p1Health.text = Team.units[0].Health.ToString();
        p1Strength.text = Team.units[0].Strength.ToString();
        p1Defense.text = Team.units[0].Defense.ToString();
        p1Speed.text = Team.units[0].Speed.ToString();
        p1Level.text = Team.units[0].Level.ToString();

        BattleReadyParty.Add(Team.units[0]);

        p2Name.text = Team.units[1].Name;
        player2Name.text = Team.units[1].Name;
        p2Health.text = Team.units[1].Health.ToString();
        p2Strength.text = Team.units[1].Strength.ToString();
        p2Defense.text = Team.units[1].Defense.ToString();
        p2Speed.text = Team.units[1].Speed.ToString();
        p2Level.text = Team.units[1].Level.ToString();

        BattleReadyParty.Add(Team.units[1]);

        p3Name.text = Team.units[2].Name;
        player3Name.text = Team.units[2].Name;
        p3Health.text = Team.units[2].Health.ToString();
        p3Strength.text = Team.units[2].Strength.ToString();
        p3Defense.text = Team.units[2].Defense.ToString();
        p3Speed.text = Team.units[2].Speed.ToString();
        p3Level.text = Team.units[2].Level.ToString();

        BattleReadyParty.Add(Team.units[2]);

        setImages(BattleReadyParty);

        Unit TwoFaced = new Unit("2Faced", 100, 20, 15, 5, 25, "Enemy");
        Unit AncientDragon = new Unit("Ancient Dragon", 200, 30, 12, 4, 100, "Enemy");
        Unit Ghost = new Unit("Ghost", 80, 20, 15, 5, 30, "Enemy");
        Unit IceGolem = new Unit("Ice Golem", 150, 25, 15, 5, 35, "Enemy");
        Unit Zuu = new Unit("Zuu", 120, 15, 10, 5, 20, "Enemy");
        Unit ToxicFrog = new Unit("Toxic Frog", 180, 22, 12, 5, 30, "Enemy");
        Unit DeathClaw = new Unit("Death Claw", 140, 25, 18, 7, 50, "Enemy");
        Unit MasterTonberry = new Unit("Master Tonberry", 170, 20, 15, 5, 50, "Enemy");
        Unit Behemoth = new Unit("Behemoth", 200, 35, 14, 4, 100, "Enemy");

        List<Unit> e = new List<Unit>();

        e.Add(TwoFaced);
        e.Add(AncientDragon);
        e.Add(Ghost);
        e.Add(IceGolem);
        e.Add(Zuu);
        e.Add(ToxicFrog);
        e.Add(DeathClaw);
        e.Add(MasterTonberry);
        e.Add(Behemoth);

        System.Random a = new System.Random();

        int e1 = a.Next(0, e.Count - 1);
        int e2 = a.Next(0, e.Count - 1);
        int e3 = a.Next(0, e.Count - 1);

        while (e1 == e2)
        {
            e2 = a.Next(0, e.Count - 1);
        }

        while (e2 == e3)
        {
            e3 = a.Next(0, e.Count - 1);
        }

        while (e3 == e1)
        {
            e1 = a.Next(0, e.Count - 1);

            while (e1 == e2)
            {
                e1 = a.Next(0, e.Count - 1);
            }
        }

        BattleReadyParty.Add(e[e1]);
        BattleReadyParty.Add(e[e2]);
        BattleReadyParty.Add(e[e3]);

        PlayButton.enabled = true;
    }

    public void LoadedGameImages(List<Unit> units)
    {
        for (int i = 0; i < units.Count; i++)
        {
            //Player Images
            if (units[i].Name == player1Name.text)
            {
                switch (units[i].Name)
                {
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
            if (units[i].Name == player2Name.text)
            {
                switch (units[i].Name)
                {
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

            if (units[i].Name == player3Name.text)
            {
                switch (units[i].Name)
                {
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

            //Enemy Images
                    if (units[i].Name == enemy1Name.text)
            {
                switch (units[i].Name)
                {
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
            if (units[i].Name == enemy2Name.text)
            {
                switch (units[i].Name)
                {
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
            if (units[i].Name == enemy3Name.text)
            {
                switch (units[i].Name)
                {
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
    
    public void setImages(List<Unit> units)
    {
        for (int i = 0; i < units.Count; i++)
        {
            //Player Images
            if (units[i].Name == player1Name.text)
            {
                switch (units[i].Name)
                {
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
            if (units[i].Name == player2Name.text)
            {
                switch (units[i].Name)
                {
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

            if (units[i].Name == player3Name.text)
            {
                switch (units[i].Name)
                {
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

            //Enemy Images
            if (units[i].Name == enemy1Name.text)
            {
                switch (units[i].Name)
                {
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
            if (units[i].Name == enemy2Name.text)
            {
                switch (units[i].Name)
                {
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
            if (units[i].Name == enemy3Name.text)
            {
                switch (units[i].Name)
                {
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
