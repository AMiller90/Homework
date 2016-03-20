using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adgp_125_Assessment_WinForm
{
    public partial class Form1 : Form
    {
        public GameManager manager = GameManager.instance;
        public Unit u = new Unit();
        public List<Unit> BattleReadyParty = new List<Unit>();
        public string player1name;
        public string player2name;
        public string player3name;
        public string enemy1name;
        public string enemy2name;
        public string enemy3name;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void GenerateParty_Button_Click(object sender, EventArgs e)
        {
            ////Create empty Unit object
            //Unit p = new Unit();
            ////Create empty Unit object
            //Unit E = new Unit();

            //Create a new list to store all of the objects into
            List<Unit> NewParty = CreateObjects();

            List<Unit> players = new List<Unit>();
            List<Unit> enemies = new List<Unit>();

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
                    enemies.Add(i);
                }
            }

            RandomizeAllParties(players, enemies);



        }

        private void LockInPartyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Is this Party good?\n", "Confirm", MessageBoxButtons.YesNo);

            if (DialogResult == DialogResult.Yes)
            {
                Form2 BattleScene = new Form2(this);
                BattleScene.ShowDialog();

            }
        }

        //Create Possible Players
        private List<Unit> CreateObjects()
        {
            List<Unit> AllObjects = new List<Unit>();

            Unit Cloud = new Unit("Cloud", 150, 12, 12, 6, 0,"Player");
            Unit Barret = new Unit("Barret", 220, 15, 13, 5, 0,"Player");
            Unit Tifa = new Unit("Tifa", 215, 11, 11, 7, 0,"Player");
            Unit Aeris = new Unit("Aeris", 170, 10, 11, 5, 0, "Player");
            Unit RedXIII = new Unit("Red XIII", 220, 10, 12, 10, 0, "Player");
            Unit Cait = new Unit("Cait Sith", 220, 10, 11, 5, 0, "Player");
            Unit Cid = new Unit("Cid", 220, 12, 12, 6, 0, "Player");
            Unit Yuffie = new Unit("Yuffie", 150, 10, 10, 8, 0, "Player");
            Unit Vincent = new Unit("Vincent", 170, 9, 10, 5, 0, "Player");


            Unit TwoFaced = new Unit("2Faced", 100, 20, 15, 5, 25, "Enemy");
            Unit AncientDragon = new Unit("Ancient Dragon", 200, 30, 12, 4, 50, "Enemy");
            Unit Ghost = new Unit("Ghost", 80, 20, 15, 5, 20, "Enemy");
            Unit IceGolem = new Unit("Ice Golem", 150, 25, 15, 5, 35, "Enemy");
            Unit Zuu = new Unit("Zuu", 1200, 15, 10, 5, 20, "Enemy");
            Unit ToxicFrog = new Unit("Toxic Frog", 180, 22, 12, 5, 30, "Enemy");
            Unit DeathClaw = new Unit("Death Claw", 140, 25, 18, 7, 40, "Enemy");
            Unit MasterTonberry = new Unit("Master Tonberry", 170, 20, 15, 5, 50, "Enemy");
            Unit Behemoth = new Unit("Behemoth", 300, 35, 14, 4, 100, "Enemy");

            AllObjects.Add(Cloud);
            AllObjects.Add(Barret);
            AllObjects.Add(Tifa);
            AllObjects.Add(Aeris);
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

            return AllObjects;
        }

        private void RandomizeAllParties(List<Unit> p, List <Unit> e)
     {
            List<Unit> empty = new List<Unit>();
            BattleReadyParty.RemoveRange(0, BattleReadyParty.Count);

            //Unit u = new Unit();
            //Create random class instance
            Random r = new Random();

            //call Next() 3 times giving random selection for party members
            int p1 = r.Next(0, p.Count - 1);
            int p2 = r.Next(0, p.Count - 1);
            int p3 = r.Next(0, p.Count - 1);

            if (p1 != p2 && p1 != p3)
            {
                P1NameBox.Text = p[p1].Name;
                player1name = p[p1].Name;
                P1HealthBox.Text = p[p1].Health.ToString();
                P1StrengthBox.Text = p[p1].Strength.ToString();
                P1DefenseBox.Text = p[p1].Defense.ToString();
                P1SpeedBox.Text = p[p1].Speed.ToString();
                BattleReadyParty.Add(p[p1]);
            }

            if (p2 != p3 && p2 != p1)
            {
                P2NameBox.Text = p[p2].Name;
                player2name = p[p2].Name;
                P2HealthBox.Text = p[p2].Health.ToString();
                P2StrengthBox.Text = p[p2].Strength.ToString();
                P2DefenseBox.Text = p[p2].Defense.ToString();
                P2SpeedBox.Text = p[p2].Speed.ToString();
                BattleReadyParty.Add(p[p2]);
            }

            if (p3 != p2 && p3 != p1)
            {
                P3NameBox.Text = p[p3].Name;
                player3name = p[p3].Name;
                P3HealthBox.Text = p[p3].Health.ToString();
                P3StrengthBox.Text = p[p3].Strength.ToString();
                P3DefenseBox.Text = p[p3].Defense.ToString();
                P3SpeedBox.Text = p[p3].Speed.ToString();
                BattleReadyParty.Add(p[p3]);
            }
           

            Random a = new Random();

            int e1 = a.Next(0, e.Count);
            int e2 = a.Next(0, e.Count);
            int e3 = a.Next(0, e.Count);

            enemy1name = e[e1].Name;
            enemy2name= e[e2].Name;
            enemy3name = e[e3].Name;


            BattleReadyParty.Add(e[e1]);
            BattleReadyParty.Add(e[e2]);
            BattleReadyParty.Add(e[e3]);

        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            manager.fsm.AddStates(e_STATES.INIT);
            manager.fsm.AddStates(e_STATES.START);
            manager.fsm.AddStates(e_STATES.SEARCH);
            manager.fsm.AddStates(e_STATES.BATTLE);
            manager.fsm.AddStates(e_STATES.PLAYERTURN);
            manager.fsm.AddStates(e_STATES.ENEMYTURN);
            manager.fsm.AddStates(e_STATES.EXIT);

            manager.fsm.Addtransition(e_STATES.INIT, e_STATES.START);
            manager.fsm.Addtransition(e_STATES.START, e_STATES.SEARCH);
            manager.fsm.Addtransition(e_STATES.SEARCH, e_STATES.BATTLE);
            manager.fsm.Addtransition(e_STATES.BATTLE, e_STATES.PLAYERTURN);
            manager.fsm.Addtransition(e_STATES.BATTLE, e_STATES.ENEMYTURN);
            manager.fsm.Addtransition(e_STATES.PLAYERTURN, e_STATES.BATTLE);
            manager.fsm.Addtransition(e_STATES.ENEMYTURN, e_STATES.BATTLE);
            manager.fsm.Addtransition(e_STATES.BATTLE, e_STATES.EXIT);


            manager.fsm.ChangeStates(e_STATES.START);

            textBox1.Text = manager.fsm.state.ToString();
        }
    }
}
