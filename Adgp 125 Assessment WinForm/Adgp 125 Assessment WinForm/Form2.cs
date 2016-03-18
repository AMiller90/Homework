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
        public Form1 refer;

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
            
            refer.manager.fsm.ChangeStates(e_STATES.SEARCH);
            
            //Function used to sort through the passed in list of units and sort them in descending order by speed stat then returns the sorted party
            List<Unit> BattleReadyParty = refer.manager.sortBySpeed(refer.a.Participants);

            refer.manager.fsm.ChangeStates(e_STATES.BATTLE);
            textBox1.Text = refer.manager.fsm.state.ToString();

        }
        


    }

}
