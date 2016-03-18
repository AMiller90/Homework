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
        List<Player> currentParty = new List<Player>();
        List<Enemy> enemyParty = new List<Enemy>();
        public Form1 refer;
        private List<Unit> BattleReadyParties;
        public Form2(Form1 parent)
        {
            refer = parent;
            parent.Visible = false;
            InitializeComponent();


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

            BattleReadyParties = refer.manager.sortBySpeed(refer.u.Participants);

            refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

             BeginButton.Enabled = false;
             Fight(BattleReadyParties, refer.manager.fsm);


            textBox1.Text = refer.manager.fsm.state.ToString();
        }

        private void Fight(List<Unit> uList, FiniteStateMachine<e_STATES> fsm)
        {
            bool loop = true;
            Player plist = new Player();
            Enemy eList = new Enemy();
            

            foreach (Unit i in uList)
            {
                if (i.Type == "Player")
                {
                    currentParty.Add((Player)i);

                }
                if (i.Type == "Enemy")
                {
                    enemyParty.Add((Enemy)i);
                }

            }

           while (loop)
            {

            for (int i = 0; i < uList.Count; i++)
            {
                if (uList[i].Life == true)
                {
                    BattleText.Text += "It is " + uList[i].Name + "'s turn!\n";

                }

                    if (uList[i].Type == "Player" && uList[i].Life == true)
                    {
                        refer.manager.fsm.ChangeStates(e_STATES.PLAYERTURN);

                        //BattleText.Text += "Choose the enemy to attack! \n";

                        //Player needs input
                        Enemy1Button_Click(uList[i], null);
                        //Enemy2Button_Click(uList[i], null);
                        //Enemy3Button_Click(uList[i], null);

                        //uList[i].ChooseWhoToAttack(enemyParty);
                        //uList[i].Attack(uList[i].Target);
                        refer.manager.fsm.ChangeStates(e_STATES.BATTLE);
                        
                    }

                    if (uList[i].Type == "Enemy" && uList[i].Life == true)
                    {
                    // so much accessing
                    // simplify code clarity by accessing what you want

                    refer.manager.fsm.ChangeStates(e_STATES.ENEMYTURN);

                    Unit Defender = uList[i].EnemyRandomTarget(currentParty);
                    Unit Attacker = uList[i];

                    refer.manager.fsm.ChangeStates(e_STATES.BATTLE);

                        //use your boolean checks to determine if you should break the loop
                    if (!Attacker.Attack(Defender))
                    {
                            break;
                    }

                        BattleText.Text += uList[i].stuffText;
                    }


            }

            if (refer.manager.Checkforvictory(currentParty, enemyParty) == true)
            {
                    loop = false;
                    BattleText.Text += refer.manager.winText;
                    refer.manager.fsm.ChangeStates(e_STATES.EXIT);
                    textBox1.Text = refer.manager.fsm.state.ToString();

            }
          
        }
       }

        private void Enemy1Button_Click(object sender, EventArgs e)
        {
            Unit a = (Unit)sender;
            foreach(Enemy i in enemyParty)
            {
                if(i.Name == Enemy1Label.Text && i.Life == true)
                {
                    a.Attack(i);
                    BattleText.Text += a.stuffText;
                }
                
            }
           
            
        }

        private void Enemy2Button_Click(object sender, EventArgs e)
        {
            Unit a = (Unit)sender;
            foreach (Enemy i in enemyParty)
            {
                if (i.Name == Enemy2Label.Text)
                {
                    //BattleText.Text += a.Name + " is about to attack\n";
                    a.Attack(i);
                    BattleText.Text += a.stuffText;
                }

            }
        }

        private void Enemy3Button_Click(object sender, EventArgs e)
        {
            Unit a = (Unit)sender;
            foreach (Enemy i in enemyParty)
            {
                if (i.Name == Enemy3Label.Text)
                {
                    //BattleText.Text += a.Name + " is about to attack\n";
                    a.Attack(i);
                    BattleText.Text += a.stuffText;
                }

            }
        }

    

    }

}
