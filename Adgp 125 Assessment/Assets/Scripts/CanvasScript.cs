using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Adgp125_Assessment_Library;
using System.Collections.Generic;

public class CanvasScript : MonoBehaviour {

    ImagesScript imageList;

    public Canvas gameCanvas;
    public Canvas generatePartyCanvas;
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

    Unit referUnit = new Unit();
    //GameFlow gameFlow;

    // Use this for initialization
    void Start ()
    {
        //gameFlow = GetComponent<GameFlow>();
        imageList = GetComponent<ImagesScript>();
        gameCanvas = gameCanvas.GetComponent<Canvas>();
        generatePartyCanvas = generatePartyCanvas.GetComponent<Canvas>();

        gameCanvas.enabled = true;
        generatePartyCanvas.enabled = false;
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
        //Create random class instance
        //Random r = new Random();
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
        p1Health.text = p[p1].Health.ToString();
        p1Strength.text = p[p1].Strength.ToString();
        p1Defense.text = p[p1].Defense.ToString();
        p1Speed.text = p[p1].Speed.ToString();
        p1Level.text = p[p1].Level.ToString();


        referUnit.Participants.Add(p[p1]);

        p2Name.text = p[p2].Name;
        p2Health.text = p[p2].Health.ToString();
        p2Strength.text = p[p2].Strength.ToString();
        p2Defense.text = p[p2].Defense.ToString();
        p2Speed.text = p[p2].Speed.ToString();
        p2Level.text = p[p2].Level.ToString();

        referUnit.Participants.Add(p[p2]);

        p3Name.text = p[p3].Name;
        p3Health.text = p[p3].Health.ToString();
        p3Strength.text = p[p3].Strength.ToString();
        p3Defense.text = p[p3].Defense.ToString();
        p3Speed.text = p[p3].Speed.ToString();
        p3Level.text = p[p3].Level.ToString();

        referUnit.Participants.Add(p[p3]);

        System.Random a = new System.Random();

        int e1 = a.Next(0, e.Count - 1);
        int e2 = a.Next(0, e.Count - 1);
        int e3 = a.Next(0, e.Count - 1);


        while (e1 == e2)
        {
            e2 = r.Next(0, e.Count - 1);
        }

        while (e2 == e3)
        {
            e3 = r.Next(0, e.Count - 1);
        }

        while (e3 == e1)
        {
            e1 = r.Next(0, e.Count - 1);

            while (e1 == e2)
            {
                e1 = r.Next(0, e.Count - 1);
            }
        }

        referUnit.Participants.Add(e[e1]);
        referUnit.Participants.Add(e[e2]);
        referUnit.Participants.Add(e[e3]);

        setImages(referUnit.Participants);
    }

    private void setImages(List<Unit> units)
    {
        for (int i = 0; i < units.Count; i++)
        {
            //Player Images
            if (units[i].Name == p1Name.text)
            {
                switch (units[i].Name)
                {
                    case "Cloud":
                        player1.texture = imageList.Cloud;
                        break;
                    case "Barret":
                        player1.texture = imageList.Barrett;
                        break;
                    case "Cait Sith":
                        player1.texture = imageList.CaitSith;
                        break;
                    case "Aerith":
                        player1.texture = imageList.Aerith;
                        break;
                    case "Yuffie":
                        player1.texture = imageList.Yuffie;
                        break;
                    case "Vincent":
                        player1.texture = imageList.Vincent;
                        break;
                    case "Cid":
                        player1.texture = imageList.Cid;
                        break;
                    case "Red XIII":
                        player1.texture = imageList.RedXIII;
                        break;
                    case "Tifa":
                        player1.texture = imageList.Tifa;
                        break;
                    default:
                        break;
                }
            }
            if (units[i].Name == p2Name.text)
            {
                switch (units[i].Name)
                {
                    case "Cloud":
                        player2.texture = imageList.Cloud;
                        break;
                    case "Barret":
                        player2.texture = imageList.Barrett;
                        break;
                    case "Cait Sith":
                        player2.texture = imageList.CaitSith;
                        break;
                    case "Aerith":
                        player2.texture = imageList.Aerith;
                        break;
                    case "Yuffie":
                        player2.texture = imageList.Yuffie;
                        break;
                    case "Vincent":
                        player2.texture = imageList.Vincent;
                        break;
                    case "Cid":
                        player2.texture = imageList.Cid;
                        break;
                    case "Red XIII":
                        player2.texture = imageList.RedXIII;
                        break;
                    case "Tifa":
                        player2.texture = imageList.Tifa;
                        break;
                    default:
                        break;
                }
            }

            if (units[i].Name == p3Name.text)
            {
                switch (units[i].Name)
                {
                    case "Cloud":
                        player3.texture = imageList.Cloud;
                        break;
                    case "Barret":
                        player3.texture = imageList.Barrett;
                        break;
                    case "Cait Sith":
                        player3.texture = imageList.CaitSith;
                        break;
                    case "Aerith":
                        player3.texture = imageList.Aerith;
                        break;
                    case "Yuffie":
                        player3.texture = imageList.Yuffie;
                        break;
                    case "Vincent":
                        player3.texture = imageList.Vincent;
                        break;
                    case "Cid":
                        player3.texture = imageList.Cid;
                        break;
                    case "Red XIII":
                        player3.texture = imageList.RedXIII;
                        break;
                    case "Tifa":
                        player3.texture = imageList.Tifa;
                        break;
                    default:
                        break;
                }

            }

            //Enemy Images
            //        if (units[i].Name == Enemy1Label.Text)
            //        {
            //            switch (units[i].Name)
            //            {
            //                case "2Faced":
            //                    e1PictureBox.Image = Properties.Resources._2Faced;
            //                    break;
            //                case "Ice Golem":
            //                    e1PictureBox.Image = Properties.Resources.Ice_Golem;
            //                    break;
            //                case "Ancient Dragon":
            //                    e1PictureBox.Image = Properties.Resources.Ancient_Dragon;
            //                    break;
            //                case "Behemoth":
            //                    e1PictureBox.Image = Properties.Resources.Behemoth;
            //                    break;
            //                case "Death Claw":
            //                    e1PictureBox.Image = Properties.Resources.Death_Claw;
            //                    break;
            //                case "Master Tonberry":
            //                    e1PictureBox.Image = Properties.Resources.Master_Tonberry;
            //                    break;
            //                case "Toxic Frog":
            //                    e1PictureBox.Image = Properties.Resources.Toxic_Frog;
            //                    break;
            //                case "Zuu":
            //                    e1PictureBox.Image = Properties.Resources.Zuu;
            //                    break;
            //                case "Ghost":
            //                    e1PictureBox.Image = Properties.Resources.Ghost;
            //                    break;
            //                default:
            //                    break;
            //            }
            //        }
            //        if (units[i].Name == Enemy2Label.Text)
            //        {
            //            switch (units[i].Name)
            //            {
            //                case "2Faced":
            //                    e2PictureBox.Image = Properties.Resources._2Faced;
            //                    break;
            //                case "Ice Golem":
            //                    e2PictureBox.Image = Properties.Resources.Ice_Golem;
            //                    break;
            //                case "Ancient Dragon":
            //                    e2PictureBox.Image = Properties.Resources.Ancient_Dragon;
            //                    break;
            //                case "Behemoth":
            //                    e2PictureBox.Image = Properties.Resources.Behemoth;
            //                    break;
            //                case "Death Claw":
            //                    e2PictureBox.Image = Properties.Resources.Death_Claw;
            //                    break;
            //                case "Master Tonberry":
            //                    e2PictureBox.Image = Properties.Resources.Master_Tonberry;
            //                    break;
            //                case "Toxic Frog":
            //                    e2PictureBox.Image = Properties.Resources.Toxic_Frog;
            //                    break;
            //                case "Zuu":
            //                    e2PictureBox.Image = Properties.Resources.Zuu;
            //                    break;
            //                case "Ghost":
            //                    e2PictureBox.Image = Properties.Resources.Ghost;
            //                    break;
            //                default:
            //                    break;
            //            }

            //        }
            //        if (units[i].Name == Enemy3Label.Text)
            //        {
            //            switch (units[i].Name)
            //            {
            //                case "2Faced":
            //                    e3PictureBox.Image = Properties.Resources._2Faced;
            //                    break;
            //                case "Ice Golem":
            //                    e3PictureBox.Image = Properties.Resources.Ice_Golem;
            //                    break;
            //                case "Ancient Dragon":
            //                    e3PictureBox.Image = Properties.Resources.Ancient_Dragon;
            //                    break;
            //                case "Behemoth":
            //                    e3PictureBox.Image = Properties.Resources.Behemoth;
            //                    break;
            //                case "Death Claw":
            //                    e3PictureBox.Image = Properties.Resources.Death_Claw;
            //                    break;
            //                case "Master Tonberry":
            //                    e3PictureBox.Image = Properties.Resources.Master_Tonberry;
            //                    break;
            //                case "Toxic Frog":
            //                    e3PictureBox.Image = Properties.Resources.Toxic_Frog;
            //                    break;
            //                case "Zuu":
            //                    e3PictureBox.Image = Properties.Resources.Zuu;
            //                    break;
            //                case "Ghost":
            //                    e3PictureBox.Image = Properties.Resources.Ghost;
            //                    break;
            //                default:
            //                    break;
            //            }

            //        }
            //    }
        }
    }

  
}
