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
        //bool variable to determine how the user got to this form
        public bool needHelp = false;

        public string character;

        private string newDirectory;
        public controlsForm()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }

        private void newGameLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if the user is on this form because it is their first time playing
            if (!needHelp)
            {
                //create instance of gamePage form
                gamePage game = new gamePage();
                //define character variable on next form and congragulationsForm
                game.characterChosen = character;
                //close this form and open next controls form
                game.ShowDialog();
                this.Close();
            }
            //if the user is on this form because they clicked the need help link on the gamePage
            else
            {
                //return bool variable back to false
                needHelp = false;
                //only close this form to keep progress
                this.Close();
            }
        }

        private void continueGameLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void controlsForm_Load(object sender, EventArgs e)
        {
            //need to add animations to gamePage form and update controlsForm

            //THIS CODE ALLOWS THE DIRECTORY TO BE CORRECT REGARDLESS OF THE COMPUTER OR USER
            //retrive current directory
            string currentDirectory = Environment.CurrentDirectory;
            //make it so that the newDirectory deletes everything past the first 'Darth Vader Puzzle'
            newDirectory = currentDirectory.Replace("\\", "/");
            newDirectory = newDirectory.Replace("Darth Vader Puzzle/bin/Debug/net6.0-windows", "");
        }

        private void instructionsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
