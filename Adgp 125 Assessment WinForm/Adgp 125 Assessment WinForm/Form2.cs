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
    public partial class Form2 : Form
    {
        FileIO _Save = new FileIO();
        
        int index;
        int count;
        List<Unit> playerParty = new List<Unit>();
        List<Unit> enemyParty = new List<Unit>();

        public Form1 refer;

        public Form2(Form1 parent)
        {
            refer = parent;
            parent.Visible = false;

            InitializeComponent();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {

            if (refer.manager.fsm.state == e_STATES.PLAYERTURN)
            {
                index = refer.currentUnitIndex;

                //Battle party sorted by speed to produce attack order 
                refer.u.Participants = refer.manager.sortBySpeed(refer.BattleReadyParty);

                for (int i = 0; i < refer.u.Participants.Count; i++)
                {
                    BattleOrderTextBox.Text += "\n" + refer.u.Participants[i].Name + "\n";
                }

                setImages(refer.u.Participants);

                BeginButton.Enabled = false;

                refer.manager.Statsofobjects(refer.u.Participants);

                StatsBox.Text = refer.manager.statsText;

                foreach (Unit i in refer.u.Participants)
                {
                    if (i.Type == "Player")
                    {
                        playerParty.Add(i);

                    }
                    if (i.Type == "Enemy")
                    {
                        enemyParty.Add(i);

                    }

                }

                //Enable buttons so player can attack an enemy
                Enemy1Button.Enabled = true;
                Enemy2Button.Enabled = true;
                Enemy3Button.Enabled = true;
            }

            if (refer.manager.fsm.state == e_STATES.ENEMYTURN)
            {
                index = refer.currentUnitIndex;

                //Battle party sorted by speed to produce attack order 
                refer.u.Participants = refer.manager.sortBySpeed(refer.BattleReadyParty);

                for (int i = 0; i < refer.u.Participants.Count; i++)
                {
                    BattleOrderTextBox.Text += "\n" + refer.u.Participants[i].Name + "\n";
                }

                setImages(refer.u.Participants);

                BeginButton.Enabled = false;

                refer.manager.Statsofobjects(refer.u.Participants);

                StatsBox.Text = refer.manager.statsText;

                foreach (Unit i in refer.u.Participants)
                {
                    if (i.Type == "Player")
                    {
                        playerParty.Add(i);

                    }
                    if (i.Type == "Enemy")
                    {
                        enemyParty.Add(i);
                    }

                }

                ProcessEnemyAttack.Enabled = true;

            }

            //SaveGameButton.Enabled = true;
            if (refer.manager.fsm.state == e_STATES.SEARCH)
            {

                //Battle party sorted by speed to produce attack order 
                refer.u.Participants = refer.manager.sortBySpeed(refer.BattleReadyParty);

                for (int i = 0; i < refer.u.Participants.Count; i++)
                {
                    BattleOrderTextBox.Text += "\n" + refer.u.Participants[i].Name + "\n";
                }

                foreach (Unit i in refer.u.Participants)
                {
                    if (i.Type == "Player")
                    {
                        playerParty.Add(i);

                    }
                    if (i.Type == "Enemy")
                    {
                        enemyParty.Add(i);
                    }

                }


                    Enemy1Label.Text = enemyParty[0].Name;

                    Enemy2Label.Text = enemyParty[1].Name;

                    Enemy3Label.Text = enemyParty[2].Name;


                setImages(refer.u.Participants);

                BeginButton.Enabled = false;

                refer.manager.Statsofobjects(refer.u.Participants);

                StatsBox.Text = refer.manager.statsText;

                refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

                if (refer.manager.fsm.state == e_STATES.BATTLE)
                {
                    FirstAttack(refer.u.Participants);
                }

            }

            Enemy1Label.Text = enemyParty[0].Name;
            Enemy2Label.Text = enemyParty[1].Name;
            Enemy3Label.Text = enemyParty[2].Name;

            CurrentStateBox.Text = refer.manager.fsm.state.ToString();
        }

        // private void Fight(List<Unit> uList, FiniteStateMachine<e_STATES> fsm)
        //{
        //bool loop = true;
        //Player plist = new Player();
        //Enemy eList = new Enemy();



        //while (loop)
        // {

        // for (int i = 0; i < uList.Count; i++)
        // {
        //if (uList[i].Life == true)
        //{
        //    BattleText.Text += "It is " + uList[i].Name + "'s turn!\n";

        //}

        //if (uList[i].Type == "Player" && uList[i].Life == true)
        //{
        //    refer.manager.fsm.ChangeStates(e_STATES.PLAYERTURN);

        //    //BattleText.Text += "Choose the enemy to attack! \n";

        //    //Player needs input
        //    Enemy1Button_Click(uList[i], null);
        //    //Enemy2Button_Click(uList[i], null);
        //    //Enemy3Button_Click(uList[i], null);

        //    //uList[i].ChooseWhoToAttack(enemyParty);
        //    //uList[i].Attack(uList[i].Target);
        //    refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

        //}

        //if (uList[i].Type == "Enemy" && uList[i].Life == true)
        //{
        //// so much accessing
        //// simplify code clarity by accessing what you want

        //refer.manager.fsm.ChangeStates(e_STATES.ENEMYTURN);

        //Unit Defender = uList[i].EnemyRandomTarget(currentParty);
        //Unit Attacker = uList[i];

        //refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

        //    //use your boolean checks to determine if you should break the loop
        //if (!Attacker.Attack(Defender))
        //{
        //        break;
        //}

        //            BattleText.Text += uList[i].stuffText;
        //        }


        //}

        //if (refer.manager.Checkforvictory(currentParty, enemyParty) == true)
        //{
        //        loop = false;
        //        BattleText.Text += refer.manager.winText;
        //        refer.manager.fsm.ChangeStates(e_STATES.EXIT);
        //        textBox1.Text = refer.manager.fsm.state.ToString();

        //}

        private void FirstAttack(List<Unit> uList)
        {

            BattleText.Text += "It is " + uList[index].Name + "'s turn!\n";

            if (uList[index].Type == "Enemy" && uList[index].Life == true)
            {
                refer.manager.fsm.ChangeStates(e_STATES.ENEMYTURN);

                if (refer.manager.fsm.state == e_STATES.ENEMYTURN)
                {
                    //Enable button so enemy can attack
                    ProcessEnemyAttack.Enabled = true;
                }

            }

            if (uList[index].Type == "Player" && uList[index].Life == true)
            {
                refer.manager.fsm.ChangeStates(e_STATES.PLAYERTURN);

                if (refer.manager.fsm.state == e_STATES.PLAYERTURN)
                {
                    //Enable buttons so player can attack an enemy
                    Enemy1Button.Enabled = true;
                    Enemy2Button.Enabled = true;
                    Enemy3Button.Enabled = true;
                }


            }

            StatsBox.Text = refer.manager.statsText;
        }

        private void Enemy1Button_Click(object sender, EventArgs e)
        {
            Unit a = refer.u.Participants[index];

            if (enemyParty[0].Life == true)
            {

                //BattleText.Text += a.Name + " is about to attack\n";
                a.Attack(enemyParty[0]);
                BattleText.Text = a.stuffText;

                if (index == count)
                {
                    index = 0;
                }
                else
                {
                    index += 1;
                }

            }
            if (refer.manager.Checkforvictory(playerParty, enemyParty) == true)
            {
                BattleText.Text += refer.manager.winText;

                refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

                if(refer.manager.fsm.state == e_STATES.BATTLE)
                {
                    refer.manager.fsm.ChangeStates(e_STATES.EXIT);
                }
                if (refer.manager.fsm.state == e_STATES.EXIT)
                {
                    Party party = new Party();

                    party.units = playerParty;

                    foreach (Unit u in party.units)
                    {//Reset health
                        u.Health = u.MaxHp;
                        //Bring life to true 
                        u.Life = true;
                    }
                    refer.manager.statsText = "";
                    refer.manager.Statsofobjects(refer.u.Participants);
                    StatsBox.Text = refer.manager.statsText;
                    ProcessEnemyAttack.Enabled = false;
                    Enemy1Button.Enabled = false;
                    Enemy2Button.Enabled = false;
                    Enemy3Button.Enabled = false;
                    CurrentStateBox.Text = refer.manager.fsm.state.ToString();

                    DialogResult = MessageBox.Show("Would you like to save your current party?\n", "Save Party", MessageBoxButtons.YesNo);

                    if (DialogResult == DialogResult.Yes)
                    {
                        _Save.Serialize("Party", party);
                        Application.Exit();

                    }
                }

            }

            processTurn(index);

        }

        private void Enemy2Button_Click(object sender, EventArgs e)
        {
            Unit a = refer.u.Participants[index];


            if (enemyParty[1].Life == true)
            {

                //BattleText.Text += a.Name + " is about to attack\n";
                a.Attack(enemyParty[1]);
                BattleText.Text = a.stuffText;

                if (index == count)
                {
                    index = 0;
                }
                else
                {
                    index += 1;
                }

            }
           
            if (refer.manager.Checkforvictory(playerParty, enemyParty) == true)
            {
                BattleText.Text += refer.manager.winText;

                refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

                if (refer.manager.fsm.state == e_STATES.BATTLE)
                {
                    refer.manager.fsm.ChangeStates(e_STATES.EXIT);
                }
                if (refer.manager.fsm.state == e_STATES.EXIT)
                {
                    Party party = new Party();

                    party.units = playerParty;

                    foreach (Unit u in party.units)
                    {//Reset health
                        u.Health = u.MaxHp;
                        //Bring life to true 
                        u.Life = true;
                    }

                    refer.manager.statsText = "";
                    refer.manager.Statsofobjects(refer.u.Participants);
                    StatsBox.Text = refer.manager.statsText;
                    ProcessEnemyAttack.Enabled = false;
                    Enemy1Button.Enabled = false;
                    Enemy2Button.Enabled = false;
                    Enemy3Button.Enabled = false;
                    CurrentStateBox.Text = refer.manager.fsm.state.ToString();

                    DialogResult = MessageBox.Show("Would you like to save your current party?\n", "Save Party", MessageBoxButtons.YesNo);

                    if (DialogResult == DialogResult.Yes)
                    {
                        _Save.Serialize("Party", party);
                        Application.Exit();
                    }
                }

            }
            processTurn(index);
        }

        private void Enemy3Button_Click(object sender, EventArgs e)
        {

            Unit a = refer.u.Participants[index];


            if (enemyParty[2].Life == true)
            {

                //BattleText.Text += a.Name + " is about to attack\n";
                a.Attack(enemyParty[2]);
                BattleText.Text = a.stuffText;

                if (index == count)
                {
                    index = 0;
                }
                else
                {
                    index += 1;
                }

            }

           
            if (refer.manager.Checkforvictory(playerParty, enemyParty) == true)
            {
                BattleText.Text += refer.manager.winText;

                refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

                if (refer.manager.fsm.state == e_STATES.BATTLE)
                {
                    refer.manager.fsm.ChangeStates(e_STATES.EXIT);
                }
                if (refer.manager.fsm.state == e_STATES.EXIT)
                {

                    Party party = new Party();

                    party.units = playerParty;

                    foreach (Unit u in party.units)
                    {//Reset health
                        u.Health = u.MaxHp;
                        //Bring life to true 
                        u.Life = true;
                    }

                    refer.manager.statsText = "";
                    refer.manager.Statsofobjects(refer.u.Participants);
                    StatsBox.Text = refer.manager.statsText;

                    ProcessEnemyAttack.Enabled = false;
                    Enemy1Button.Enabled = false;
                    Enemy2Button.Enabled = false;
                    Enemy3Button.Enabled = false;
                    CurrentStateBox.Text = refer.manager.fsm.state.ToString();

                    DialogResult = MessageBox.Show("Would you like to save your current party?\n", "Save Party", MessageBoxButtons.YesNo);

                    if (DialogResult == DialogResult.Yes)
                    {
                        _Save.Serialize("Party", party);
                        Application.Exit();

                    }

                }

            }
            processTurn(index);
        }

        private void ProcessEnemyAttack_Click(object sender, EventArgs e)
        {
            if (refer.u.Participants[index].Type == "Enemy" && refer.u.Participants[index].Life == true)
            {
                Unit Attacker = refer.u.Participants[index];
                Unit Defender = Attacker.EnemyRandomTarget(playerParty);


                Attacker.Attack(Defender);

                BattleText.Text = Attacker.stuffText;
                if (index == count)
                {
                    index = 0;
                }
                else
                {
                    index += 1;
                }
            }

            if (refer.manager.Checkforvictory(playerParty, enemyParty) == true)
            {
                BattleText.Text += refer.manager.winText;

                refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

                if (refer.manager.fsm.state == e_STATES.BATTLE)
                {
                    refer.manager.fsm.ChangeStates(e_STATES.EXIT);
                }
                if (refer.manager.fsm.state == e_STATES.EXIT)
                {
                    refer.manager.statsText = "";
                    refer.manager.Statsofobjects(refer.u.Participants);
                    StatsBox.Text = refer.manager.statsText;
                    ProcessEnemyAttack.Enabled = false;
                    Enemy1Button.Enabled = false;
                    Enemy2Button.Enabled = false;
                    Enemy3Button.Enabled = false;

                   
                    CurrentStateBox.Text = refer.manager.fsm.state.ToString();
                    //Application.Exit();
                }

            }

            processTurn(index);
        }

        private void processTurn(int number)
        {
            refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

            if (refer.manager.fsm.state == e_STATES.BATTLE)
            {
                refer.manager.statsText = "";
                refer.manager.Statsofobjects(refer.u.Participants);

                StatsBox.Text = refer.manager.statsText;

                if (number == refer.u.Participants.Count)
                {
                    number = 0;
                    index = 0;
                }


                if (refer.u.Participants[number].Type == "Player" && refer.u.Participants[number].Life == true)
                {
                    refer.manager.fsm.ChangeStates(e_STATES.PLAYERTURN);

                    if (refer.manager.fsm.state == e_STATES.PLAYERTURN)
                    {
                        BattleText.Text += "It is " + refer.u.Participants[number].Name + "'s turn!\n";
                        Enemy1Button.Enabled = true;
                        Enemy2Button.Enabled = true;
                        Enemy3Button.Enabled = true;
                        ProcessEnemyAttack.Enabled = false;

                        CurrentStateBox.Text = refer.manager.fsm.state.ToString();
                    }

                }
                else if (refer.u.Participants[number].Type == "Enemy" && refer.u.Participants[number].Life == true)
                {
                    refer.manager.fsm.ChangeStates(e_STATES.ENEMYTURN);

                    if (refer.manager.fsm.state == e_STATES.ENEMYTURN)
                    {
                        BattleText.Text += "It is " + refer.u.Participants[number].Name + "'s turn!\n";
                        Enemy1Button.Enabled = false;
                        Enemy2Button.Enabled = false;
                        Enemy3Button.Enabled = false;
                        ProcessEnemyAttack.Enabled = true;

                        CurrentStateBox.Text = refer.manager.fsm.state.ToString();
                    }

                }
                else
                {
                    index += 1;
                    processTurn(index);
                }

            }
        }

        private void setImages(List<Unit> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                //Player Images
                if (units[i].Name == Player1Label.Text)
                {
                    switch (units[i].Name)
                    {
                        case "Cloud":
                            p1PictureBox.Image = Properties.Resources.Cloud;
                            break;
                        case "Barret":
                            p1PictureBox.Image = Properties.Resources.Barrett;
                            break;
                        case "Cait Sith":
                            p1PictureBox.Image = Properties.Resources.Cait_Sith;
                            break;
                        case "Aerith":
                            p1PictureBox.Image = Properties.Resources.Aerith;
                            break;
                        case "Yuffie":
                            p1PictureBox.Image = Properties.Resources.Yuffie;
                            break;
                        case "Vincent":
                            p1PictureBox.Image = Properties.Resources.Vincent;
                            break;
                        case "Cid":
                            p1PictureBox.Image = Properties.Resources.Cid;
                            break;
                        case "Red XIII":
                            p1PictureBox.Image = Properties.Resources.Red_XIII;
                            break;
                        case "Tifa":
                            p1PictureBox.Image = Properties.Resources.Tifa;
                            break;
                        default:
                            break;
                    }
                }
                if (units[i].Name == Player2Label.Text)
                {
                    switch (units[i].Name)
                    {
                        case "Cloud":
                            p2PictureBox.Image = Properties.Resources.Cloud;
                            break;
                        case "Barret":
                            p2PictureBox.Image = Properties.Resources.Barrett;
                            break;
                        case "Cait Sith":
                            p2PictureBox.Image = Properties.Resources.Cait_Sith;
                            break;
                        case "Aerith":
                            p2PictureBox.Image = Properties.Resources.Aerith;
                            break;
                        case "Yuffie":
                            p2PictureBox.Image = Properties.Resources.Yuffie;
                            break;
                        case "Vincent":
                            p2PictureBox.Image = Properties.Resources.Vincent;
                            break;
                        case "Cid":
                            p2PictureBox.Image = Properties.Resources.Cid;
                            break;
                        case "Red XIII":
                            p2PictureBox.Image = Properties.Resources.Red_XIII;
                            break;
                        case "Tifa":
                            p2PictureBox.Image = Properties.Resources.Tifa;
                            break;
                        default:
                            break;
                    }

                }
                if (units[i].Name == Player3Label.Text)
                {
                    switch (units[i].Name)
                    {
                        case "Cloud":
                            p3PictureBox.Image = Properties.Resources.Cloud;
                            break;
                        case "Barret":
                            p3PictureBox.Image = Properties.Resources.Barrett;
                            break;
                        case "Cait Sith":
                            p3PictureBox.Image = Properties.Resources.Cait_Sith;
                            break;
                        case "Aerith":
                            p3PictureBox.Image = Properties.Resources.Aerith;
                            break;
                        case "Yuffie":
                            p3PictureBox.Image = Properties.Resources.Yuffie;
                            break;
                        case "Vincent":
                            p3PictureBox.Image = Properties.Resources.Vincent;
                            break;
                        case "Cid":
                            p3PictureBox.Image = Properties.Resources.Cid;
                            break;
                        case "Red XIII":
                            p3PictureBox.Image = Properties.Resources.Red_XIII;
                            break;
                        case "Tifa":
                            p3PictureBox.Image = Properties.Resources.Tifa;
                            break;
                        default:
                            break;
                    }

                }

                //Enemy Images
                if (units[i].Name == Enemy1Label.Text)
                {
                    switch (units[i].Name)
                    {
                        case "2Faced":
                            e1PictureBox.Image = Properties.Resources._2Faced;
                            break;
                        case "Ice Golem":
                            e1PictureBox.Image = Properties.Resources.Ice_Golem;
                            break;
                        case "Ancient Dragon":
                            e1PictureBox.Image = Properties.Resources.Ancient_Dragon;
                            break;
                        case "Behemoth":
                            e1PictureBox.Image = Properties.Resources.Behemoth;
                            break;
                        case "Death Claw":
                            e1PictureBox.Image = Properties.Resources.Death_Claw;
                            break;
                        case "Master Tonberry":
                            e1PictureBox.Image = Properties.Resources.Master_Tonberry;
                            break;
                        case "Toxic Frog":
                            e1PictureBox.Image = Properties.Resources.Toxic_Frog;
                            break;
                        case "Zuu":
                            e1PictureBox.Image = Properties.Resources.Zuu;
                            break;
                        case "Ghost":
                            e1PictureBox.Image = Properties.Resources.Ghost;
                            break;
                        default:
                            break;
                    }
                }
                if (units[i].Name == Enemy2Label.Text)
                {
                    switch (units[i].Name)
                    {
                        case "2Faced":
                            e2PictureBox.Image = Properties.Resources._2Faced;
                            break;
                        case "Ice Golem":
                            e2PictureBox.Image = Properties.Resources.Ice_Golem;
                            break;
                        case "Ancient Dragon":
                            e2PictureBox.Image = Properties.Resources.Ancient_Dragon;
                            break;
                        case "Behemoth":
                            e2PictureBox.Image = Properties.Resources.Behemoth;
                            break;
                        case "Death Claw":
                            e2PictureBox.Image = Properties.Resources.Death_Claw;
                            break;
                        case "Master Tonberry":
                            e2PictureBox.Image = Properties.Resources.Master_Tonberry;
                            break;
                        case "Toxic Frog":
                            e2PictureBox.Image = Properties.Resources.Toxic_Frog;
                            break;
                        case "Zuu":
                            e2PictureBox.Image = Properties.Resources.Zuu;
                            break;
                        case "Ghost":
                            e2PictureBox.Image = Properties.Resources.Ghost;
                            break;
                        default:
                            break;
                    }

                }
                if (units[i].Name == Enemy3Label.Text)
                {
                    switch (units[i].Name)
                    {
                        case "2Faced":
                            e3PictureBox.Image = Properties.Resources._2Faced;
                            break;
                        case "Ice Golem":
                            e3PictureBox.Image = Properties.Resources.Ice_Golem;
                            break;
                        case "Ancient Dragon":
                            e3PictureBox.Image = Properties.Resources.Ancient_Dragon;
                            break;
                        case "Behemoth":
                            e3PictureBox.Image = Properties.Resources.Behemoth;
                            break;
                        case "Death Claw":
                            e3PictureBox.Image = Properties.Resources.Death_Claw;
                            break;
                        case "Master Tonberry":
                            e3PictureBox.Image = Properties.Resources.Master_Tonberry;
                            break;
                        case "Toxic Frog":
                            e3PictureBox.Image = Properties.Resources.Toxic_Frog;
                            break;
                        case "Zuu":
                            e3PictureBox.Image = Properties.Resources.Zuu;
                            break;
                        case "Ghost":
                            e3PictureBox.Image = Properties.Resources.Ghost;
                            break;
                        default:
                            break;
                    }

                }
            }

        }

        private void SaveGameButton_Click(object sender, EventArgs e)
        {
            Party a = new Party();
            Party b = new Party();
            List<Party> pList = new List<Party>();

            int number = index;
            a.units = playerParty;
            b.units = enemyParty;

            _Save.SerializeToSave("GameData", refer.manager.fsm.state);

            _Save.SerializeToSave("PartyData", a);

            _Save.SerializeToSave("EnemyParty", b);

            _Save.SerializeToSave("CurrentAttacker", number);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ProcessEnemyAttack.Enabled = false;
            Enemy1Button.Enabled = false;
            Enemy2Button.Enabled = false;
            Enemy3Button.Enabled = false;
            //SaveGameButton.Enabled = false;

            count = refer.u.Participants.Count - 1;
            index = 0;
            Enemy1Label.Text = refer.enemy1name;
            Enemy2Label.Text = refer.enemy2name;
            Enemy3Label.Text = refer.enemy3name;
            Player1Label.Text = refer.player1name;
            Player2Label.Text = refer.player2name;
            Player3Label.Text = refer.player3name;

            refer.manager.fsm.ChangeStates(e_STATES.SEARCH);

            CurrentStateBox.Text = refer.manager.fsm.state.ToString();
        }
    }
}
