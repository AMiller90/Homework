using System;
using System.Collections.Generic;
//Namespace for using xml serilizer and deserilaizer
using System.Xml.Serialization;
//Namespace for using the FileStream
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Adgp_125_Assessment_WinForm
{//public class used for forms
    public partial class Form1 : Form
    {//Create an instance of the FileIO class
        FileIO _Save = new FileIO();
        //Create a Form2 Object
        Form2 BattleScene;
        //Create a public reference to the GameManager singleton object
        public GameManager manager = GameManager.instance;
        //Create a public empty unit object
        public Unit u = new Unit();
        //Create a public List<Unit> for enemy units
        public List<Unit> Enemies = new List<Unit>();
        //Create a public List<Unit> for all units ready for battle
        public List<Unit> BattleReadyParty = new List<Unit>();
        //public string variable used for player 1 name in party
        public string player1name;
        //public string variable used for player 2 name in party
        public string player2name;
        //public string variable used for player 3 name in party
        public string player3name;
        //public string variable used for enemy 1 name in party
        public string enemy1name;
        //public string variable used for enemy 2 name in party
        public string enemy2name;
        //public string variable used for enemy 3 name in party
        public string enemy3name;
        //public string used to store the deserialized state of the machine
        public string deserializedState;
        //public int use to store the current unit index that was deserialized 
        public int currentUnitIndex = 0;
        //private string variable used to store the fileName the user wishes to name the save party file
        private string fileName;
        //public constructor
        public Form1()
        {//Initialize form
            InitializeComponent();
            //Set instance of a new form with this form passed as a parameter
            BattleScene = new Form2(this);
        }

        //Function used to generate a random party
        private void GenerateParty_Button_Click(object sender, EventArgs e)
        {//Enable the save button so party can be saved
            SaveButton.Enabled = true;
            //Create a new list to store all of the objects into
            List<Unit> NewParty = CreateObjects();
            //Create List<Unit> of player units
            List<Unit> players = new List<Unit>();

            //Loop through the party 
            foreach (Unit i in NewParty)
            {//Check if current unit is a player type
                if (i.Type == "Player")
                {//If true then add to player party
                    players.Add(i);
                }
                //Check if current unit is an enemy
                if (i.Type == "Enemy")
                {//If true then add to enemy party
                    Enemies.Add(i);
                }
            }
            //Call RandomizeAllParties function with the player list and Enemies list passed in a parameters
            RandomizeAllParties(players, Enemies);



        }
        
        //Event function activated on Check box changed
        private void LockInPartyCheckBox_CheckedChanged(object sender, EventArgs e)
        {//If the check box is checked
            if(LockInPartyCheckBox.Checked == true)
            {//Create a Message box (Ask user if party is good, Confirm - Title of message box, Displaye yes no buttons)
                DialogResult = MessageBox.Show("Is this Party good?\n", "Confirm", MessageBoxButtons.YesNo);
                //Yes button is clicked
                if (DialogResult == DialogResult.Yes)
                {//Set current form invisible
                    this.Visible = false;
                    //Show the new form
                    BattleScene.ShowDialog();
                    
                }
                //If the user clicks no button
                else  
                {//Set the Check box to false
                    LockInPartyCheckBox.Checked = false;
                }
            }
           
        }

        //Create Possible Players
        private List<Unit> CreateObjects()
        {   //Create a new list for holding all the created unit objects
            List<Unit> AllObjects = new List<Unit>();

            //Create all "player" unit objects
            Unit Cloud = new Unit("Cloud", 150, 12, 12, 6, 0,"Player");
            Unit Barret = new Unit("Barret", 220, 15, 13, 5, 0,"Player");
            Unit Tifa = new Unit("Tifa", 215, 11, 11, 7, 0,"Player");
            Unit Aerith = new Unit("Aerith", 170, 10, 11, 5, 0, "Player");
            Unit RedXIII = new Unit("Red XIII", 220, 10, 12, 10, 0, "Player");
            Unit Cait = new Unit("Cait Sith", 220, 10, 11, 5, 0, "Player");
            Unit Cid = new Unit("Cid", 220, 12, 12, 6, 0, "Player");
            Unit Yuffie = new Unit("Yuffie", 150, 10, 10, 8, 0, "Player");
            Unit Vincent = new Unit("Vincent", 170, 9, 10, 5, 0, "Player");

            //Create all "enemy" unit objects
            Unit TwoFaced = new Unit("2Faced", 100, 20, 15, 5, 25, "Enemy");
            Unit AncientDragon = new Unit("Ancient Dragon", 200, 30, 12, 4, 100, "Enemy");
            Unit Ghost = new Unit("Ghost", 80, 20, 15, 5, 30, "Enemy");
            Unit IceGolem = new Unit("Ice Golem", 150, 25, 15, 5, 35, "Enemy");
            Unit Zuu = new Unit("Zuu", 120, 15, 10, 5, 20, "Enemy");
            Unit ToxicFrog = new Unit("Toxic Frog", 180, 22, 12, 5, 30, "Enemy");
            Unit DeathClaw = new Unit("Death Claw", 140, 25, 18, 7, 50, "Enemy");
            Unit MasterTonberry = new Unit("Master Tonberry", 170, 20, 15, 5, 50, "Enemy");
            Unit Behemoth = new Unit("Behemoth", 200, 35, 14, 4, 100, "Enemy");

            //Add all the "player" unit objects to the list
            AllObjects.Add(Cloud);
            AllObjects.Add(Barret);
            AllObjects.Add(Tifa);
            AllObjects.Add(Aerith);
            AllObjects.Add(RedXIII);
            AllObjects.Add(Cait);
            AllObjects.Add(Cid);
            AllObjects.Add(Yuffie);
            AllObjects.Add(Vincent);

            //Add all the "enemy" unit objects to the list
            AllObjects.Add(TwoFaced);
            AllObjects.Add(AncientDragon);
            AllObjects.Add(Ghost);
            AllObjects.Add(IceGolem);
            AllObjects.Add(Zuu);
            AllObjects.Add(ToxicFrog);
            AllObjects.Add(DeathClaw);
            AllObjects.Add(MasterTonberry);
            AllObjects.Add(Behemoth);

            //Return the populated list 
            return AllObjects;
        }

          //Function that randomizes both the player and enemy parties
        private void RandomizeAllParties(List<Unit> p, List <Unit> e)
     {      //Create a new list of unit
            List<Unit> empty = new List<Unit>();
            //Remove all elements of the current BattleReadyParty list
            BattleReadyParty.RemoveRange(0, BattleReadyParty.Count);

     
            //Create random class instance
            Random r = new Random();

            //call Next() 3 times giving random selection for party members
            int p1 = r.Next(0, p.Count - 1);
            int p2 = r.Next(0, p.Count - 1);
            int p3 = r.Next(0, p.Count - 1);

            //while p1 is equal to p2
            while (p1 == p2)
            {//randomize p2
                p2 = r.Next(0, p.Count - 1);
            }
             
            //While p1 is equal to p3
            while(p1 == p3)
            {//Randomize p3
                p3 = r.Next(0, p.Count - 1);
            }

            //If p1 is not equal to p2 and p1 is not equal to p3
            if (p1 != p2 && p1 != p3)
            {//Set the P1NameBox.Text to the units name in the player party at the specified index
                P1NameBox.Text = p[p1].Name;
                //Set the Player1name to the units name in the player party at the specified index
                player1name = p[p1].Name;
                //Set the P1HealthBox.Text to the units health in the player party at the specified index
                P1HealthBox.Text = p[p1].Health.ToString();
                //Set the P1StrengthBox.Text to the units strength in the player party at the specified index
                P1StrengthBox.Text = p[p1].Strength.ToString();
                //Set the P1DefenseBox.Text to the units defense in the player party at the specified index
                P1DefenseBox.Text = p[p1].Defense.ToString();
                //Set the P1SpeedBox.Text to the units speed in the player party at the specified index
                P1SpeedBox.Text = p[p1].Speed.ToString();
                //Set the P1LevelBox.Text to the units level in the player party at the specified index
                P1LevelBox.Text = p[p1].Level.ToString();
                //Add the specified unit to the BattlePartyReady list
                BattleReadyParty.Add(p[p1]);
                
            }
            
            //while p2 is equal to p1
            while(p2 == p1)
            {//Randomize p2
                p2 = r.Next(0, p.Count - 1);
            }
            //while p2 is equal to p3
            while(p2 == p3)
            {//Randomize p3
                p3 = r.Next(0, p.Count - 1);
            }
            //If p2 is not equal to p3 and p2 is not equal to p1
            if (p2 != p3 && p2 != p1)
            {//Set the P2NameBox.Text to the units name in the player party at the specified index
                P2NameBox.Text = p[p2].Name;
                //Set the Player2name to the units name in the player party at the specified index
                player2name = p[p2].Name;
                //Set the P2HealthBox.Text to the units health in the player party at the specified index
                P2HealthBox.Text = p[p2].Health.ToString();
                //Set the P2StrengthBox.Text to the units strength in the player party at the specified index
                P2StrengthBox.Text = p[p2].Strength.ToString();
                //Set the P2DefenseBox.Text to the units defense in the player party at the specified index
                P2DefenseBox.Text = p[p2].Defense.ToString();
                //Set the P2SpeedBox.Text to the units speed in the player party at the specified index
                P2SpeedBox.Text = p[p2].Speed.ToString();
                //Set the P2LevelBox.Text to the units level in the player party at the specified index
                P2LevelBox.Text = p[p2].Level.ToString();
                //Add the specified unit to the BattlePartyReady list
                BattleReadyParty.Add(p[p2]);
            }

            //while p3 is equal to p1
            while(p3 == p1)
            {//Randomize p3
                p3 = r.Next(0, p.Count - 1);
                //While p3 is equal to p2
                while (p3 == p2)
                {//Randomize p3
                    p3 = r.Next(0, p.Count - 1);
                }
            }
            
            //If p3 is not equal to p2 and p3 is not equal to p1
            if (p3 != p2 && p3 != p1)
            {//Set the P3NameBox.Text to the units name in the player party at the specified index
                P3NameBox.Text = p[p3].Name;
                //Set the player3name to the units name in the player party at the specified index
                player3name = p[p3].Name;
                //Set the P3HealthBox.Text to the units health in the player party at the specified index
                P3HealthBox.Text = p[p3].Health.ToString();
                //Set the P3StrengthBox.Text to the units strength in the player party at the specified index
                P3StrengthBox.Text = p[p3].Strength.ToString();
                //Set the P3DefenseBox.Text to the units defense in the player party at the specified index
                P3DefenseBox.Text = p[p3].Defense.ToString();
                //Set the P2SpeedBox.Text to the units speed in the player party at the specified index
                P3SpeedBox.Text = p[p3].Speed.ToString();
                //Set the P3LevelBox.Text to the units level in the player party at the specified index
                P3LevelBox.Text = p[p3].Level.ToString();
                //Add the specified unit to the BattlePartyReady list
                BattleReadyParty.Add(p[p3]);
            }
            //Call previewImages function to set the images of the current players in the BattlePartyReady list
            previewImages(BattleReadyParty);

            //Create an instance of the random object
            Random a = new Random();

            //call Next() 3 times giving random selection for enemy members
            int e1 = a.Next(0, e.Count - 1);
            int e2 = a.Next(0, e.Count - 1);
            int e3 = a.Next(0, e.Count - 1);
           
            //while e1 is equal to e2
            while(e1 == e2)
            {//Randomize e2
                e2 = a.Next(0, e.Count - 1);
            }
            //while e2 is equal to e3
            while(e2 == e3)
            {//Randomize e3 
                e3 = a.Next(0, e.Count - 1);
            }
            //while e3 is equal to e1
            while(e3 == e1)
            {//Randomize e1
                e1 = a.Next(0, e.Count - 1);
                //while e1 is equal to e2
                while (e1 == e2)
                {//Randomize e1
                    e1 = a.Next(0, e.Count - 1);

                }
            }
            //Add the specified unit to the BattlePartyReady list
            BattleReadyParty.Add(e[e1]);
            //Add the specified unit to the BattlePartyReady list
            BattleReadyParty.Add(e[e2]);
            //Add the specified unit to the BattlePartyReady list
            BattleReadyParty.Add(e[e3]);

            
        }
        
        //Function called on event of form1 loading
        private void Form1_Load(object sender, EventArgs e)
        {//Set the saveFileName box visibility to false
            saveFileName.Visible = false;
            //Create a handler delegate and store a function in it 
            Handler loadHandler = BattleScene.LoadGame;
            //Create a handler delegate and store a function in it
            Handler searchHandler = BattleScene.SearchPhase;
            //Create a handler delegate and store a function in it
            Handler battleHandler = BattleScene.BattlePhase;
            //Create a handler delegate and store a function in it
            Handler playerturnHandler = BattleScene.PlayerTurn;
            //Create a handler delegate and store a function in it
            Handler enemyturnHandler = BattleScene.EnemyTurn;
            //Create a handler delegate and store a function in it
            Handler exitHandler = BattleScene.ExitPhase;
            //Create a handler delegate and store a function in it
            Handler startHandler = BattleScene.refer.StartPhase;

            //reference the FSM in the manager class and add a new state to the FSM(state, function)
            manager.fsm.State(e_STATES.START, startHandler);
            //Add new state(Search, searchHandler). searchHandler function will be called when search state is current state
            manager.fsm.State(e_STATES.SEARCH, searchHandler);
            //Add new state(Battle, battleHandler). battleHandler function will be called when battle state is current state
            manager.fsm.State(e_STATES.BATTLE, battleHandler);
            //Add new state(Playerturn, playerturnHandler). playerturnHandler function will be called when playerturn state is  
            //current state
            manager.fsm.State(e_STATES.PLAYERTURN, playerturnHandler);
             //Add new state(Enemyturn, enemyturnHandler). enemyturnHandler function will be called when enemyturn state is  
            //current state
            manager.fsm.State(e_STATES.ENEMYTURN, enemyturnHandler);
            //Add new state(Exit, exitHandler). exitHandler function will be called when exit state is current state
            manager.fsm.State(e_STATES.EXIT, exitHandler);

            //Add a new tranisition to the FSM. (From state, to state, string that gives command to transition)
            manager.fsm.AddTransition(e_STATES.INIT, e_STATES.START, "auto");
            manager.fsm.AddTransition(e_STATES.START, e_STATES.SEARCH, "search");
            manager.fsm.AddTransition(e_STATES.START, e_STATES.EXIT, "exit");
            manager.fsm.AddTransition(e_STATES.SEARCH, e_STATES.PLAYERTURN, "PLAYERTURN");
            manager.fsm.AddTransition(e_STATES.SEARCH, e_STATES.ENEMYTURN, "ENEMYTURN");
            manager.fsm.AddTransition(e_STATES.PLAYERTURN, e_STATES.BATTLE, "battle");
            manager.fsm.AddTransition(e_STATES.ENEMYTURN, e_STATES.BATTLE, "battle");
            manager.fsm.AddTransition(e_STATES.BATTLE, e_STATES.PLAYERTURN, "battletoplayer");
            manager.fsm.AddTransition(e_STATES.BATTLE, e_STATES.ENEMYTURN, "battletoenemy");
            manager.fsm.AddTransition(e_STATES.PLAYERTURN, e_STATES.START, "start");
            manager.fsm.AddTransition(e_STATES.ENEMYTURN, e_STATES.START, "start");
            //Call feed function with "auto" passed into transition from init state to start state
            manager.fsm.Feed("auto");

            //Set the textBox1.Text to the name of the currenstate as a string
            textBox1.Text = manager.fsm.currentState.name.ToString();

        }

        //When the save button is clicked
        private void SaveButton_Click(object sender, EventArgs e)
        {//saveFileName box becomes visible 
            saveFileName.Visible = true;

         
        }

        //Function activated when the load party button is clicked
        private void LoadButton_Click(object sender, EventArgs e)
        {//Create an empty party object
            Party loadedunits;
            //Create a variable storing a directory
            string path = @"..\Saved Parties";
            //Create an instance of an OpenFileDialog
            OpenFileDialog DialogWindow = new OpenFileDialog();
            //If DialogWindow Initial Directory is not equal to the path variable
            if(DialogWindow.InitialDirectory != path)
            {//Set the directory to the path variable
                DialogWindow.InitialDirectory = path;
            }
            //Set file type choices to appear
            DialogWindow.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //Sets filter selected
            DialogWindow.FilterIndex = 2;
            //If the Ok button is clicked int the DialogWindow
            if (DialogWindow.ShowDialog() == DialogResult.OK)
            {//Store the chosen file selected by the user into this string variable
                string chosenFile = DialogWindow.FileName;
                //Deserialize the chosen file as a Party Object and store into loadedunits variable
                loadedunits = _Save.Deserialize<Party>(chosenFile);
                //Set the P1NameBox.Text to the units name in the loadedunits party at the specified index
                P1NameBox.Text = loadedunits.units[0].Name;
                //Set the player1name to the units name in the loadedunits party at the specified index
                player1name = loadedunits.units[0].Name;
                //Set the P1HealthBox.Text to the units health in the loadedunits party at the specified index
                P1HealthBox.Text = loadedunits.units[0].Health.ToString();
                //Set the P1strengthBox.Text to the units strength in the loadedunits party at the specified index
                P1StrengthBox.Text = loadedunits.units[0].Strength.ToString();
                //Set the P1SpeedBox.Text to the units speed in the loadedunits party at the specified index
                P1SpeedBox.Text = loadedunits.units[0].Speed.ToString();
                //Set the P1DefenseBox.Text to the units defense in the loadedunits party at the specified index
                P1DefenseBox.Text = loadedunits.units[0].Defense.ToString();
                //Set the P1LevelBox.Text to the units level in the loadedunits party at the specified index
                P1LevelBox.Text = loadedunits.units[0].Level.ToString();

                //Set the P2NameBox.Text to the units name in the loadedunits party at the specified index
                P2NameBox.Text = loadedunits.units[1].Name;
                //Set the player2name to the units name in the loadedunits party at the specified index
                player2name = loadedunits.units[1].Name;
                //Set the P2HealthBox.Text to the units health in the loadedunits party at the specified index
                P2HealthBox.Text = loadedunits.units[1].Health.ToString();
                //Set the P2StrengthBox.Text to the units strength in the loadedunits party at the specified index
                P2StrengthBox.Text = loadedunits.units[1].Strength.ToString();
                //Set the P2SpeedBox.Text to the units speed in the loadedunits party at the specified index
                P2SpeedBox.Text = loadedunits.units[1].Speed.ToString();
                //Set the P2DefenseBox.Text to the units defense in the loadedunits party at the specified index
                P2DefenseBox.Text = loadedunits.units[1].Defense.ToString();
                //Set the P2LevelBox.Text to the units level in the loadedunits party at the specified index
                P2LevelBox.Text = loadedunits.units[1].Level.ToString();

                //Set the P3NameBox.Text to the units name in the loadedunits party at the specified index
                P3NameBox.Text = loadedunits.units[2].Name;
                //Set the player3name to the units name in the loadedunits party at the specified index
                player3name = loadedunits.units[2].Name;
                //Set the P3HealthBox.Text to the units health in the loadedunits party at the specified index
                P3HealthBox.Text = loadedunits.units[2].Health.ToString();
                //Set the P3StrengthBox.Text to the units strength in the loadedunits party at the specified index
                P3StrengthBox.Text = loadedunits.units[2].Strength.ToString();
                //Set the P3SpeedBox.Text to the units speed in the loadedunits party at the specified index
                P3SpeedBox.Text = loadedunits.units[2].Speed.ToString();
                //Set the P3DefenseBox.Text to the units defense in the loadedunits party at the specified index
                P3DefenseBox.Text = loadedunits.units[2].Defense.ToString();
                //Set the P3LevelBox.Text to the units level in the loadedunits party at the specified index
                P3LevelBox.Text = loadedunits.units[2].Level.ToString();

                //If BattleReadyParty.Count is greater than or equal to 1
                if (BattleReadyParty.Count >= 1)
                {//Remove all elements in the list
                    BattleReadyParty.RemoveRange(0, BattleReadyParty.Count);
                }
                
                //Foreach unit in the loaddedunits.units list
                foreach (Unit i in loadedunits.units)
                {//Add the unit to the BattleReadyParty
                    BattleReadyParty.Add(i);
                }
                //Create an empty list
                List<Unit> tempParty = new List<Unit>();

                //Store the returned list from the CreateObjects function into the list
                tempParty = CreateObjects();

                //Foreach unit in the new list
                foreach(Unit i in tempParty)
                {//If the type of the unit is Enemy
                    if(i.Type == "Enemy")
                    {//Add the unit to the Enemies List
                        Enemies.Add(i);
                    }
                    
                }
                //Create instance of Random Object
                Random a = new Random();

                //call Next() 3 times giving random selection for enemy members
                int e1 = a.Next(0, Enemies.Count);
                int e2 = a.Next(0, Enemies.Count);
                int e3 = a.Next(0, Enemies.Count);

                //while e1 is equal to e2
                while (e1 == e2)
                {//Randomize e2
                    e2 = a.Next(0, Enemies.Count - 1);
                }
                //while e2 is equal to e3
                while (e2 == e3)
                {//Randomize e3 
                    e3 = a.Next(0, Enemies.Count - 1);
                }
                //while e3 is equal to e1
                while (e3 == e1)
                {//Randomize e1
                    e1 = a.Next(0, Enemies.Count - 1);
                    //while e1 is equal to e2
                    while (e1 == e2)
                    {//Randomize e1
                        e1 = a.Next(0, Enemies.Count - 1);

                    }
                }
                //Set enemy1name to the name of the object at the given index
                enemy1name = Enemies[e1].Name;
                //Set enemy2name to the name of the object at the given index
                enemy2name = Enemies[e2].Name;
                //Set enemy3name to the name of the object at the given index
                enemy3name = Enemies[e3].Name;

                //Add the specified unit to the BattlePartyReady list
                BattleReadyParty.Add(Enemies[e1]);
                //Add the specified unit to the BattlePartyReady list
                BattleReadyParty.Add(Enemies[e2]);
                //Add the specified unit to the BattlePartyReady list
                BattleReadyParty.Add(Enemies[e3]);
                //Set images for the units in the party list
                previewImages(loadedunits.units);
            }

        }

        //Function used for getting the images of the loaded in Party
        private void previewImages(List<Unit> units)
        {//Loop through the number of units in the list
            for (int i = 0; i < units.Count; i++)
            {//If the unit at the current indexes name is the same as the P1NameBox.Text
                //Player Images
                if (units[i].Name == P1NameBox.Text)
                {//Look For the Name in this statement
                    switch (units[i].Name)
                    {//If the name is here in a case then set the pictureBox1.Image to the proper picture
                        case "Cloud":
                            pictureBox1.Image = Properties.Resources.Cloud;
                            break;
                        case "Barret":
                            pictureBox1.Image = Properties.Resources.Barrett;
                            break;
                        case "Cait Sith":
                            pictureBox1.Image = Properties.Resources.Cait_Sith;
                            break;
                        case "Aerith":
                            pictureBox1.Image = Properties.Resources.Aerith;
                            break;
                        case "Yuffie":
                            pictureBox1.Image = Properties.Resources.Yuffie;
                            break;
                        case "Vincent":
                            pictureBox1.Image = Properties.Resources.Vincent;
                            break;
                        case "Cid":
                            pictureBox1.Image = Properties.Resources.Cid;
                            break;
                        case "Red XIII":
                            pictureBox1.Image = Properties.Resources.Red_XIII;
                            break;
                        case "Tifa":
                            pictureBox1.Image = Properties.Resources.Tifa;
                            break;
                        default:
                            break;
                    }
                }
                //If the unit at the current indexes name is the same as the P2NameBox.Text
                if (units[i].Name == P2NameBox.Text)
                {//Look For the Name in this statement
                    switch (units[i].Name)
                    {//If the name is here in a case then set the pictureBox2.Image to the proper picture
                        case "Cloud":
                            pictureBox2.Image = Properties.Resources.Cloud;
                            break;
                        case "Barret":
                            pictureBox2.Image = Properties.Resources.Barrett;
                            break;
                        case "Cait Sith":
                            pictureBox2.Image = Properties.Resources.Cait_Sith;
                            break;
                        case "Aerith":
                            pictureBox2.Image = Properties.Resources.Aerith;
                            break;
                        case "Yuffie":
                            pictureBox2.Image = Properties.Resources.Yuffie;
                            break;
                        case "Vincent":
                            pictureBox2.Image = Properties.Resources.Vincent;
                            break;
                        case "Cid":
                            pictureBox2.Image = Properties.Resources.Cid;
                            break;
                        case "Red XIII":
                            pictureBox2.Image = Properties.Resources.Red_XIII;
                            break;
                        case "Tifa":
                            pictureBox2.Image = Properties.Resources.Tifa;
                            break;
                        default:
                            break;
                    }

                }
                //If the unit at the current indexes name is the same as the P3NameBox.Text
                if (units[i].Name == P3NameBox.Text)
                {//Look For the Name in this statement
                    switch (units[i].Name)
                    {//If the name is here in a case then set the pictureBox3.Image to the proper picture
                        case "Cloud":
                            pictureBox3.Image = Properties.Resources.Cloud;
                            break;
                        case "Barret":
                            pictureBox3.Image = Properties.Resources.Barrett;
                            break;
                        case "Cait Sith":
                            pictureBox3.Image = Properties.Resources.Cait_Sith;
                            break;
                        case "Aerith":
                            pictureBox3.Image = Properties.Resources.Aerith;
                            break;
                        case "Yuffie":
                            pictureBox3.Image = Properties.Resources.Yuffie;
                            break;
                        case "Vincent":
                            pictureBox3.Image = Properties.Resources.Vincent;
                            break;
                        case "Cid":
                            pictureBox3.Image = Properties.Resources.Cid;
                            break;
                        case "Red XIII":
                            pictureBox3.Image = Properties.Resources.Red_XIII;
                            break;
                        case "Tifa":
                            pictureBox3.Image = Properties.Resources.Tifa;
                            break;
                        default:
                            break;
                    }

                }
            }
        }

        //Function activated when the Load Game Buton is clicked..It loads saved game files
        private void LoadGameButton_Click(object sender, EventArgs e)
        {//Set the new game button to be disabled
            NewGameButton.Enabled = false;
            //Create a new OpenFileDialog 
            OpenFileDialog LoadWindow = new OpenFileDialog();
            //Set a directory as a string to a string variable
            string path = @"..\Game Saves";
            //This allows multiselect for the user
            LoadWindow.Multiselect = true;
            //If the initial directory is not equal to the path variable
            if (LoadWindow.InitialDirectory != path)
            {//Set the directory to the path variable
                LoadWindow.InitialDirectory = path;
            }
            //Set file type choices to appear
            LoadWindow.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //Sets filter selected
            LoadWindow.FilterIndex = 2;
            //Set the current form to not be visible
            Visible = false;
            //Create an instance of a new party
            Party EnemyE = new Party();
            //Create an instance of a new party
            Party PlayerP = new Party();

            //If the ok button is clicked
            if(LoadWindow.ShowDialog() == DialogResult.OK)
            {//Deserilalize the designated file name as a party object and store it into the PlayerP variable
                PlayerP = _Save.Deserialize<Party>(@"..\Game Saves\PartyData.xml");
                //Set the player1name to the given index of the PlayerP.unit
                player1name = PlayerP.units[0].Name;
                //Set the player2name to the given index of the PlayerP.unit
                player2name = PlayerP.units[1].Name;
                //Set the player3name to the given index of the PlayerP.unit
                player3name = PlayerP.units[2].Name;

                //Add the new units to the BattleReadyParty List
                BattleReadyParty.Add(PlayerP.units[0]);
                BattleReadyParty.Add(PlayerP.units[1]);
                BattleReadyParty.Add(PlayerP.units[2]);

                //Deserilalize the designated file name as a party object and store it into the EnemyE variable
                EnemyE = _Save.Deserialize<Party>(@"..\Game Saves\EnemyParty.xml");
                //Set the enemy1name to the given index of the EnemyE.unit
                enemy1name = EnemyE.units[0].Name;
                //Set the enemy1name to the given index of the EnemyE.unit
                enemy2name = EnemyE.units[1].Name;
                //Set the enemy1name to the given index of the EnemyE.unit
                enemy3name = EnemyE.units[2].Name;

                //Add the new units to the BattleReadyParty List
                BattleReadyParty.Add(EnemyE.units[0]);
                BattleReadyParty.Add(EnemyE.units[1]);
                BattleReadyParty.Add(EnemyE.units[2]);

                //Deserilalize the designated file name as an int object and store it into the currentUnitIndex variable
                currentUnitIndex = _Save.Deserialize<int>(@"..\Game Saves\currentAttacker.xml");

                //Deserilalize the designated file name as a string object and store it into the deserializedState variable
                deserializedState = _Save.Deserialize<string>(@"..\Game Saves\GameData.xml");

                //Call the LoadGame() Function
                BattleScene.LoadGame();
                //Show the BattleScene Dialog
                BattleScene.ShowDialog();
            }
            //If the ok button is not clicked
            else
            {//Enable to the New Game Button
                NewGameButton.Enabled = true;
                //Allow the form to be visible
                Visible = true;
            }



        }

        //Function activated when the New Game Button is clicked
        private void NewGameButton_Click(object sender, EventArgs e)
        {//Set the new game button to false
            NewGameButton.Enabled = false;
            //Set the load game button to false
            LoadGameButton.Enabled = false;

            //Enable the LockInPartyCheckBox
            LockInPartyCheckBox.Enabled = true;
            //Enable the GenerateParty Button
            GenerateParty_Button.Enabled = true;
            //Enable the load party button
            LoadButton.Enabled = true;
        }

        //Function called when this text box is clicked on
        private void saveFileName_Click(object sender, EventArgs e)
        {//Set the text in the saveFileName text box to ""
            saveFileName.Text = "";
        }

        //Function called when the text in the box changes
        private void saveFileName_TextChanged(object sender, EventArgs e)
        {//Set the fileName variable to al the data present in the textbox
            fileName = saveFileName.Text;
        }

        //Function called when a key is pressed down while inside the text box
        private void saveFileName_KeyDown(object sender, KeyEventArgs e)
        {//If the key pressed is th Enter key
            if(e.KeyCode == Keys.Enter)
            {//Create an instance of a new party object
                Party party = new Party();
                //Foreach unit in the BattleReadyParty list
                foreach (Unit i in BattleReadyParty)
                {//If the current unit is of type Player
                    if (i.Type == "Player")
                    {//Add the current unit to the list of units in the party object
                        party.units.Add(i);
                    }
                }
                //Serialize the party object and all of its data into a file with the passed in fileName
                _Save.Serialize(fileName, party);
                //Messagebox displays letting the user know the party was saved
                MessageBox.Show("Party Saved!");
                //Set the saveFileName text to "Enter Save File Name Here Then Press Enter:" for the user to see
                saveFileName.Text = "Enter Save File Name Here Then Press Enter:";
                //Set the box to not be visible
                saveFileName.Visible = false;
            }
        }

        //Function called whenever the current state is Start
        public void StartPhase()
        {//Enable this form to be visile
            this.Visible = true;
            //Set the other form to be disabled
            BattleScene.Visible = false;
            //Uncheck the LockInPartyCheckBox
            LockInPartyCheckBox.Checked = false;
            //Disable the LockInPartyCheckBox
            LockInPartyCheckBox.Enabled = false;
            //Enable the NewGameButton
            NewGameButton.Enabled = true;
            //Enable the Load Game Button
            LoadGameButton.Enabled = true;
            //Remoave all elements of the BattleReadyParty list
            BattleReadyParty.RemoveRange(0, BattleReadyParty.Count);
            //Disable the load party button
            LoadButton.Enabled = false;
            //Disable the save button
            SaveButton.Enabled = false;
            //Disable the Generate Party Button
            GenerateParty_Button.Enabled = false;
            //Set the statsText to ""
            manager.statsText = "";
            //Set the pictureBox1 Image to null
            pictureBox1.Image = null;
            //Set the pictureBox2 Image to null
            pictureBox2.Image = null;
            //Set the pictureBox3 Image to null
            pictureBox3.Image = null;

            //If the Enemies list Count is greater than or equal to 1
            if (Enemies.Count >= 1)
            {//Remove all elements in the Enemies List
                Enemies.RemoveRange(0, Enemies.Count);
            }

            //Set the P1NameBox.Text to ""
            P1NameBox.Text = "";
            //Set the Player1name to ""
            player1name = "";
            //Set the P1HealthBox.Text to ""
            P1HealthBox.Text = "";
            //Set the P1StrengthBox.Text to ""
            P1StrengthBox.Text = "";
            //Set the P1DefenseBox.Text to ""
            P1DefenseBox.Text = "";
            //Set the P1SpeedBox.Text to ""
            P1SpeedBox.Text = "";
            //Set the P1LevelBox.Text to ""
            P1LevelBox.Text = "";

            //Set the P2NameBox.Text to ""
            P2NameBox.Text = "";
            //Set the Player2name to ""
            player2name = "";
            //Set the P2HealthBox.Text to ""
            P2HealthBox.Text = "";
            //Set the P2StrengthBox.Text to ""
            P2StrengthBox.Text = "";
            //Set the P2DefenseBox.Text to ""
            P2DefenseBox.Text = "";
            //Set the P2SpeedBox.Text to ""
            P2SpeedBox.Text = "";
            //Set the P2LevelBox.Text to ""
            P2LevelBox.Text = "";

            //Set the P3NameBox.Text to ""
            P3NameBox.Text = "";
            //Set the player3name to ""
            player3name = "";
            //Set the P3HealthBox.Text to ""
            P3HealthBox.Text = "";
            //Set the P3StrengthBox.Text to ""
            P3StrengthBox.Text = "";
            //Set the P3DefenseBox.Text to ""
            P3DefenseBox.Text = "";
            //Set the P2SpeedBox.Text to ""
            P3SpeedBox.Text = "";
            //Set the P3LevelBox.Text to ""
            P3LevelBox.Text = "";
        }

        //Function activated when the Exit Button is clicked
        private void ExitButton_Click(object sender, EventArgs e)
        {//Messagebox will show prompting using if they would like to quit the game
            DialogResult = MessageBox.Show("Are You Sure You Want To Quit?", "Quit Game", MessageBoxButtons.YesNo);
            //If user Clicks Yes
            if(DialogResult == DialogResult.Yes)
            {//State Machine will transition to exit state and quit the game
                manager.fsm.Feed("exit");
            }
            
        }
    }
}
