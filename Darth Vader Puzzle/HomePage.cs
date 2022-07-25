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
            //open the gamePage form
            gamePage newGame = new gamePage();
            newGame.ShowDialog();
        }

        private void controlsButton_Click(object sender, EventArgs e)
        {
            //open the controlsPage form
            controlsPage controls = new controlsPage();
            controls.ShowDialog();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            //open the gamePage form
            gamePage newGame = new gamePage();
            newGame.ShowDialog();
        }
    }
}