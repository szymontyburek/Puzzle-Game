using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Darth_Vader_Puzzle
{
    public partial class congragulationsForm : Form
    {
        public congragulationsForm()
        {
            InitializeComponent();
        }

        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            //exit app
            Application.Exit();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            //open gamePageForm
            gamePage game = new gamePage();
            game.ShowDialog();
        }

        private void congragulationsForm_Load(object sender, EventArgs e)
        {
            //stretch and set the gif for the PB
            dvGifPB.SizeMode = PictureBoxSizeMode.StretchImage;
            dvGifPB.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader.gif";
            //play imperial march
            SoundPlayer outro = new SoundPlayer("C:/Users/szymo/Desktop/C/Darth Vader Puzzle/congragulationsFormWAVTrack.wav");
            outro.PlayLooping();
        }
    }
}
