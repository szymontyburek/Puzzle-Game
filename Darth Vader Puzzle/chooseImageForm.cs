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
            //create an instance of openFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //open computer files
            openFileDialog1.ShowDialog();
            string filePath = openFileDialog1.FileName;
            //open gamePage
            gamePage game = new gamePage();
            game.ShowDialog();
        }
    }
}
