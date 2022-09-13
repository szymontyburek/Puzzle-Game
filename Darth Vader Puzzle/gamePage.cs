﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Darth_Vader_Puzzle
{
    public partial class gamePage : Form
    {
        //variables for moving picturebox's with the click and drag of the mouse
        private bool _moving;
        private Point _startLocation;
        //variables for moving picturebox's with the click and drag of the mouse
        private int _xPos;
        private int _yPos;
        private bool _dragging;

        //variable to represent the character chosen on the previous form
        public string characterChosen;
        //so the code related to this variable only has to written once and not every time it needs to be used
        string newDirectory;
        //create an integer array that determines the placement of the puzzle pieces
        int[] shufflePuzzlePieces = new int[9];
        private void PB6_Click(object sender, EventArgs e)
        {

        }

        private void PB7_Click(object sender, EventArgs e)
        {

        }

        private void PB8_Click(object sender, EventArgs e)
        {
            hightlightPB(PB8);
        }
        private void mouseClickAndDrag(PictureBox PB)
        {
            // Register mouse events
            PB.MouseUp += (sender, args) =>
            {
                var c = sender as PictureBox;
                if (null == c) return;
                _dragging = false;
            };

            PB.MouseDown += (sender, args) =>
            {
                if (args.Button != MouseButtons.Left) return;
                _dragging = true;
                _xPos = args.X;
                _yPos = args.Y;
            };

            PB.MouseMove += (sender, args) =>
            {
                var c = sender as PictureBox;
                if (!_dragging || null == c) return;
                c.Top = args.Y + c.Top - _yPos;
                c.Left = args.X + c.Left - _xPos;
            };
        }
       

        private void PB1Test_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB1Test);
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB2Test_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB2Test);
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB3Test_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB3Test);
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB4Test_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB4Test);
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB5Test_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB5Test);
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB6Test_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB6Test);
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB7Test_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB7Test);
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB8Test_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB8Test);
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }
        private void backButtonModule(Label PBTestBorder, PictureBox PBTest, PictureBox PB)
        {
            //if a board piece is selected and it has an image on it
            if (PBTestBorder.Visible && PBTest.ImageLocation != null)
            {
                //if the selected board piece and a puzzle piece have the same image(this will be determined by finding out
                //if their imageLocation property contains the same number(ex: one, two, three, etc..)), regardless of rotation
                if (PBTest.ImageLocation.Contains("One") && PB.ImageLocation.Contains("One") || PBTest.ImageLocation.Contains("Two") && PB.ImageLocation.Contains("Two") || PBTest.ImageLocation.Contains("Three") && PB.ImageLocation.Contains("Three") || PBTest.ImageLocation.Contains("Four") && PB.ImageLocation.Contains("Four") || PBTest.ImageLocation.Contains("Five") && PB.ImageLocation.Contains("Five") || PBTest.ImageLocation.Contains("Six") && PB.ImageLocation.Contains("Six") || PBTest.ImageLocation.Contains("Seven") && PB.ImageLocation.Contains("Seven") || PBTest.ImageLocation.Contains("Eight") && PB.ImageLocation.Contains("Eight") || PBTest.ImageLocation.Contains("Nine") && PB.ImageLocation.Contains("Nine"))
                {
                    //change the puzzle piece imageLocation to the board piece imageLocation so the rotation of the piece will be transferred
                    PB.ImageLocation = PBTest.ImageLocation;
                    //make the piece visible
                    PB.Visible = true;
                    //make the board piece image blank
                    PBTest.ImageLocation = null;
                    //make the border invisible
                    UnhighlightAllBorders();
                }
            }
        }
        private void determinePuzzleProgress()
        {
            //THIS MODULE TESTS IF THE PB'S ARE ALL IN THE CORRECT SPOT AND ORIENTATION EVERY TIME A PUZZLE PIECE IS PLACED
            if (PB1Test.ImageLocation == newDirectory + characterChosen + "One.jpg")
            {
                if (PB2Test.ImageLocation == newDirectory + characterChosen + "Two.jpg")
                {
                    if (PB3Test.ImageLocation == newDirectory + characterChosen + "Three.jpg")
                    {
                        if (PB4Test.ImageLocation == newDirectory + characterChosen + "Four.jpg")
                        {
                            if (PB5Test.ImageLocation == newDirectory + characterChosen + "Five.jpg")
                            {
                                if (PB6Test.ImageLocation == newDirectory + characterChosen + "Six.jpg")
                                {
                                    if (PB7Test.ImageLocation == newDirectory + characterChosen + "Seven.jpg")
                                    {
                                        if (PB8Test.ImageLocation == newDirectory + characterChosen + "Eight.jpg")
                                        {
                                            if (PB9Test.ImageLocation == newDirectory + characterChosen + "Nine.jpg")
                                            {
                                                //unhighlight any picturebox's that may be highlighted
                                                UnhighlightAllBorders();
                                                //hide this form
                                                this.Hide();
                                                //open congragulations form
                                                congragulationsForm congrats = new congragulationsForm();  
                                                congrats.ShowDialog();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
        }

        private void clockwiseRotation(Label PBBorder, PictureBox PB)
        {
            //if any picturebox is highlighted
            if (PBBorder.Visible)
            {
                //stretch the imagelayout through code so the rotated images have the same layout as the original
                PB.SizeMode = PictureBoxSizeMode.StretchImage;
                //if the imageLocation of the picturebox equals rotated90.jpg
                if (PB.ImageLocation.EndsWith("Rotated90.jpg"))
                {
                    //replace the Rotated90.jpg ending with Rotated180.jpg
                    PB.ImageLocation = PB.ImageLocation.Replace("Rotated90.jpg", "Rotated180.jpg");
                }
                //if the imageLocation of the picturebox equals rotated180.jpg
                else if (PB.ImageLocation.EndsWith("Rotated180.jpg"))
                {
                    //replace the Rotated180.jpg ending with Rotated270.jpg
                    PB.ImageLocation = PB.ImageLocation.Replace("Rotated180.jpg", "Rotated270.jpg");
                }
                //if the imageLocation of the picturebox equals rotated270.jpg
                else if (PB.ImageLocation.EndsWith("Rotated270.jpg"))
                {
                    //replace the Rotated270.jpg ending with .jpg
                    PB.ImageLocation = PB.ImageLocation.Replace("Rotated270.jpg", ".jpg");
                }
                else
                {
                    //if the imageLocation of the picturebox equals .jpg
                    //replace the .jpg ending with Rotated90.jpg
                    PB.ImageLocation = PB.ImageLocation.Replace(".jpg", "Rotated90.jpg");
                }
            }
        }

        private void needHelpLL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //create an instance of controlsForm
            controlsForm controls = new controlsForm();
            //make the startedAGame bool variable on the controlsForm false
            controls.startedAGame = true;
            //open controlsForm
            controls.ShowDialog();
        }

        private void rotationButton_Click(object sender, EventArgs e)
        {
            //clockwise rotation for the box pieces

            //in case the last piece is finished by rotating it when it's already on the board
            determinePuzzleProgress();
        }

        private void PB9Test_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB9Test);
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB9_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB9);
        }

        private void PB5_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB5);
        }

        private void PB4_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB4);
        }

        private void PB3_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB3);
        }
        private void PB2_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight this picturebox depending on whether the borderStyle is none or fixed3D
            hightlightPB(PB2);
        }
        private void hightlightPB(PictureBox PB)
        {
            if (PB.BorderStyle == BorderStyle.None)
            {
                //hightlight the border
                PB.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (PB.BorderStyle == BorderStyle.Fixed3D)
            {
                //unhighlight the border
                PB.BorderStyle = BorderStyle.None;
            }
        }
        private void PB1_Click(object sender, EventArgs e)
        {
            //highlight or unhighlight the PB depending on the Borderstyle
            hightlightPB(PB1);
        }
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
            //the use of this modules will connect the random number generated to an image and a picturebox
            placeShuffleOntoPieces(0, PB1);
            placeShuffleOntoPieces(1, PB2);
            placeShuffleOntoPieces(2, PB3);
            placeShuffleOntoPieces(3, PB4);
            placeShuffleOntoPieces(4, PB5);
            placeShuffleOntoPieces(5, PB6);
            placeShuffleOntoPieces(6, PB7);
            placeShuffleOntoPieces(7, PB8);
            placeShuffleOntoPieces(8, PB9);
        }
        private void placeShuffleOntoPieces(int i, PictureBox PBNum)
        {
            //if the generated number equals 1
            if (shufflePuzzlePieces[i] == 1)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal characterChosen + "One.jpg"
                PBNum.ImageLocation = newDirectory + characterChosen + "One.jpg";
            }
            //if the generated number equals 2
            else if (shufflePuzzlePieces[i] == 2)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal characterChosen + "Two.jpg"
                PBNum.ImageLocation = newDirectory + characterChosen + "Two.jpg";
            }
            //if the generated number equals 3
            else if (shufflePuzzlePieces[i] == 3)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal characterChosen + "Three.jpg"
                PBNum.ImageLocation = newDirectory + characterChosen + "Three.jpg";
            }
            //if the generated number equals 4
            else if (shufflePuzzlePieces[i] == 4)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal characterChosen + "Four.jpg"
                PBNum.ImageLocation = newDirectory + characterChosen + "Four.jpg";
            }
            //if the generated number equals 5
            if (shufflePuzzlePieces[i] == 5)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal characterChosen + "Five.jpg"
                PBNum.ImageLocation = newDirectory + characterChosen + "Five.jpg";
            }
            //if the generated number equals 6
            else if (shufflePuzzlePieces[i] == 6)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal characterChosen + "Six.jpg"
                PBNum.ImageLocation = newDirectory + characterChosen + "Six.jpg";
            }
            //if the generated number equals 7
            else if (shufflePuzzlePieces[i] == 7)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal characterChosen + "Seven.jpg"
                PBNum.ImageLocation = newDirectory + characterChosen + "Seven.jpg";
            }
            //if the generated number equals 8
            else if (shufflePuzzlePieces[i] == 8)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal characterChosen + "Eight.jpg"
                PBNum.ImageLocation = newDirectory + characterChosen + "Eight.jpg";
            }
            //if the generated number equals 9
            else if (shufflePuzzlePieces[i] == 9)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal characterChosen + "Nine.jpg"
                PBNum.ImageLocation = newDirectory + characterChosen + "Nine.jpg";
            }
        }
        private void rotationShuffleGenerator(PictureBox PB)
        {
            //create a random object
            Random rand = new Random();

            int i = rand.Next(0, 4);
            if (i == 0)
            {
                //change PB.ImageLocation ending from .jpg to Rotated180.jpg to rotate the image 180 degrees
                PB.ImageLocation = PB.ImageLocation.Replace(".jpg", "Rotated90.jpg");
            }
            //if the current element in the array got a 2
            else if (i == 1)
            {
                //change PB.ImageLocation ending from .jpg to Rotated180.jpg to rotate the image 180 degrees
                PB.ImageLocation = PB.ImageLocation.Replace(".jpg", "Rotated180.jpg");
            }
            //if the current element in the array got a 3
            else if (i == 2)
            {
                //change PB.ImageLocation ending from .jpg to Rotated270.jpg to rotate the image 270 degrees
                PB.ImageLocation = PB.ImageLocation.Replace(".jpg", "Rotated270.jpg");
            }
            else
            {
                PB.ImageLocation = PB.ImageLocation;
            }

        }
        private void UnhighlightAllBorders()
        {
            PB1.BorderStyle = BorderStyle.None;
            PB2.BorderStyle = BorderStyle.None;
            PB3.BorderStyle = BorderStyle.None;
            PB4.BorderStyle = BorderStyle.None;
            PB5.BorderStyle = BorderStyle.None;
            PB6.BorderStyle = BorderStyle.None;
            PB7.BorderStyle = BorderStyle.None;
            PB8.BorderStyle = BorderStyle.None;
            PB9.BorderStyle = BorderStyle.None;

            PB1Test.BorderStyle = BorderStyle.None;
            PB2Test.BorderStyle = BorderStyle.None;
            PB3Test.BorderStyle = BorderStyle.None;
            PB4Test.BorderStyle = BorderStyle.None;
            PB5Test.BorderStyle = BorderStyle.None;
            PB6Test.BorderStyle = BorderStyle.None;
            PB7Test.BorderStyle = BorderStyle.None;
            PB8Test.BorderStyle = BorderStyle.None;
            PB9Test.BorderStyle = BorderStyle.None;
        }
        private void clickEventBetweenBoardPieces(Label highlightedPBBorder, PictureBox highlightedPB, PictureBox clickedPB, Label clickedPBBorder)
        {
            //if clickedPB is clicked and the borders are visible on highlightedPB
            if (highlightedPBBorder.Visible)
            {
                //if the highlighted picturebox has an image and the one that was just clicked on does not
                if (clickedPB.ImageLocation == null && highlightedPB.ImageLocation != null)
                {
                    //mark the imageLocation of the 2 picturebox's into strings
                    string imageLocation2 = null;
                    string imageLocation1 = highlightedPB.ImageLocation.ToString();
                    //switch the location of the 2 picturebox's involved
                    clickedPB.ImageLocation = imageLocation1;
                    highlightedPB.ImageLocation = imageLocation2;
                    //unhighlight the 'highlightedPB'
                    UnhighlightAllBorders();
                }
                //if both the highlighted and previously clicked picturebox have images on them
                else
                {
                    //unhighlight 'highlightedPB'
                    UnhighlightAllBorders();

                }
            }
        }
        private void setImagesAfterCuttingAndRotating()
        {
            //This is bitmap code to cut a given image into 9 pieces
           
            Image img = Image.FromFile(newDirectory + characterChosen + ".jpg");
            int widthThird = (int)((double)img.Width / 3.0 + 0.5);
            int heightThird = (int)((double)img.Height / 3.0 + 0.5);
            Bitmap[,] bmps = new Bitmap[3, 3];
            for (int x = 0; x < 3; x++)
                for (int j = 0; j < 3; j++)
                {
                    bmps[x, j] = new Bitmap(widthThird, heightThird);
                    Graphics g = Graphics.FromImage(bmps[x, j]);
                    g.DrawImage(img, new Rectangle(0, 0, widthThird, heightThird), new Rectangle(j * widthThird, x * heightThird, widthThird, heightThird), GraphicsUnit.Pixel);
                    g.Dispose();
                }


            //SETTING THE SLICED PICTUREBOX'S TO PB1 - PB9
            PB1.Image = bmps[0, 0];

            PB2.Image = bmps[0, 1];

            PB3.Image = bmps[0, 2];

            PB4.Image = bmps[1, 0];

            PB5.Image = bmps[1, 1];

            PB6.Image = bmps[1, 2];

            PB7.Image = bmps[2, 0];

            PB8.Image = bmps[2, 1];

            PB9.Image = bmps[2, 2];



            //Adding each picturebox image to the folder directory
            PB1.Image.Save(newDirectory + characterChosen + "One.jpg");
            PB2.Image.Save(newDirectory + characterChosen + "Two.jpg");
            PB3.Image.Save(newDirectory + characterChosen + "Three.jpg");
            PB4.Image.Save(newDirectory + characterChosen + "Four.jpg");
            PB5.Image.Save(newDirectory + characterChosen + "Five.jpg");
            PB6.Image.Save(newDirectory + characterChosen + "Six.jpg");
            PB7.Image.Save(newDirectory + characterChosen + "Seven.jpg");
            PB8.Image.Save(newDirectory + characterChosen + "Eight.jpg");
            PB9.Image.Save(newDirectory + characterChosen + "Nine.jpg");


            //Rotate PB1 - PB9 90, 180, and 270, then save each rotated image to the folder directory
            for(int i = 1; i < 10; i++)
            {
                //string variable writes out the number i in the for loop currently equals
                string num = "One";
                if(i == 1)
                {
                    num = "One";
                }
                else if(i == 2)
                {
                    num = "Two";
                }
                else if(i == 3)
                {
                    num = "Three";
                }
                else if (i == 4)
                {
                    num = "Four";
                }
                else if (i == 5)
                {
                    num = "Five";
                }
                else if (i == 6)
                {
                    num = "Six";
                }
                else if (i == 7)
                {
                    num = "Seven";
                }
                else if (i == 8)
                {
                    num = "Eight";
                }
                else if(i == 9)
                {
                    num = "Nine";
                }

                //GOING FROM REGURLAR ORIENTATION TO 90 DEGREE ORIENTATION
                //create a bitmap variable
                Bitmap bitmap1;
                //write the filepath for the image that needs to be rotated
                bitmap1 = (Bitmap)Bitmap.FromFile(newDirectory + characterChosen + num + ".jpg");
                //rotate the image 90 degrees
                bitmap1.RotateFlip(RotateFlipType.Rotate90FlipNone);
                //save the rotated image
                bitmap1.Save(newDirectory + characterChosen + num + "Rotated90.jpg");

                //GOING FROM REGURLAR ORIENTATION TO 180 DEGREE ORIENTATION
                //create a bitmap variable
                Bitmap bitmap2;
                //write the filepath for the image that needs to be rotated
                bitmap2 = (Bitmap)Bitmap.FromFile(newDirectory + characterChosen + num + ".jpg");
                //rotate the image 90 degrees
                bitmap2.RotateFlip(RotateFlipType.Rotate180FlipNone); //FIGURE THIS OUT, ROTATION IS NOT CORRECT
                //save the rotated image
                bitmap2.Save(newDirectory + characterChosen + num + "Rotated180.jpg");

                //GOING FROM REGURLAR ORIENTATION TO 270 DEGREE ORIENTATION
                //create a bitmap variable
                Bitmap bitmap3;
                //write the filepath for the image that needs to be rotated
                bitmap3 = (Bitmap)Bitmap.FromFile(newDirectory + characterChosen + num + ".jpg");
                //rotate the image 90 degrees
                bitmap3.RotateFlip(RotateFlipType.Rotate270FlipNone);
                //save the rotated image
                bitmap3.Save(newDirectory + characterChosen + num + "Rotated270.jpg");
            }
        }
        private void gamePage_Load(object sender, EventArgs e)
        {
            //double buffer the form(smoothness of mouse click and drag of PB's is improved)
            this.DoubleBuffered = true;
            //THIS CODE ALLOWS THE DIRECTORY TO BE CORRECT REGARDLESS OF THE COMPUTER OR USER
            //retrive current directory
            string currentDirectory = Environment.CurrentDirectory;
            //make it so that the newDirectory deletes everything past the first 'Darth Vader Puzzle'
            newDirectory = currentDirectory.Replace("\\", "/");
            newDirectory = newDirectory.Replace("Darth Vader Puzzle/bin/Debug/net6.0-windows", "");

            //to cut the image into 9 pieces, and rotated by 90, 180, and 270 degrees and saving all of it to folder
            setImagesAfterCuttingAndRotating();

            //play Soundtrack depending on what characterChosen equals
            if(characterChosen == "darthVader")
            {
                SoundPlayer ROTS = new SoundPlayer(newDirectory + "gamePageWAVTrack.wav");
                ROTS.PlayLooping();
            }
            else if(characterChosen == "spiderman")
            {

            }
            else if (characterChosen == "batman")
            {

            }
            else if (characterChosen == "flash")
            {

            }
            //make all the picturebox borders invisible
            UnhighlightAllBorders();
            //to shuffle the box pieces
            shuffleGenerator();
            //to mix up the orientation of the puzzle pieces
            rotationShuffleGenerator(PB1);
            rotationShuffleGenerator(PB2);
            rotationShuffleGenerator(PB3);
            rotationShuffleGenerator(PB4);
            rotationShuffleGenerator(PB5);
            rotationShuffleGenerator(PB6);
            rotationShuffleGenerator(PB7);
            rotationShuffleGenerator(PB8);
            rotationShuffleGenerator(PB9);

            PB8Test.AllowDrop = true;
            mouseClickAndDrag(PB8);
           
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
        }
        private void PB8_Move(object sender, EventArgs e)
        {
            //this event will occur, when you perform drag operation
            //PB8.DoDragDrop(PB8, DragDropEffects.Copy);
        }
        private void PB8Test_DragEnter(object sender, DragEventArgs e)
        {
            //this event will fire when you drag the mouse over this picturebox
            //e.Effect = e.AllowedEffect;
        }

        private void PB8Test_DragDrop(object sender, DragEventArgs e)
        {
            //this event will fire when you leave the mouse button, after you drag over it
            //PB8Test.SizeMode = PictureBoxSizeMode.StretchImage;
            //PB8Test.ImageLocation = PB8.ImageLocation;
        }

        private void PB8_MouseDown(object sender, MouseEventArgs e)
        {
            //WHEN ALL ELSE FAILS, THIS WORKS WITH DRAGGING
            //this event will occur, when you perform drag operation
            //PB8.DoDragDrop(PB8, DragDropEffects.Copy);

            //Register the start of the moving operation
            _moving = true;
            //remember the start location of the mouse.
            _startLocation = e.Location;
        }

        private void PB8_MouseEnter(object sender, EventArgs e)
        {
            PB8.BorderStyle = BorderStyle.Fixed3D;
        }
        private void PB8_MouseUp(object sender, MouseEventArgs e)
        {
            //Register the end of the moving operation
            _moving = false;
        }

        private void PB8_MouseMove(object sender, MouseEventArgs e)
        {
            //This makes the picture box move together with the mouse pointer.
            if (_moving)
            {
                PB8.Left += e.Location.X - _startLocation.X;
                PB8.Top += e.Location.Y - _startLocation.Y;
            }
        }
    }
}
