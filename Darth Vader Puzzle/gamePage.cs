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
            
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }
    }
}
