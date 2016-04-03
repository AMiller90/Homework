using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
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

            //reference the FSM in the manager class and add a new state to the FSM(state, function)
            manager.fsm.State(e_STATES.START, null);
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
            manager.fsm.AddTransition(e_STATES.SEARCH, e_STATES.PLAYERTURN, "PLAYERTURN");
            manager.fsm.AddTransition(e_STATES.SEARCH, e_STATES.ENEMYTURN, "ENEMYTURN");
            manager.fsm.AddTransition(e_STATES.PLAYERTURN, e_STATES.BATTLE, "battle");
            manager.fsm.AddTransition(e_STATES.ENEMYTURN, e_STATES.BATTLE, "battle");
            manager.fsm.AddTransition(e_STATES.BATTLE, e_STATES.PLAYERTURN, "battletoplayer");
            manager.fsm.AddTransition(e_STATES.BATTLE, e_STATES.ENEMYTURN, "battletoenemy");
            manager.fsm.AddTransition(e_STATES.PLAYERTURN, e_STATES.EXIT, "playertoexit");
            manager.fsm.AddTransition(e_STATES.ENEMYTURN, e_STATES.EXIT, "enemytoexit");
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
        
        private void LoadButton_Click(object sender, EventArgs e)
        {
            
            Party loadedunits;

            OpenFileDialog DialogWindow = new OpenFileDialog();
            string path = @"..\Saved Parties";
            DialogWindow.InitialDirectory = path;
            DialogWindow.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            DialogWindow.FilterIndex = 2;
            DialogWindow.RestoreDirectory = true;

            if (DialogWindow.ShowDialog() == DialogResult.OK)
            {

                string chosenFile = DialogWindow.FileName;
                loadedunits = _Save.Deserialize<Party>(chosenFile);

                P1NameBox.Text = loadedunits.units[0].Name;
                player1name = loadedunits.units[0].Name;
                P1HealthBox.Text = loadedunits.units[0].Health.ToString();
                P1StrengthBox.Text = loadedunits.units[0].Strength.ToString();
                P1SpeedBox.Text = loadedunits.units[0].Speed.ToString();
                P1DefenseBox.Text = loadedunits.units[0].Defense.ToString();
                P1LevelBox.Text = loadedunits.units[0].Level.ToString();

                P2NameBox.Text = loadedunits.units[1].Name;
                player2name = loadedunits.units[1].Name;
                P2HealthBox.Text = loadedunits.units[1].Health.ToString();
                P2StrengthBox.Text = loadedunits.units[1].Strength.ToString();
                P2SpeedBox.Text = loadedunits.units[1].Speed.ToString();
                P2DefenseBox.Text = loadedunits.units[1].Defense.ToString();
                P2LevelBox.Text = loadedunits.units[1].Level.ToString();

                P3NameBox.Text = loadedunits.units[2].Name;
                player3name = loadedunits.units[2].Name;
                P3HealthBox.Text = loadedunits.units[2].Health.ToString();
                P3StrengthBox.Text = loadedunits.units[2].Strength.ToString();
                P3SpeedBox.Text = loadedunits.units[2].Speed.ToString();
                P3DefenseBox.Text = loadedunits.units[2].Defense.ToString();
                P3LevelBox.Text = loadedunits.units[2].Level.ToString();


                if(BattleReadyParty.Count >= 1)
                {
                    BattleReadyParty.RemoveRange(0, BattleReadyParty.Count);
                }
                

                foreach (Unit i in loadedunits.units)
                {
                    BattleReadyParty.Add(i);
                }

                List<Unit> tempParty = new List<Unit>();

                tempParty = CreateObjects();

                foreach(Unit i in tempParty)
                {
                    if(i.Type == "Enemy")
                    {
                        Enemies.Add(i);
                    }
                    
                }
                Random a = new Random();

                int e1 = a.Next(0, Enemies.Count);
                int e2 = a.Next(0, Enemies.Count);
                int e3 = a.Next(0, Enemies.Count);


                while (e1 == e2)
                {
                    e2 = a.Next(0, Enemies.Count - 1);
                }

                while (e2 == e3)
                {
                    e3 = a.Next(0, Enemies.Count - 1);
                }

                while (e3 == e1)
                {
                    e1 = a.Next(0, Enemies.Count - 1);

                    while (e1 == e2)
                    {
                        e1 = a.Next(0, Enemies.Count - 1);

                    }
                }
                enemy1name = Enemies[e1].Name;
                enemy2name = Enemies[e2].Name;
                enemy3name = Enemies[e3].Name;


                BattleReadyParty.Add(Enemies[e1]);
                BattleReadyParty.Add(Enemies[e2]);
                BattleReadyParty.Add(Enemies[e3]);

                previewImages(loadedunits.units);
            }

        }

        private void previewImages(List<Unit> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                //Player Images
                if (units[i].Name == P1NameBox.Text)
                {
                    switch (units[i].Name)
                    {
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
                if (units[i].Name == P2NameBox.Text)
                {
                    switch (units[i].Name)
                    {
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
                if (units[i].Name == P3NameBox.Text)
                {
                    switch (units[i].Name)
                    {
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

        private void LoadGameButton_Click(object sender, EventArgs e)
        {
            NewGameButton.Enabled = false;

            OpenFileDialog LoadWindow = new OpenFileDialog();
            string path = @"..\Game Saves";
            LoadWindow.Multiselect = true;
            LoadWindow.InitialDirectory = path;
            LoadWindow.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            LoadWindow.FilterIndex = 2;
            LoadWindow.RestoreDirectory = true;

            Visible = false;
            Party EnemyE = new Party();
            Party PlayerP = new Party();

            if(LoadWindow.ShowDialog() == DialogResult.OK)
            {
                PlayerP = _Save.Deserialize<Party>(@"..\Game Saves\PartyData.xml");

                player1name = PlayerP.units[0].Name;

                player2name = PlayerP.units[1].Name;
           
                player3name = PlayerP.units[2].Name;

                BattleReadyParty.Add(PlayerP.units[0]);
                BattleReadyParty.Add(PlayerP.units[1]);
                BattleReadyParty.Add(PlayerP.units[2]);

                EnemyE = _Save.Deserialize<Party>(@"..\Game Saves\EnemyParty.xml");

                enemy1name = EnemyE.units[0].Name;

                enemy2name = EnemyE.units[1].Name;

                enemy3name = EnemyE.units[2].Name;

                BattleReadyParty.Add(EnemyE.units[0]);
                BattleReadyParty.Add(EnemyE.units[1]);
                BattleReadyParty.Add(EnemyE.units[2]);

                currentUnitIndex = _Save.Deserialize<int>(@"..\Game Saves\currentAttacker.xml");

                deserializedState  = _Save.Deserialize<string>(@"..\Game Saves\GameData.xml");


                BattleScene.LoadGame();
            }

            BattleScene.ShowDialog();

        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGameButton.Enabled = false;
            LoadGameButton.Enabled = false;

            LockInPartyCheckBox.Enabled = true;
            GenerateParty_Button.Enabled = true;
            LoadButton.Enabled = true;
        }

        private void saveFileName_Click(object sender, EventArgs e)
        {
            saveFileName.Text = "";
        }

        private void saveFileName_TextChanged(object sender, EventArgs e)
        {
            fileName = saveFileName.Text;
        }

        private void saveFileName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Party party = new Party();

                foreach (Unit i in BattleReadyParty)
                {
                    if (i.Type == "Player")
                    {
                        party.units.Add(i);
                    }
                }
                _Save.Serialize(fileName, party);

                MessageBox.Show("Party Saved!");

                saveFileName.Visible = false;
            }
        }
    }
}
