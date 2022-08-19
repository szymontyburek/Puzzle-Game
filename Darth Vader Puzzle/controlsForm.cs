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
            //hide this form
            this.Hide();
            //open the gamePage form
            gamePage game = new gamePage();
            game.ShowDialog();
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





            //set and stretch down arrow gif image to DAPB1/2/3
            DAPB1.SizeMode = PictureBoxSizeMode.StretchImage; DAPB2.SizeMode = PictureBoxSizeMode.StretchImage; DAPB3.SizeMode = PictureBoxSizeMode.StretchImage;
            DAPB1.ImageLocation = newDirectory + "downArrow.gif";
            DAPB2.ImageLocation = newDirectory + "downArrow.gif";
            DAPB3.ImageLocation = newDirectory + "downArrow.gif";
        }
    }
}
