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

                foreach(Coord m in mice)
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
    }
}
