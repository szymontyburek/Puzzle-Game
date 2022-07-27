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
        //bool variable to signify that borders have been set
        private bool bordersSet = false;
        //8 counter variables that will count the clicks of each PB, so a double click will unhighlight the PB
        int PB1ClickCounter, PB2ClickCounter, PB3ClickCounter, PB4ClickCounter, PB5ClickCounter, PB6ClickCounter, PB7ClickCounter, PB8ClickCounter, PB9ClickCounter, PB1TestClickCounter, PB2TestClickCounter, PB3TestClickCounter, PB4TestClickCounter, PB5TestClickCounter, PB7TestClickCounter, PB8TestClickCounter, PB9TestClickCounter = 0;
        //create an integer array that determines the placement of the puzzle pieces
        int[] shufflePuzzlePieces = new int[9];
        public gamePage()
        {
            InitializeComponent();
        }
        private void shuffleGenerator()
        {
            //create a random object
            Random rand = new Random();
            //create a for loop
            for (int i = 0; i < shufflePuzzlePieces.Length; i++)
            {
                //generate a random number for each array element in the range of 1 - 9
                shufflePuzzlePieces[i] = rand.Next(1, 10);
                //if i = 1 and the random number generated already matches the previously generated number
                if (i == 1)
                {
                    //create a while loop so a new number will be generated until it does not match any previously generated number
                    while (shufflePuzzlePieces[i] == shufflePuzzlePieces[0])
                    {
                        shufflePuzzlePieces[i] = rand.Next(1, 10);
                    }
                }
                //if i = 2 and the random number generated already matches the previously generated numbers
                else if (i == 2)
                {
                    //create a while loop so a new number will be generated until it does not match any previously generated number
                    while (shufflePuzzlePieces[i] == shufflePuzzlePieces[0] || shufflePuzzlePieces[i] == shufflePuzzlePieces[1])
                    {
                        shufflePuzzlePieces[i] = rand.Next(1, 10);
                    }
                }
                //if i = 3 and the random number generated already matches the previously generated numbers
                else if (i == 3)
                {
                    //create a while loop so a new number will be generated until it does not match any previously generated number
                    while (shufflePuzzlePieces[i] == shufflePuzzlePieces[0] || shufflePuzzlePieces[i] == shufflePuzzlePieces[1] || shufflePuzzlePieces[i] == shufflePuzzlePieces[2])
                    {
                        shufflePuzzlePieces[i] = rand.Next(1, 10);
                    }
                }
                //if i = 4 and the random number generated already matches the previously generated numbers
                else if (i == 4)
                {
                    //create a while loop so a new number will be generated until it does not match any previously generated number
                    while (shufflePuzzlePieces[i] == shufflePuzzlePieces[0] || shufflePuzzlePieces[i] == shufflePuzzlePieces[1] || shufflePuzzlePieces[i] == shufflePuzzlePieces[2] || shufflePuzzlePieces[i] == shufflePuzzlePieces[3])
                    {
                        shufflePuzzlePieces[i] = rand.Next(1, 10);
                    }
                }
                //if i = 5 and the random number generated already matches the previously generated numbers
                else if (i == 5)
                {
                    //create a while loop so a new number will be generated until it does not match any previously generated number
                    while (shufflePuzzlePieces[i] == shufflePuzzlePieces[0] || shufflePuzzlePieces[i] == shufflePuzzlePieces[1] || shufflePuzzlePieces[i] == shufflePuzzlePieces[2] || shufflePuzzlePieces[i] == shufflePuzzlePieces[3] || shufflePuzzlePieces[i] == shufflePuzzlePieces[4])
                    {
                        shufflePuzzlePieces[i] = rand.Next(1, 10);
                    }
                }
                //if i = 6 and the random number generated already matches the previously generated numbers
                else if (i == 6)
                {
                    //create a while loop so a new number will be generated until it does not match any previously generated number
                    while (shufflePuzzlePieces[i] == shufflePuzzlePieces[0] || shufflePuzzlePieces[i] == shufflePuzzlePieces[1] || shufflePuzzlePieces[i] == shufflePuzzlePieces[2] || shufflePuzzlePieces[i] == shufflePuzzlePieces[3] || shufflePuzzlePieces[i] == shufflePuzzlePieces[4] || shufflePuzzlePieces[i] == shufflePuzzlePieces[5])
                    {
                        shufflePuzzlePieces[i] = rand.Next(1, 10);
                    }
                }
                //if i = 7 and the random number generated already matches the previously generated numbers
                else if (i == 7)
                {
                    //create a while loop so a new number will be generated until it does not match any previously generated number
                    while (shufflePuzzlePieces[i] == shufflePuzzlePieces[0] || shufflePuzzlePieces[i] == shufflePuzzlePieces[1] || shufflePuzzlePieces[i] == shufflePuzzlePieces[2] || shufflePuzzlePieces[i] == shufflePuzzlePieces[3] || shufflePuzzlePieces[i] == shufflePuzzlePieces[4] || shufflePuzzlePieces[i] == shufflePuzzlePieces[5] || shufflePuzzlePieces[i] == shufflePuzzlePieces[6])
                    {
                        shufflePuzzlePieces[i] = rand.Next(1, 10);
                    }
                }
                //if i = 8 and the random number generated already matches the previously generated numbers
                else if (i == 8)
                {
                    //create a while loop so a new number will be generated until it does not match any previously generated number
                    while (shufflePuzzlePieces[i] == shufflePuzzlePieces[0] || shufflePuzzlePieces[i] == shufflePuzzlePieces[1] || shufflePuzzlePieces[i] == shufflePuzzlePieces[2] || shufflePuzzlePieces[i] == shufflePuzzlePieces[3] || shufflePuzzlePieces[i] == shufflePuzzlePieces[4] || shufflePuzzlePieces[i] == shufflePuzzlePieces[5] || shufflePuzzlePieces[i] == shufflePuzzlePieces[6] || shufflePuzzlePieces[i] == shufflePuzzlePieces[7])
                    {
                        shufflePuzzlePieces[i] = rand.Next(1, 10);
                    }
                }
                //if i = 9 and the random number generated already matches the previously generated numbers
                else if (i == 9)
                {
                    //create a while loop so a new number will be generated until it does not match any previously generated number
                    while (shufflePuzzlePieces[i] == shufflePuzzlePieces[0] || shufflePuzzlePieces[i] == shufflePuzzlePieces[1] || shufflePuzzlePieces[i] == shufflePuzzlePieces[2] || shufflePuzzlePieces[i] == shufflePuzzlePieces[3] || shufflePuzzlePieces[i] == shufflePuzzlePieces[4] || shufflePuzzlePieces[i] == shufflePuzzlePieces[5] || shufflePuzzlePieces[i] == shufflePuzzlePieces[6] || shufflePuzzlePieces[i] == shufflePuzzlePieces[7] || shufflePuzzlePieces[i] == shufflePuzzlePieces[8])
                    {
                        shufflePuzzlePieces[i] = rand.Next(1, 10);
                    }
                }
            }
            //use placeShuffleOntoPieces module regarding the first generated number
            placeShuffleOntoPieces(0, PB1);
            //use placeShuffleOntoPieces module regarding the second generated number
            placeShuffleOntoPieces(1, PB2);
            //use placeShuffleOntoPieces module regarding the third generated number
            placeShuffleOntoPieces(2, PB3);
            //use placeShuffleOntoPieces module regarding the fourth generated number
            placeShuffleOntoPieces(3, PB4);
            //use placeShuffleOntoPieces module regarding the fifth generated number
            placeShuffleOntoPieces(4, PB5);
            //use placeShuffleOntoPieces module regarding the sixth generated number
            placeShuffleOntoPieces(5, PB6);
            //use placeShuffleOntoPieces module regarding the seventh generated number
            placeShuffleOntoPieces(6, PB7);
            //use placeShuffleOntoPieces module regarding the eigth generated number
            placeShuffleOntoPieces(7, PB8);
            //use placeShuffleOntoPieces module regarding the ninth generated number
            placeShuffleOntoPieces(8, PB9);
        }
        private void placeShuffleOntoPieces(int i, PictureBox PBNum)
        {
            //if the generated number equals 1
            if (shufflePuzzlePieces[i] == 1)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader1.png
                PBNum.ImageLocation = "darthVader1.png";
            }
            //if the generated number equals 2
            else if (shufflePuzzlePieces[i] == 2)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader2.png
                PBNum.ImageLocation = "darthVader2.png";
            }
            //if the generated number equals 3
            else if (shufflePuzzlePieces[i] == 3)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader3.png
                PBNum.ImageLocation = "darthVader3.png";
            }
            //if the generated number equals 4
            else if(shufflePuzzlePieces[i] == 4)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader4.png
                PBNum.ImageLocation = "darthVader4.png";
            }
            //if the generated number equals 5
            if (shufflePuzzlePieces[i] == 5)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader5.png
                PBNum.ImageLocation = "darthVader5.png";
            }
            //if the generated number equals 6
            else if (shufflePuzzlePieces[i] == 6)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader6.png
                PBNum.ImageLocation = "darthVader6.png";
            }
            //if the generated number equals 7
            else if (shufflePuzzlePieces[i] == 7)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader7.png
                PBNum.ImageLocation = "darthVader7.png";
            }
            //if the generated number equals 8
            else if (shufflePuzzlePieces[i] == 8)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader8.png
                PBNum.ImageLocation = "darthVader8.png";
            }
            //if the generated number equals 9
            else
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader9.png
                PBNum.ImageLocation = "darthVader9.png";
            }
        }
        private void rotationShuffleGenerator(PictureBox PB)
        {
            //WORK ON THIS MODULE, IT'S ACTING REALLY FUNKY
            //create a random object
            Random rand = new Random();

            int i = rand.Next(0, 4);
            if (i == 0)
            {
                //change PB.ImageLocation ending from .png to Rotated90.png to rotate the image 90 degrees
                PB.ImageLocation = PB.ImageLocation.Replace(".png", "Rotated90.png");
            }
            //if the current element in the array got a 2
            else if (i == 1)
            {
                //change PB.ImageLocation ending from .png to Rotated180.png to rotate the image 180 degrees
                PB.ImageLocation = PB.ImageLocation.Replace(".png", "Rotated180.png");
            }
            //if the current element in the array got a 3
            else if (i == 2)
            {
                //change PB.ImageLocation ending from .png to Rotated270.png to rotate the image 270 degrees
                PB.ImageLocation = PB.ImageLocation.Replace(".png", "Rotated270.png");
            }
            else
            {
                PB.ImageLocation = PB.ImageLocation;
            }

        }
        private void makeAllBordersInvisible()
        {
            //set all clickCounter variables back to zero
            PB1ClickCounter = 0; PB2ClickCounter = 0; PB3ClickCounter = 0; PB4ClickCounter = 0; PB5ClickCounter = 0; PB6ClickCounter = 0; PB7ClickCounter = 0; PB8ClickCounter = 0; PB9ClickCounter = 0; PB1TestClickCounter = 0; PB2TestClickCounter = 0; PB3TestClickCounter = 0; PB4TestClickCounter = 0; PB5TestClickCounter = 0; PB7TestClickCounter = 0; PB8TestClickCounter = 0; PB9TestClickCounter = 0;
            //set bordersSet variable back to false
            bordersSet = false;
            PB2TestBorder1.Visible = false; PB2TestBorder2.Visible = false; PB2TestBorder3.Visible = false; PB2TestBorder4.Visible = false;
            PB1TestBorder1.Visible = false; PB1TestBorder2.Visible = false; PB1TestBorder3.Visible = false; PB1TestBorder4.Visible = false;
            PB3TestBorder1.Visible = false; PB3TestBorder2.Visible = false; PB3TestBorder3.Visible = false; PB3TestBorder4.Visible = false;
            PB4TestBorder1.Visible = false; PB4TestBorder2.Visible = false; PB4TestBorder3.Visible = false; PB4TestBorder4.Visible = false;
            PB5TestBorder1.Visible = false; PB5TestBorder2.Visible = false; PB5TestBorder3.Visible = false; PB5TestBorder4.Visible = false;
            PB6TestBorder1.Visible = false; PB6TestBorder2.Visible = false; PB6TestBorder3.Visible = false; PB6TestBorder4.Visible = false;
            PB7TestBorder1.Visible = false; PB7TestBorder2.Visible = false; PB7TestBorder3.Visible = false; PB7TestBorder4.Visible = false;
            PB8TestBorder1.Visible = false; PB8TestBorder2.Visible = false; PB8TestBorder3.Visible = false; PB8TestBorder4.Visible = false;
            PB2Border1.Visible = false; PB2Border2.Visible = false; PB2Border3.Visible = false; PB2Border4.Visible = false;
            PB1Border1.Visible = false; PB1Border2.Visible = false; PB1Border3.Visible = false; PB1Border4.Visible = false;
            PB3Border1.Visible = false; PB3Border2.Visible = false; PB3Border3.Visible = false; PB3Border4.Visible = false;
            PB4Border1.Visible = false; PB4Border2.Visible = false; PB4Border3.Visible = false; PB4Border4.Visible = false;
            PB5Border1.Visible = false; PB5Border2.Visible = false; PB5Border3.Visible = false; PB5Border4.Visible = false;
            PB6Border1.Visible = false; PB6Border2.Visible = false; PB6Border3.Visible = false; PB6Border4.Visible = false;
            PB7Border1.Visible = false; PB7Border2.Visible = false; PB7Border3.Visible = false; PB7Border4.Visible = false;
            PB8Border1.Visible = false; PB8Border2.Visible = false; PB8Border3.Visible = false; PB8Border4.Visible = false;
        }
        private void clickEventBetweenBoardPieces(Label highlightedPBBorder, PictureBox highlightedPB, PictureBox clickedPB)
        {
            //if clickedPB is clicked and the borders are visible on highlightedPB
            if (highlightedPBBorder.Visible)
            {
                //if there is an image on clickedPB
                if (clickedPB.ImageLocation != null)
                {
                    //mark the imageLocation of the 2 picturebox's into strings
                    string imageLocation2 = clickedPB.ImageLocation.ToString();
                    string imageLocation1 = highlightedPB.ImageLocation.ToString();
                    //switch the location of the 2 picturebox's involved
                    clickedPB.ImageLocation = imageLocation1;
                    highlightedPB.ImageLocation = imageLocation2;
                }
                //if there is not an image on clickedPB
                if (clickedPB.ImageLocation == null)
                {
                    //mark the imageLocation of the 2 picturebox's into strings
                    string imageLocation2 = "null";
                    string imageLocation1 = highlightedPB.ImageLocation.ToString();
                    //switch the location of the 2 picturebox's involved
                    clickedPB.ImageLocation = imageLocation1;
                    highlightedPB.ImageLocation = imageLocation2;
                }
                //make the borders invisible
                makeAllBordersInvisible();
            }
        }
        private void gamePage_Load(object sender, EventArgs e)
        {
            //to shuffle the box pieces
            shuffleGenerator();
            PB1.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVader1.png
            PB1.ImageLocation = "darthVader1.png";
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }
    }
}
