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
    public partial class gamePage : Form
    {
        public gamePage()
        {
            InitializeComponent();
        }

        private void gamePage_Load(object sender, EventArgs e)
        {
            //backButtonDescription label text input
            backButtonDescriptionLabel.Text = "With this button you have the ability to put board pieces back into the box. To do so, click on a board piece, make sure that is highlighted, then press the back button.";
            //clockwiseRotationButtonDescription label text input
            rotationButtonDescriptionLabel.Text = "With this button you have the ability to rotation pieces both on the board and box section. To do so, click on a board piece, make sure that it is highlighted, then press the rotate button and the picture will rotate 90 degrees.";
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            //if the listBox is visible
            if (menuListBox.Visible)
            {
                //make the listBox invisible
                menuListBox.Visible = false;
            }
            //if the listbox is not visible
            else
            {
                //make it visible
                menuListBox.Visible = true;
            }
        }
    }
}
