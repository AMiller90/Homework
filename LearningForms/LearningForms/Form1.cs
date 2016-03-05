using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LearningForms
{




    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (e.GetType() == typeof(MouseEventArgs))
            {
                string coordinates;

                MouseEventArgs me = e as MouseEventArgs;

                //textOutput.Text += me.Location.ToString();
                coordinates = me.Location.ToString();

                Coord mouse = new Coord(coordinates);

                List<Coord> mice = new List<Coord>();
                mice.Add(mouse);

                foreach (Coord m in mice)
                {
                    textOutput.Text += m.mouseCo;
                }
            }
        }

        public class Coord
        {
            public Coord(string s)
            {
                mouseCo = s;
            }

            public string mouseCo;


        }

        public void Save()
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt) | *.txt | All files (*.*) |*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    UnicodeEncoding uni = new UnicodeEncoding();
                    byte[] sizeText = uni.GetBytes(textOutput.Text);

                    // Code to write to the stream goes here.
                    myStream.Write(sizeText, 0, sizeText.Length);
                    myStream.Close();
                }
            }
        }


        private void clearButton_Click(object sender, EventArgs e)
        {
            textOutput.Text = null;

        }

        private void textOutput_KeyPress(object sender, KeyPressEventArgs e)
        {
             if (e.KeyChar == (char)Keys.X)
            {
                // Ensure that text is currently selected in the text box.   
                if (textOutput.SelectedText != "")
                {
                    // Cut the selected text in the control and paste it into the Clipboard.
                    textOutput.Cut();
                }
            }
            else if (e.KeyChar == (char)Keys.V)
            {
                // Determine if there is any text in the Clipboard to paste into the text box.
                if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
                {
                    // Determine if any text is selected in the text box.
                    if (textOutput.SelectionLength > 0)
                    {
                        // Ask user if they want to paste over currently selected text.
                        if (MessageBox.Show("Do you want to paste over current selection?", "Cut Example", MessageBoxButtons.YesNo) == DialogResult.No)
                            // Move selection to the point after the current selection and paste.
                            textOutput.SelectionStart = textOutput.SelectionStart + textOutput.SelectionLength;
                    }
                    // Paste current text in Clipboard into text box.
                    textOutput.Paste();
                    
                }
            }
        }

        private void textOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
