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

        }
    }
}
