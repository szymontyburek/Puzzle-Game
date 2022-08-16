using System.Media;

namespace Darth_Vader_Puzzle
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set and stretch gif for gifPB
            gifPB.SizeMode = PictureBoxSizeMode.StretchImage;
            gifPB.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/dvGif.gif";
            //play wav track set for this form
            SoundPlayer intro = new SoundPlayer("C:/Users/szymo/Desktop/C/Darth Vader Puzzle/homePageWAVTrack.wav");
            intro.PlayLooping();
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            //hide this form
            this.Hide();
            //open the controlsPage form
            controlsForm controls = new controlsForm();
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