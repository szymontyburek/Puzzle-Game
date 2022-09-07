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
    public partial class chooseImageForm : Form
    {
        public chooseImageForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            
        }

        private void darthVaderRB_CheckedChanged(object sender, EventArgs e)
        {
            //create instance of gamePage form
            gamePage game = new gamePage();
            game.characterChosen = "darthVader";
            game.ShowDialog();
        }
    }
}
