using System.Media;

namespace Darth_Vader_Puzzle
{
    public partial class HomePage : Form
    {
       string newDirectory;
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gamePage game = new gamePage();
            game.ShowDialog();

            //THIS CODE ALLOWS THE DIRECTORY TO BE CORRECT REGARDLESS OF THE COMPUTER OR USER
            //retrive current directory
            string currentDirectory = Environment.CurrentDirectory;
            //make it so that the newDirectory deletes everything past the first 'Darth Vader Puzzle'
            newDirectory = currentDirectory.Replace("\\", "/");
            newDirectory = newDirectory.Replace("Darth Vader Puzzle/bin/Debug/net6.0-windows", "");


            //set and stretch gif for gifPB
            gifPB.SizeMode = PictureBoxSizeMode.StretchImage;
            gifPB.ImageLocation = newDirectory + "dvGif.gif";
            //play wav track set for this form
            SoundPlayer intro = new SoundPlayer(newDirectory + "homePageWAVTrack.wav");
            intro.PlayLooping();
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();
            //create an instance of controlsForm
            controlsForm controls = new controlsForm();
            //make the startedAGame bool variable on the controlsForm false
            controls.startedAGame = false;
            //open controlsForm
            controls.ShowDialog();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();
            //open the gamePage form
            gamePage newGame = new gamePage();
            newGame.ShowDialog();
        }
    }
}