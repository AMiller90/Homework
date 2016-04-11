using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileIO;
using Adgp125_Assessment_Library;

namespace Adgp_125_Assessment_WinForm
{
    public partial class Form2 : Form
    {//Create an instance of the FileIO class
        FileIOS _Save = new FileIOS();
        //Create a bool variable and set it to false
        bool bIsDone = false;
        //Create an int variable to represent the index of a given list
        int iIndex;
        //Create an int variable to compare the index too
        int iCount;
        //Create a public unit list for player types
        List<Unit> ulPlayerParty = new List<Unit>();
        //Create a public unit list for enemy types
        List<Unit> ulEnemyParty = new List<Unit>();

        //Create a public variable to reference the Form1 class
        public Form1 refer;

        //Constructor for the Form2 Class
        public Form2(Form1 parent)
        {//Set the passed int Form1 variable to the refer variable
            refer = parent;
            //Set the passed in form to be not visible
            parent.Visible = false;
            //Initialize the current form
            InitializeComponent();
        }

        //Function called to start the battle
        private void FirstAttack(List<Unit> uList)
        {//Add the BattleText to "It is then the current units name's turn! then a newline
            BattleText.Text += "It is " + uList[iIndex].sName + "'s turn!\n";

            //If the deserialized state variable is not equal to null
            if (refer.deserializedState != null)
            {//It means this is a loaded save file so pass in the state to the machine as a string
                //So the machine will know exactly which state to transition to
                refer.fsm.Feed(refer.deserializedState);
            }
            //else if the deserialized state is null that means the game isnt loaded from a saved file
            else
            {//if the current units type is an enemy and it is alive
                if (uList[iIndex].sType == "Enemy" && uList[iIndex].bLife == true)
                {//Transition to ENEMYTURN state
                    refer.fsm.Feed("ENEMYTURN");

                }
                //if the current units type is a player and it is alive
                if (uList[iIndex].sType == "Player" && uList[iIndex].bLife == true)
                {//Transition to PLAYERTURN state
                    refer.fsm.Feed("PLAYERTURN");
                }

            }


            //Set the StatsBox text to the statsText variable data
            StatsBox.Text = refer.manager.statsText;
        }

        //Function activated when the Enemy1Button is clicked - Gives user option of attacking specific unit
        private void Enemy1Button_Click(object sender, EventArgs e)
        {//Set the current unit in the list into a Unit variable to simplify and make it easier to read
            Unit a = refer.u.ulParticipants[iIndex];
            //If the current enemy in the enemyParty is alive
            if (ulEnemyParty[0].bLife == true)
            {//The current unit will attack that enemy
                a.Attack(ulEnemyParty[0]);
                //Set the BattleText text to stufftext data
                BattleText.Text = a.sStuffText;
                //If the index is equal to the count variable
                if (iIndex == iCount)
                {//Set index to 0
                    iIndex = 0;
                }
                //If the index is not equal to the count variable
                else
                {//Increment the index by 1
                    iIndex += 1;
                }

            }
            //If the Checkforvictory function returns true 
            if (refer.manager.CheckForVictory(ulPlayerParty, ulEnemyParty) == true)
            {//Set the BattleText text to the winText
                BattleText.Text += refer.manager.winText;
                //Create a new Party object
                Party party = new Party();
                //Set the units list in that party object to the playerParty list
                party.ulUnits = ulPlayerParty;
                //Loop through each unit in the party units list
                foreach (Unit u in party.ulUnits)
                {//Reset health
                    u.iHealth = u.iMaxHp;
                    //Bring life to true 
                    u.bLife = true;
                }
                //Set the statsText to ""
                refer.manager.statsText = "";
                //Call this function to print out the Stats of the objects in battle
                refer.manager.StatsOfObjects(refer.u.ulParticipants);
                //Set the StatsBox text to the statsText
                StatsBox.Text = refer.manager.statsText;

                //Disable the Enemy1Button
                Enemy1Button.Enabled = false;
                //Disable the Enemy2Button
                Enemy2Button.Enabled = false;
                //Disable the Enemy3Button
                Enemy3Button.Enabled = false;
                //Set the CurrentStateBox text to the currentStates name
                CurrentStateBox.Text = refer.fsm.sCurrentState.eName.ToString();
             
                //Message box that prompts the user they have won and asked is they would like to save the current party
                DialogResult = MessageBox.Show("Would you like to save your current party?\n", "You Win!", MessageBoxButtons.YesNo);
                //If yes is clicked
                if (DialogResult == DialogResult.Yes)
                {//Serialize the party object to a file called "Party"
                    _Save.Serialize("Party", party);

                    //Message box prompts user that the Game has been saved
                    MessageBox.Show("Game Has Been Saved!", "Save", MessageBoxButtons.OK);
                }
                //Set isDone variable to true
                bIsDone = true;
                //Changes state to start
                refer.fsm.Feed("start");

            }
            //If isDone is equal to false
            if(bIsDone == false)
            {//Call the process turn function 
                processTurn(iIndex);
            }
            

        }

        //Function activated when the Enemy2Button is clicked - Gives user option of attacking specific unit
        private void Enemy2Button_Click(object sender, EventArgs e)
        {//Set the current unit in the list into a Unit variable to simplify and make it easier to read
            Unit a = refer.u.ulParticipants[iIndex];

            //If the current enemy in the enemyParty is alive
            if (ulEnemyParty[1].bLife == true)
            { 
                //The current unit will attack that enemy
                a.Attack(ulEnemyParty[1]);
                //Set the BattleText text to stufftext data
                BattleText.Text = a.sStuffText;

                //If the index is equal to the count variable
                if (iIndex == iCount)
                {//Set index to 0
                    iIndex = 0;
                }
                //If the index is not equal to the count variable
                else
                {//Increment the index by 1
                    iIndex += 1;
                }

            }
            //If the Checkforvictory function returns true 
            if (refer.manager.CheckForVictory(ulPlayerParty, ulEnemyParty) == true)
            {//Set the BattleText text to the winText
                BattleText.Text += refer.manager.winText;
                //Create a new Party object
                Party party = new Party();
                //Set the units list in that party object to the playerParty list
                party.ulUnits = ulPlayerParty;
                //Loop through each unit in the party units list
                foreach (Unit u in party.ulUnits)
                {//Reset health
                    u.iHealth = u.iMaxHp;
                    //Bring life to true 
                    u.bLife = true;
                }
                //Set the statsText to ""
                refer.manager.statsText = "";
                //Call this function to print out the Stats of the objects in battle
                refer.manager.StatsOfObjects(refer.u.ulParticipants);
                //Set the StatsBox text to the statsText
                StatsBox.Text = refer.manager.statsText;

                //Disable the Enemy1Button
                Enemy1Button.Enabled = false;
                //Disable the Enemy2Button
                Enemy2Button.Enabled = false;
                //Disable the Enemy3Button
                Enemy3Button.Enabled = false;

                //Set the CurrentStateBox text to the currentStates name
                CurrentStateBox.Text = refer.fsm.sCurrentState.eName.ToString();

                //Message box that prompts the user they have won and asked is they would like to save the current party
                DialogResult = MessageBox.Show("Would you like to save your current party?\n", "You Win!", MessageBoxButtons.YesNo);

                //If yes is clicked
                if (DialogResult == DialogResult.Yes)
                {//Serialize the party object to a file called "Party"
                    _Save.Serialize("Party", party);

                    //Message box prompts user that the Game has been saved
                    MessageBox.Show("Game Has Been Saved!", "Save", MessageBoxButtons.OK);
                }
                //Set isDone variable to true
                bIsDone = true;
                //Changes state to start
                refer.fsm.Feed("start");

            }
            //If isDone is equal to false
            if (bIsDone == false)
            {//Call the process turn function 
                processTurn(iIndex);
            }
        }

        //Function activated when the Enemy3Button is clicked - Gives user option of attacking specific unit
        private void Enemy3Button_Click(object sender, EventArgs e)
        {//Set the current unit in the list into a Unit variable to simplify and make it easier to read
            Unit a = refer.u.ulParticipants[iIndex];

            //If the current enemy in the enemyParty is alive
            if (ulEnemyParty[2].bLife == true)
            {
                //The current unit will attack that enemy
                a.Attack(ulEnemyParty[2]);
                //Set the BattleText text to stufftext data
                BattleText.Text = a.sStuffText;

                //If the index is equal to the count variable
                if (iIndex == iCount)
                {//Set index to 0
                    iIndex = 0;
                }
                //If the index is not equal to the count variable
                else
                {//Increment the index by 1
                    iIndex += 1;
                }

            }
            //If the Checkforvictory function returns true 
            if (refer.manager.CheckForVictory(ulPlayerParty, ulEnemyParty) == true)
            {//Set the BattleText text to the winText
                BattleText.Text += refer.manager.winText;

                //Create a new Party object
                Party party = new Party();

                //Set the units list in that party object to the playerParty list
                party.ulUnits = ulPlayerParty;

                //Loop through each unit in the party units list
                foreach (Unit u in party.ulUnits)
                {//Reset health
                    u.iHealth = u.iMaxHp;
                    //Bring life to true 
                    u.bLife = true;
                }
                //Set the statsText to ""
                refer.manager.statsText = "";
                //Call this function to print out the Stats of the objects in battle
                refer.manager.StatsOfObjects(refer.u.ulParticipants);
                //Set the StatsBox text to the statsText
                StatsBox.Text = refer.manager.statsText;

                //Disable the Enemy1Button
                Enemy1Button.Enabled = false;
                //Disable the Enemy2Button
                Enemy2Button.Enabled = false;
                //Disable the Enemy3Button
                Enemy3Button.Enabled = false;

                //Set the CurrentStateBox text to the currentStates name
                CurrentStateBox.Text = refer.fsm.sCurrentState.eName.ToString();

                //Message box that prompts the user they have won and asked is they would like to save the current party
                DialogResult = MessageBox.Show("Would you like to save your current party?\n", "You Win!", MessageBoxButtons.YesNo);

                //If yes is clicked
                if (DialogResult == DialogResult.Yes)
                {//Serialize the party object to a file called "Party"
                    _Save.Serialize("WinningParty", party);

                    //Message box prompts user that the Game has been saved
                    MessageBox.Show("Game Has Been Saved!", "Save", MessageBoxButtons.OK);
                }

                //Set isDone variable to true
                bIsDone = true;
                //Changes state to start
                refer.fsm.Feed("start");

            }
            //If isDone is equal to false
            if (bIsDone == false)
            {//Call the process turn function 
                processTurn(iIndex);
            }
        }

        //Function called to determine the next units turn
        private void processTurn(int iNumber)
        {//If number is equal to the count of the participants list
            if (iNumber == refer.u.ulParticipants.Count)
            {//That means we need to start over in the list
                //Set number to 0
                iNumber = 0;
                //Set index to 0
                iIndex = 0;
            }
            //Set e_States.Battle as an Enum and store it into a new Enum variable
            Enum state = e_STATES.BATTLE as Enum;
            //if(The current states name is not the same as the state variable
            if(refer.fsm.sCurrentState.eName != state)
            {//Change to the battle state
                refer.fsm.Feed("battle");
            }
           
            //If the current unit is of type Player and is alive
            if (refer.u.ulParticipants[iNumber].sType == "Player" && refer.u.ulParticipants[iNumber].bLife == true)
                {
                //Add It is The current units names turn! and a newline to the BattleText text
                BattleText.Text += "It is " + refer.u.ulParticipants[iNumber].sName + "'s turn!\n";
                //Change to the Player state
                refer.fsm.Feed("battletoplayer");

                }
            // else if the current unit is of type Enemy and is alive
            else if (refer.u.ulParticipants[iNumber].sType == "Enemy" && refer.u.ulParticipants[iNumber].bLife == true)
                {
                //Add It is The current units names turn! and a newline to the BattleText text
                BattleText.Text += "It is " + refer.u.ulParticipants[iNumber].sName + "'s turn!\n";
                //Change to the Enemy state
                refer.fsm.Feed("battletoenemy");

                }
            //If the current unit is not of Type player or enemy or the unit is not alive
                else
                {//Increment the index by 1 
                iIndex += 1;
                //Call processTurn function again with the index passed in so the next unit can have its turn
                processTurn(iIndex);
                }

            
        }

        //Function used to set the images of objects that will be in battle
        private void setImages(List<Unit> ulUnits)
        {//Loop through the number of units in the list
            for (int i = 0; i < ulUnits.Count; i++)
            {//If the unit at the current indexes name is the same as the Player1Label.Text
                //Player Images
                if (ulUnits[i].sName == Player1Label.Text)
                {//Look For the Name in this statement
                    switch (ulUnits[i].sName)
                    {//If the name is here in a case then set the p1PictureBox.Image to the proper picture
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
                //If the unit at the current indexes name is the same as the Player2Label.Text
                if (ulUnits[i].sName == Player2Label.Text)
                {//Look For the Name in this statement
                    switch (ulUnits[i].sName)
                    {//If the name is here in a case then set the p2PictureBox.Image to the proper picture
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
                //If the unit at the current indexes name is the same as the Player3Label.Text
                if (ulUnits[i].sName == Player3Label.Text)
                {//Look For the Name in this statement
                    switch (ulUnits[i].sName)
                    {//If the name is here in a case then set the p3PictureBox.Image to the proper picture
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
                //If the unit at the current indexes name is the same as the Enemy1Label.Text
                //Enemy Images
                if (ulUnits[i].sName == Enemy1Label.Text)
                {//Look For the Name in this statement
                    switch (ulUnits[i].sName)
                    {//If the name is here in a case then set the e1PictureBox.Image to the proper picture
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
                //If the unit at the current indexes name is the same as the Enemy2Label.Text
                if (ulUnits[i].sName == Enemy2Label.Text)
                {//Look For the Name in this statement
                    switch (ulUnits[i].sName)
                    {//If the name is here in a case then set the e2PictureBox.Image to the proper picture
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
                //If the unit at the current indexes name is the same as the Enemy3Label.Text
                if (ulUnits[i].sName == Enemy3Label.Text)
                {//Look For the Name in this statement
                    switch (ulUnits[i].sName)
                    {//If the name is here in a case then set the e3PictureBox.Image to the proper picture
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

        //Function called when the save game button is clicked
        private void SaveGameButton_Click(object sender, EventArgs e)
        {//Create an in instance of a new Party object
            Party a = new Party();
            //Create an in instance of a new Party object
            Party b = new Party();
            //Create an enum variable
            Enum E;
            //Create a new list of Party objects
            List<Party> pList = new List<Party>();

            //Create a new int variable and set it to the index 
            int number = iIndex;
            //Set the units list inside this party to the playerParty
            a.ulUnits = ulPlayerParty;
            //Set the units list inside this party to the enemyParty
            b.ulUnits = ulEnemyParty;
            //Set the Enum variable to the currentStates name
            E = refer.fsm.sCurrentState.eName;

            //Serialize the Current state as a string and store it into a file called GameData
            _Save.SerializeToSave("GameData", E.ToString());
            //Serialize the a Party object and store it into a file called PartyData
            _Save.SerializeToSave("PartyData", a);
            //Serialize the b Party object and store it into a file called EnemyParty
            _Save.SerializeToSave("EnemyParty", b);
            //Serialize the number variable and store it into a file called CurrentAttacker
            _Save.SerializeToSave("CurrentAttacker", number);
            //Message box prompts user that the Game has been saved
            MessageBox.Show("Game Has Been Saved!", "Save", MessageBoxButtons.OK);

        }

        //Function called when this form is loaded
        private void Form2_Load(object sender, EventArgs e)
        {//Set isDone variable to false
            bIsDone = false;
            //If the playerParty count is greater than or equal to 1
            if(ulPlayerParty.Count >= 1)
            {//Remove all elements in the playerParty
                ulPlayerParty.RemoveRange(0, ulPlayerParty.Count);
            }
            //If the enemyParty count is greater than or equal to 1
            if (ulEnemyParty.Count >= 1)
            {//Remove all elements in the enemyParty
                ulEnemyParty.RemoveRange(0, ulEnemyParty.Count);
            }
            //Disable the Enemy1Button
            Enemy1Button.Enabled = false;
            //Disable the Enemy2Button
            Enemy2Button.Enabled = false;
            //Disable the Enemy3Button
            Enemy3Button.Enabled = false;

            //Set count equal to the participants list count - 1
            iCount = refer.u.ulParticipants.Count - 1;
            //Set index to 0
            iIndex = 0;
            //Set index to currenntUnitIndex if it is loaded in from a save file
            iIndex = refer.currentUnitIndex;

            //Set the Player1Label text to the player1name variable
            Player1Label.Text = refer.player1name;
            //Set the Player2Label text to the player2name variable
            Player2Label.Text = refer.player2name;
            //Set the Player3Label text to the player3name variable
            Player3Label.Text = refer.player3name;

            //Set the BattleText text to ""
            BattleText.Text = "";
            //Set the machine to Search State
            refer.fsm.Feed("search");

            //Set the CurrentStateBox text to the currentState name
            CurrentStateBox.Text = refer.fsm.sCurrentState.eName.ToString();


        }

        //Function that loads game data
        public void LoadGame()
        {//CurrentStateBox text will be set to the deserialized state data
                CurrentStateBox.Text = refer.deserializedState.ToString();
            //index will be set to the currentUnitIndex data
                iIndex = refer.currentUnitIndex;
            
        }

        //Battle to enemy
        public void EnemyTurn()
        {//Disable the Enemy1Button
            Enemy1Button.Enabled = false;
            //Disable the Enemy2Button
            Enemy2Button.Enabled = false;
            //Disable the Enemy3Button
            Enemy3Button.Enabled = false;
            //Set the BattleText text to currentState
            BattleText.Text += refer.fsm.sCurrentState.eName.ToString() + "\n";
            //Set currentStateBox text to the currentState
            CurrentStateBox.Text = refer.fsm.sCurrentState.eName.ToString();

            //If the current unit is an enemy and alive
            if (refer.u.ulParticipants[iIndex].sType == "Enemy" && refer.u.ulParticipants[iIndex].bLife == true)
            {//Create a new unit and store current unit into it
                Unit Attacker = refer.u.ulParticipants[iIndex];
                //Create a new Unit and store the enemies target into it
                Unit Defender = Attacker.EnemyRandomTarget(ulPlayerParty);

                //Attack function called on target unit
                Attacker.Attack(Defender);
                //Set BattleText to stuffText
                BattleText.Text += Attacker.sStuffText;
               
                //Set index to 0 if true : Add 1 to index if false
                iIndex = iIndex == iCount ? iIndex = 0 : iIndex += 1;
            }
            //If the Checkforvictory function returns true 
            if (refer.manager.CheckForVictory(ulPlayerParty, ulEnemyParty) == true)
            {//Set the BattleText text to the winText
                BattleText.Text += refer.manager.winText;

                //Set the statsText to ""
                refer.manager.statsText = "";
                //Call this function to print out the Stats of the objects in battle
                refer.manager.StatsOfObjects(refer.u.ulParticipants);
                //Set the StatsBox text to the statsText
                StatsBox.Text = refer.manager.statsText;

                //Disable the Enemy1Button
                Enemy1Button.Enabled = false;
                //Disable the Enemy2Button
                Enemy2Button.Enabled = false;
                //Disable the Enemy3Button
                Enemy3Button.Enabled = false;

                //Set currentStateBox text to the currentState
                CurrentStateBox.Text = refer.fsm.sCurrentState.eName.ToString();
                //Set isDone to true
                bIsDone = true;
                //Message box prompting user that Enemy has won
                MessageBox.Show("Game Over", "Enemy Has Won!");
                //Feed machine
                refer.fsm.Feed("start");

            }
            //If isDone is equal to false
            if (bIsDone == false)
            {//Call process turn function
                processTurn(iIndex);
            }

        }

        //Battle to player
        public void PlayerTurn()
        {//Enable the Enemy1Button
            Enemy1Button.Enabled = true;
            //Enable the Enemy2Button
            Enemy2Button.Enabled = true;
            //Enable the Enemy3Button
            Enemy3Button.Enabled = true;

            //Set the currentStateBox text to the name of the current state
            CurrentStateBox.Text = refer.fsm.sCurrentState.eName.ToString();
        }

        //Function called during the Battle State
        public void BattlePhase()
        {//Set the stats text to ""
            refer.manager.statsText = "";
            //Call the Statsofobjects function to print stats of objects that are in the battle
            refer.manager.StatsOfObjects(refer.u.ulParticipants);
            //StatsBox text is set to the data stored in the statsText variable
            StatsBox.Text = refer.manager.statsText;

        }

        //Function called during the Search State
        public void SearchPhase()
        {//BattleOrderTextBox text is set to ""
            BattleOrderTextBox.Text = "";
            //BattleOrderTextBox text is set to "Order Of Battle: "
            BattleOrderTextBox.Text = "Order Of Battle: ";
            //Battle party sorted by speed to produce attack order 
            refer.u.ulParticipants = SortBySpeed(refer.BattleReadyParty);
            //Loop through the list
                for (int i = 0; i < refer.u.ulParticipants.Count; i++)
                {//Set the BattleOrderTextBox text to a newline with the current units name then another new line
                    BattleOrderTextBox.Text += "\n" + refer.u.ulParticipants[i].sName + "\n";
                }
                //Foreach unit in the list
                foreach (Unit i in refer.u.ulParticipants)
                {//If the current unit is of type Player
                    if (i.sType == "Player")
                    {//Add the unit to this party
                        ulPlayerParty.Add(i);

                    }
                    //If the current unit is of type Enemy
                    if (i.sType == "Enemy")
                    {//Add the unit to this party
                    ulEnemyParty.Add(i);
                    }

                }

                //Set the Enemy1Label text to the given index of the enemyParty list
                Enemy1Label.Text = ulEnemyParty[0].sName;
                //Set the Enemy2Label text to the given index of the enemyParty list
                Enemy2Label.Text = ulEnemyParty[1].sName;
                //Set the Enemy3Label text to the given index of the enemyParty list
                Enemy3Label.Text = ulEnemyParty[2].sName;

                //Call setImages function to set all units in the list with proper pictures
                setImages(refer.u.ulParticipants);
                
                //Call Function to print out the stats of all objects in battle
                refer.manager.StatsOfObjects(refer.u.ulParticipants);

                //Set the StatsBox text variable to the data in the statsText variable
                StatsBox.Text = refer.manager.statsText;
                
                //Call the FirstAttack function to get the battle started
                FirstAttack(refer.u.ulParticipants);
            }

        //Function called during the Exit state
        public void ExitPhase()
        {//Function called to quit the application
            Application.Exit();
        }

        //Function called when the Main Menu Button is clicked
        private void MainMenuButton_Click(object sender, EventArgs e)
        {//Change state back start
                refer.fsm.Feed("start");

            
        }

        //Function used to check the which object goes first based on higher speed stat
        public List<Unit> SortBySpeed(List<Unit> uList)
        {
            //Create a new list<Unit>
            List<Unit> sortedlist = new List<Unit>();
            //Set the new list to the passed in list ordered by highest speed stat first
            sortedlist = uList.OrderByDescending(u => u.iSpeed).ToList<Unit>();
            //Return the new sorted list
            return sortedlist;
        }
    }
}
