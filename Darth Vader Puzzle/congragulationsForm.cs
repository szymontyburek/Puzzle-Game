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
        string newDirectory;
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
            //THIS CODE ALLOWS THE DIRECTORY TO BE CORRECT REGARDLESS OF THE COMPUTER OR USER
            //retrive current directory
            string currentDirectory = Environment.CurrentDirectory;
            //make it so that the newDirectory deletes everything past the first 'Darth Vader Puzzle'
            newDirectory = currentDirectory.Replace("\\", "/");
            newDirectory = newDirectory.Replace("Darth Vader Puzzle/bin/Debug/net6.0-windows", "");




            //stretch and set the gif for the PB
            dvGifPB.SizeMode = PictureBoxSizeMode.StretchImage;
            dvGifPB.ImageLocation = newDirectory + "darthVader.gif";
            //play imperial march
            SoundPlayer outro = new SoundPlayer(newDirectory + "congragulationsFormWAVTrack.wav");
            outro.PlayLooping();
        }
    }
}
