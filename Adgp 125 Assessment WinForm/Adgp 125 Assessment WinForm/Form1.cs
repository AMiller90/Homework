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
            //Create empty player object
            Player p = new Player();
            //Create empty enemy object
            Enemy en = new Enemy();

            //Create a new list to store all of the player and enemy objects into
            List<Unit> NewParty = CreateObjects();

            //Loop through the sorted party 
            foreach (Unit i in NewParty)
            {//Check if current unit is a player
                if (i.Type == "Player")
                {//If true then add to player party
                    p.Party.Add((Player)i);


                }
                //Check if current unit is an enemy
                if (i.Type == "Enemy")
                {//If true then add to enemy party
                    en.EnemyParty.Add((Enemy)i);
                }
            }

            RandomizeAllParties(p.Party, en.EnemyParty);



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

            //Unit a = new Unit();
            List<Unit> AllObjects = new List<Unit>();

            Player Cloud = new Player("Cloud", 150, 12, 12, 6, "Player");
            Player Barret = new Player("Barret", 220, 15, 13, 5, "Player");
            Player Tifa = new Player("Tifa", 215, 11, 11, 7, "Player");
            Player Aeris = new Player("Aeris", 170, 10, 11, 5, "Player");
            Player RedXIII = new Player("Red XIII", 220, 10, 12, 10, "Player");
            Player Cait = new Player("Cait Sith", 220, 10, 11, 5, "Player");
            Player Cid = new Player("Cid", 220, 12, 12, 6, "Player");
            Player Yuffie = new Player("Yuffie", 150, 10, 10, 8, "Player");
            Player Vincent = new Player("Vincent", 170, 9, 10, 5, "Player");


            Enemy TwoFaced = new Enemy("2Faced", 100, 20, 15, 5, 25, "Enemy");
            Enemy AncientDragon = new Enemy("Ancient Dragon", 200, 30, 12, 4, 50, "Enemy");
            Enemy Ghost = new Enemy("Ghost", 80, 20, 15, 5, 20, "Enemy");
            Enemy IceGolem = new Enemy("Ice Golem", 150, 25, 15, 5, 35, "Enemy");
            Enemy Zuu = new Enemy("Zuu", 1200, 15, 10, 5, 20, "Enemy");
            Enemy ToxicFrog = new Enemy("Toxic Frog", 180, 22, 12, 5, 30, "Enemy");
            Enemy DeathClaw = new Enemy("Death Claw", 140, 25, 18, 7, 40, "Enemy");
            Enemy MasterTonberry = new Enemy("Master Tonberry", 170, 20, 15, 5, 50, "Enemy");
            Enemy Behemoth = new Enemy("Behemoth", 300, 35, 14, 4, 100, "Enemy");

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

        private void RandomizeAllParties(List<Player> p, List <Enemy> e)
     {
            
            //Unit u = new Unit();
            //Create random class instance
            Random r = new Random();

            //call Next() 3 times giving random selection for party members
            int p1 = r.Next(0, p.Count);
            int p2 = r.Next(0, p.Count);
            int p3 = r.Next(0, p.Count);


            P1NameBox.Text = p[p1].Name;
            player1name = p[p1].Name;
            P1HealthBox.Text = p[p1].Health.ToString();
            P1StrengthBox.Text = p[p1].Strength.ToString();
            P1DefenseBox.Text = p[p1].Defense.ToString();
            P1SpeedBox.Text = p[p1].Speed.ToString();

            P2NameBox.Text = p[p2].Name;
            player2name = p[p2].Name;
            P2HealthBox.Text = p[p2].Health.ToString();
            P2StrengthBox.Text = p[p2].Strength.ToString();
            P2DefenseBox.Text = p[p2].Defense.ToString();
            P2SpeedBox.Text = p[p2].Speed.ToString();

            P3NameBox.Text = p[p3].Name;
            player3name = p[p3].Name;
            P3HealthBox.Text = p[p3].Health.ToString();
            P3StrengthBox.Text = p[p3].Strength.ToString();
            P3DefenseBox.Text = p[p3].Defense.ToString();
            P3SpeedBox.Text = p[p3].Speed.ToString();

            Random a = new Random();

            int e1 = a.Next(0, e.Count);
            int e2 = a.Next(0, e.Count);
            int e3 = a.Next(0, e.Count);

            enemy1name = e[e1].Name;
            enemy2name= e[e2].Name;
            enemy3name = e[e3].Name;

           
            u.Participants.Add(p[p1]);
            u.Participants.Add(p[p2]);
            u.Participants.Add(p[p3]);

            u.Participants.Add(e[e1]);
            u.Participants.Add(e[e2]);
            u.Participants.Add(e[e3]);


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
