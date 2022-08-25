using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darth_Vader_Puzzle
{
    public partial class controlsForm : Form
    {
        //bool variable that'll determine whether to open gamePage to start a new game or to just close the controlsForm to continue the
        //game that has already begun
        public bool startedAGame;

        string newDirectory;
        public controlsForm()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }

        private void newGameLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (startedAGame)
            {
                //close the form
                this.Close();
            }
            else
            {
                //hide the form
                this.Hide();
                //open gamePage
                gamePage game = new gamePage();
                game.ShowDialog();
            }
        }

        private void continueGameLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //close the current form to keep game progress
            this.Close();
        }

        private void controlsForm_Load(object sender, EventArgs e)
        {
            //THIS CODE ALLOWS THE DIRECTORY TO BE CORRECT REGARDLESS OF THE COMPUTER OR USER
            //retrive current directory
            string currentDirectory = Environment.CurrentDirectory;
            //make it so that the newDirectory deletes everything past the first 'Darth Vader Puzzle'
            newDirectory = currentDirectory.Replace("\\", "/");
            newDirectory = newDirectory.Replace("Darth Vader Puzzle/bin/Debug/net6.0-windows", "");
        }
    }
}
