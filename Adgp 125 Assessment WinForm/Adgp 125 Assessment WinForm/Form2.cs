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

            ProcessEnemyAttack.Enabled = false;
            Enemy1Button.Enabled = false;
            Enemy2Button.Enabled = false;
            Enemy3Button.Enabled = false;
            BattleOrderTextBox.Enabled = false;
            //BattleText.Enabled = false;

            count = refer.u.Participants.Count - 1;
            index = 0;
            Enemy1Label.Text = parent.enemy1name;
            Enemy2Label.Text = parent.enemy2name;
            Enemy3Label.Text = parent.enemy3name;
            Player1Label.Text = parent.player1name;
            Player2Label.Text = parent.player2name;
            Player3Label.Text = parent.player3name;


            textBox1.Text = refer.manager.fsm.state.ToString();
        }

        private void BeginButton_Click(object sender, EventArgs e)
        {
            refer.manager.fsm.ChangeStates(e_STATES.SEARCH);

            //Battle party sorted by speed to produce attack order 
            refer.u.Participants = refer.manager.sortBySpeed(refer.BattleReadyParty);

            for (int i = 0; i < refer.u.Participants.Count; i++)
            {
                BattleOrderTextBox.Text += "\n" + refer.u.Participants[i].Name + "\n";
            }

            setImages(refer.u.Participants);

            refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

            refer.manager.Statsofobjects(refer.u.Participants);

            StatsBox.Text = refer.manager.statsText;

            BeginButton.Enabled = false;

            FirstAttack(refer.u.Participants, refer.manager.fsm);

            textBox1.Text = refer.manager.fsm.state.ToString();
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

        private void FirstAttack(List<Unit> uList, FiniteStateMachine<e_STATES> fsm)
        {
            foreach (Unit i in uList)
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

            BattleText.Text += "It is " + uList[index].Name + "'s turn!\n";

            if (uList[index].Type == "Enemy" && uList[index].Life == true)
            {
                refer.manager.fsm.ChangeStates(e_STATES.ENEMYTURN);
                //Enable button so enemy can attack
                ProcessEnemyAttack.Enabled = true;

            }

            if (uList[index].Type == "Player" && uList[index].Life == true)
            {
                refer.manager.fsm.ChangeStates(e_STATES.PLAYERTURN);
                //Enable buttons so player can attack an enemy
                Enemy1Button.Enabled = true;
                Enemy2Button.Enabled = true;
                Enemy3Button.Enabled = true;

            }

            StatsBox.Text = refer.manager.statsText;
        }

        private void Enemy1Button_Click(object sender, EventArgs e)
        {
            Unit a = refer.u.Participants[index];
            foreach (Unit i in enemyParty)
            {
                if (i.Name == Enemy1Label.Text && i.Life == true)
                {
                    a.Attack(i);
                    BattleText.Text = a.stuffText;

                    if (index == count)
                    {
                        index = 0;
                    }
                    else
                    {
                        index += 1;
                    }
                    break;
                }

            }
            if (refer.manager.Checkforvictory(playerParty, enemyParty) == true)
            {
                BattleText.Text += refer.manager.winText;
                refer.manager.fsm.ChangeStates(e_STATES.EXIT);
                textBox1.Text = refer.manager.fsm.state.ToString();

            }

            processTurn(index);

        }

        private void Enemy2Button_Click(object sender, EventArgs e)
        {
            Unit a = refer.u.Participants[index];
            foreach (Unit i in enemyParty)
            {
                if (i.Name == Enemy2Label.Text)
                {
                    //BattleText.Text += a.Name + " is about to attack\n";
                    a.Attack(i);
                    BattleText.Text = a.stuffText;

                    if (index == count)
                    {
                        index = 0;
                    }
                    else
                    {
                        index += 1;
                    }

                    break;
                }

            }
            if (refer.manager.Checkforvictory(playerParty, enemyParty) == true)
            {
                BattleText.Text += refer.manager.winText;
                refer.manager.fsm.ChangeStates(e_STATES.EXIT);
                textBox1.Text = refer.manager.fsm.state.ToString();

            }
            processTurn(index);
        }

        private void Enemy3Button_Click(object sender, EventArgs e)
        {
            Unit a = refer.u.Participants[index];
            foreach (Unit i in enemyParty)
            {
                if (i.Name == Enemy3Label.Text)
                {
                    //BattleText.Text += a.Name + " is about to attack\n";
                    a.Attack(i);
                    BattleText.Text = a.stuffText;

                    if (index == count)
                    {
                        index = 0;
                    }
                    else
                    {
                        index += 1;
                    }

                    break;
                }

            }
            if (refer.manager.Checkforvictory(playerParty, enemyParty) == true)
            {
                BattleText.Text += refer.manager.winText;
                refer.manager.fsm.ChangeStates(e_STATES.EXIT);
                textBox1.Text = refer.manager.fsm.state.ToString();

            }
            processTurn(index);
        }

        private void ProcessEnemyAttack_Click(object sender, EventArgs e)
        {
            if (refer.u.Participants[index].Type == "Enemy" && refer.u.Participants[index].Life == true)
            {
                // so much accessing
                // simplify code clarity by accessing what you want

                //refer.manager.fsm.ChangeStates(e_STATES.ENEMYTURN);

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

                //use your boolean checks to determine if you should break the loop
                //if (!Attacker.Attack(Defender))
                //{
                //    break;
                //}

                //BattleText.Text += uList[i].stuffText;
            }
            //if(refer.u.Participants[index].Type == "Enemy" && refer.u.Participants[index].Life == false)
            //{

            //}

            if (refer.manager.Checkforvictory(playerParty, enemyParty) == true)
            {
                BattleText.Text += refer.manager.winText;
                refer.manager.fsm.ChangeStates(e_STATES.EXIT);
                textBox1.Text = refer.manager.fsm.state.ToString();
                Application.Exit();
            }

            processTurn(index);
        }

        private void processTurn(int number)
        {
            refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

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
                BattleText.Text += "It is " + refer.u.Participants[number].Name + "'s turn!\n";
                Enemy1Button.Enabled = true;
                Enemy2Button.Enabled = true;
                Enemy3Button.Enabled = true;
                ProcessEnemyAttack.Enabled = false;

                textBox1.Text = refer.manager.fsm.state.ToString();
            }
            else if (refer.u.Participants[number].Type == "Enemy" && refer.u.Participants[number].Life == true)
            {
                refer.manager.fsm.ChangeStates(e_STATES.ENEMYTURN);
                BattleText.Text += "It is " + refer.u.Participants[number].Name + "'s turn!\n";
                Enemy1Button.Enabled = false;
                Enemy2Button.Enabled = false;
                Enemy3Button.Enabled = false;
                ProcessEnemyAttack.Enabled = true;

                textBox1.Text = refer.manager.fsm.state.ToString();
            }
            else
            {
                index += 1;
                processTurn(index);
            }
          }

        private void setImages(List<Unit> units)
        {
            for (int i = 0; i < units.Count; i++)
            {
                //Player Images
                if(units[i].Name == Player1Label.Text)
                { 
                   switch(units[i].Name)
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


        }
    } 
