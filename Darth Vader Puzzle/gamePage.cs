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
    public partial class gamePage : Form
    {
        //so the code related to this variable only has to written once and not every time it needs to be used
        string newDirectory;
        //bool variable to signify that borders have been set
        private bool bordersSet = false;
        //8 counter variables that will count the clicks of each PB, so a double click will unhighlight the PB
        int PB1ClickCounter, PB2ClickCounter, PB3ClickCounter, PB4ClickCounter, PB5ClickCounter, PB6ClickCounter, PB7ClickCounter, PB8ClickCounter, PB9ClickCounter, PB1TestClickCounter, PB2TestClickCounter, PB3TestClickCounter, PB4TestClickCounter, PB5TestClickCounter, PB6TestClickCounter, PB7TestClickCounter, PB8TestClickCounter, PB9TestClickCounter = 0;
        //create an integer array that determines the placement of the puzzle pieces
        int[] shufflePuzzlePieces = new int[9];
        private void PB6_Click(object sender, EventArgs e)
        {
            //call highlightShift module under PB6Border1
            highlightShift(PB6ClickCounter);
            //add  1 to clickCounter variable
            PB6ClickCounter++;
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            if (bordersSet && PB6ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB6Border1);
            }
        }

        private void PB7_Click(object sender, EventArgs e)
        {
            //call highlightShift module under PB7Border1
            highlightShift(PB7ClickCounter);
            //add  1 to clickCounter variable
            PB7ClickCounter++;
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it  
            if (bordersSet && PB7ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB7Border1);
            }
        }

        private void PB8_Click(object sender, EventArgs e)
        {
            //call highlightShift module under PB8Border1
            highlightShift(PB8ClickCounter);
            //add  1 to clickCounter variable
            PB8ClickCounter++;
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            if (bordersSet && PB8ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB8Border1);
            }
        }
        private void clickEvent(Label pbBorder, PictureBox PBTest, Label PBTestBorder)
        {
            //stretch the imagelayout through code so the rotated images have the same layout as the original
            PBTest.SizeMode = PictureBoxSizeMode.StretchImage;
            //if said image is clicked and the borders are visible on PB2
            if (pbBorder.Visible && pbBorder == PB2Border1 && PBTest.ImageLocation == null)
            {
                //match the blank PB image with the PB2 image that has been clicked
                PBTest.ImageLocation = PB2.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB2 on the pieces because it is on the board
                PB2.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB1
            else if (pbBorder.Visible && pbBorder == PB1Border1 && PBTest.ImageLocation == null)
            {
                //match the blank PB image with the PB1 image that has been clicked
                PBTest.ImageLocation = PB1.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB1 on the pieces because it is on the board
                PB1.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB3
            else if (pbBorder.Visible && pbBorder == PB3Border1 && PBTest.ImageLocation == null)
            {
                //match the blank PB image with the PB3 image that has been clicked
                PBTest.ImageLocation = PB3.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB3 on the pieces because it is on the board
                PB3.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB4
            else if (pbBorder.Visible && pbBorder == PB4Border1 && PBTest.ImageLocation == null)
            {
                //match the blank PB image with the PB4 image that has been clicked
                PBTest.ImageLocation = PB4.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB4 on the pieces because it is on the board
                PB4.Visible = false;
            }
            //stretch the imagelayout through code so the rotated images have the same layout as the original
            PBTest.SizeMode = PictureBoxSizeMode.StretchImage;
            //if said image is clicked and the borders are visible on PB5
            if (pbBorder.Visible && pbBorder == PB5Border1 && PBTest.ImageLocation == null)
            {
                //match the blank PB image with the PB2 image that has been clicked
                PBTest.ImageLocation = PB5.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB5 on the pieces because it is on the board
                PB5.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB6
            else if (pbBorder.Visible && pbBorder == PB6Border1 && PBTest.ImageLocation == null)
            {
                //match the blank PB image with the PB1 image that has been clicked
                PBTest.ImageLocation = PB6.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB6 on the pieces because it is on the board
                PB6.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB3
            else if (pbBorder.Visible && pbBorder == PB7Border1 && PBTest.ImageLocation == null)
            {
                //match the blank PB image with the PB3 image that has been clicked
                PBTest.ImageLocation = PB7.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB7 on the pieces because it is on the board
                PB7.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB8
            else if (pbBorder.Visible && pbBorder == PB8Border1 && PBTest.ImageLocation == null)
            {
                //match the blank PB image with the PB4 image that has been clicked
                PBTest.ImageLocation = PB8.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB8 on the pieces because it is on the board
                PB8.Visible = false;

            }
            //if said image is clicked and the borders are visible on PB9
            else if (pbBorder.Visible && pbBorder == PB9Border1 && PBTest.ImageLocation == null)
            {
                //match the blank PB image with the PB4 image that has been clicked
                PBTest.ImageLocation = PB9.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB9 on the pieces because it is on the board
                PB9.Visible = false;
            }
            makeBordersVisible(PBTestBorder);
        }
        private void PB1Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB1TestClickCounter++;

            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB1TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the PB1Test picturebox
                clickEvent(PB2Border1, PB1Test, PB1TestBorder1);
                clickEvent(PB1Border1, PB1Test, PB1TestBorder1);
                clickEvent(PB3Border1, PB1Test, PB1TestBorder1);
                clickEvent(PB4Border1, PB1Test, PB1TestBorder1);
                clickEvent(PB5Border1, PB1Test, PB1TestBorder1);
                clickEvent(PB6Border1, PB1Test, PB1TestBorder1);
                clickEvent(PB7Border1, PB1Test, PB1TestBorder1);
                clickEvent(PB8Border1, PB1Test, PB1TestBorder1);
                clickEvent(PB9Border1, PB1Test, PB1TestBorder1);
                //in case the user is trying to switch board pieces and the second one they click on is PB1Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB1Test, PB1TestBorder1);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB1Test, PB1TestBorder1);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB1Test, PB1TestBorder1);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB1Test, PB1TestBorder1);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB1Test, PB1TestBorder1);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB1Test, PB1TestBorder1);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB1Test, PB1TestBorder1);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB1Test, PB1TestBorder1);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB1Test, PB1TestBorder1);
            }
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            if (bordersSet && PB1TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB1TestBorder1);
            }
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB2Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB2TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB2TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the PB2Test picturebox
                clickEvent(PB2Border1, PB2Test, PB2TestBorder1);
                clickEvent(PB1Border1, PB2Test, PB2TestBorder1);
                clickEvent(PB3Border1, PB2Test, PB2TestBorder1);
                clickEvent(PB4Border1, PB2Test, PB2TestBorder1);
                clickEvent(PB5Border1, PB2Test, PB2TestBorder1);
                clickEvent(PB6Border1, PB2Test, PB2TestBorder1);
                clickEvent(PB7Border1, PB2Test, PB2TestBorder1);
                clickEvent(PB8Border1, PB2Test, PB2TestBorder1);
                clickEvent(PB9Border1, PB2Test, PB2TestBorder1);
                //in case the user is trying to switch board pieces and the second one they click on is PB2Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB2Test, PB2TestBorder1);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB2Test, PB2TestBorder1);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB2Test, PB2TestBorder1);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB2Test, PB2TestBorder1);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB2Test, PB2TestBorder1);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB2Test, PB2TestBorder1);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB2Test, PB2TestBorder1);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB2Test, PB2TestBorder1);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB2Test, PB2TestBorder1);
            }
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            else if (bordersSet && PB2TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB2TestBorder1);
            }
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB3Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB3TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB3TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the PB3Test picturebox
                clickEvent(PB2Border1, PB3Test, PB3TestBorder1);
                clickEvent(PB1Border1, PB3Test, PB3TestBorder1);
                clickEvent(PB3Border1, PB3Test, PB3TestBorder1);
                clickEvent(PB4Border1, PB3Test, PB3TestBorder1);
                clickEvent(PB5Border1, PB3Test, PB3TestBorder1);
                clickEvent(PB6Border1, PB3Test, PB3TestBorder1);
                clickEvent(PB7Border1, PB3Test, PB3TestBorder1);
                clickEvent(PB8Border1, PB3Test, PB3TestBorder1);
                clickEvent(PB9Border1, PB3Test, PB3TestBorder1);
                //in case the user is trying to switch board pieces and the second one they click on is PB3Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB3Test, PB3TestBorder1);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB3Test, PB3TestBorder1);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB3Test, PB3TestBorder1);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB3Test, PB3TestBorder1);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB3Test, PB3TestBorder1);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB3Test, PB3TestBorder1);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB3Test, PB3TestBorder1);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB3Test, PB3TestBorder1);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB3Test, PB3TestBorder1);
            }
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            else if (bordersSet && PB3TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB3TestBorder1);
            }
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB4Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB4TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB4TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the PB4Test picturebox
                clickEvent(PB2Border1, PB4Test, PB4TestBorder1);
                clickEvent(PB1Border1, PB4Test, PB4TestBorder1);
                clickEvent(PB3Border1, PB4Test, PB4TestBorder1);
                clickEvent(PB4Border1, PB4Test, PB4TestBorder1);
                clickEvent(PB5Border1, PB4Test, PB4TestBorder1);
                clickEvent(PB6Border1, PB4Test, PB4TestBorder1);
                clickEvent(PB7Border1, PB4Test, PB4TestBorder1);
                clickEvent(PB8Border1, PB4Test, PB4TestBorder1);
                clickEvent(PB9Border1, PB4Test, PB4TestBorder1);
                //in case the user is trying to switch board pieces and the second one they click on is PB4Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB4Test, PB4TestBorder1);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB4Test, PB4TestBorder1);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB4Test, PB4TestBorder1);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB4Test, PB4TestBorder1);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB4Test, PB4TestBorder1);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB4Test, PB4TestBorder1);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB4Test, PB4TestBorder1);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB4Test, PB4TestBorder1);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB4Test, PB4TestBorder1);
            }
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            else if (bordersSet && PB4TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB4TestBorder1);
            }
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB5Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB5TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB5TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the PB5Test picturebox
                clickEvent(PB2Border1, PB5Test, PB5TestBorder1);
                clickEvent(PB1Border1, PB5Test, PB5TestBorder1);
                clickEvent(PB3Border1, PB5Test, PB5TestBorder1);
                clickEvent(PB4Border1, PB5Test, PB5TestBorder1);
                clickEvent(PB5Border1, PB5Test, PB5TestBorder1);
                clickEvent(PB6Border1, PB5Test, PB5TestBorder1);
                clickEvent(PB7Border1, PB5Test, PB5TestBorder1);
                clickEvent(PB8Border1, PB5Test, PB5TestBorder1);
                clickEvent(PB9Border1, PB5Test, PB5TestBorder1);
                //in case the user is trying to switch board pieces and the second one they click on is PB6Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB5Test, PB5TestBorder1);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB5Test, PB5TestBorder1);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB5Test, PB5TestBorder1);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB5Test, PB5TestBorder1);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB5Test, PB5TestBorder1);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB5Test, PB5TestBorder1);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB5Test, PB5TestBorder1);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB5Test, PB5TestBorder1);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB5Test, PB5TestBorder1);
            }
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            else if (bordersSet && PB5TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB5TestBorder1);
            }
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB6Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB6TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB6TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the PB6Test picturebox
                clickEvent(PB2Border1, PB6Test, PB6TestBorder1);
                clickEvent(PB1Border1, PB6Test, PB6TestBorder1);
                clickEvent(PB3Border1, PB6Test, PB6TestBorder1);
                clickEvent(PB4Border1, PB6Test, PB6TestBorder1);
                clickEvent(PB5Border1, PB6Test, PB6TestBorder1);
                clickEvent(PB6Border1, PB6Test, PB6TestBorder1);
                clickEvent(PB7Border1, PB6Test, PB6TestBorder1);
                clickEvent(PB8Border1, PB6Test, PB6TestBorder1);
                clickEvent(PB9Border1, PB6Test, PB6TestBorder1);
                //in case the user is trying to switch board pieces and the second one they click on is PB6Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB6Test, PB6TestBorder1);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB6Test, PB6TestBorder1);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB6Test, PB6TestBorder1);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB6Test, PB6TestBorder1);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB6Test, PB6TestBorder1);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB6Test, PB6TestBorder1);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB6Test, PB6TestBorder1);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB6Test, PB6TestBorder1);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB6Test, PB6TestBorder1);
            }
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            else if (bordersSet && PB6TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB6TestBorder1);
            }
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB7Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB7TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB7TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the PB7Test picturebox
                clickEvent(PB2Border1, PB7Test, PB7TestBorder1);
                clickEvent(PB1Border1, PB7Test, PB7TestBorder1);
                clickEvent(PB3Border1, PB7Test, PB7TestBorder1);
                clickEvent(PB4Border1, PB7Test, PB7TestBorder1);
                clickEvent(PB5Border1, PB7Test, PB7TestBorder1);
                clickEvent(PB6Border1, PB7Test, PB7TestBorder1);
                clickEvent(PB7Border1, PB7Test, PB7TestBorder1);
                clickEvent(PB8Border1, PB7Test, PB7TestBorder1);
                clickEvent(PB9Border1, PB7Test, PB7TestBorder1);
                //in case the user is trying to switch board pieces and the second one they click on is PB7Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB7Test, PB7TestBorder1);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB7Test, PB7TestBorder1);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB7Test, PB7TestBorder1);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB7Test, PB7TestBorder1);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB7Test, PB7TestBorder1);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB7Test, PB7TestBorder1);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB7Test, PB7TestBorder1);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB7Test, PB7TestBorder1);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB7Test, PB7TestBorder1);
            }
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            else if (bordersSet && PB7TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB7TestBorder1);
            }
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB8Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB8TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB8TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the PB8Test picturebox
                clickEvent(PB2Border1, PB8Test, PB8TestBorder1);
                clickEvent(PB1Border1, PB8Test, PB8TestBorder1);
                clickEvent(PB3Border1, PB8Test, PB8TestBorder1);
                clickEvent(PB4Border1, PB8Test, PB8TestBorder1);
                clickEvent(PB5Border1, PB8Test, PB8TestBorder1);
                clickEvent(PB6Border1, PB8Test, PB8TestBorder1);
                clickEvent(PB7Border1, PB8Test, PB8TestBorder1);
                clickEvent(PB8Border1, PB8Test, PB8TestBorder1);
                clickEvent(PB9Border1, PB8Test, PB8TestBorder1);
                //in case the user is trying to switch board pieces and the second one they click on is PB8Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB8Test, PB8TestBorder1);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB8Test, PB8TestBorder1);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB8Test, PB8TestBorder1);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB8Test, PB8TestBorder1);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB8Test, PB8TestBorder1);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB8Test, PB8TestBorder1);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB8Test, PB8TestBorder1);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB8Test, PB8TestBorder1);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB8Test, PB8TestBorder1);
            }
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            else if (bordersSet && PB8TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB8TestBorder1);
            }
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
                    makeAllBordersInvisible();
                }
            }
        }
        private void determinePuzzleProgress()
        {
            //if the imageLocaton of the PB1Test picturebox equals darthVaderOne.png
            if (PB1Test.ImageLocation == newDirectory + "darthVaderOne.png")
            {
                //if the imageLocation of the PB2Test picturebox equals darthVaderTwo.png
                if (PB2Test.ImageLocation == newDirectory + "darthVaderTwo.png")
                {
                    //if the imageLocation of the PB3Test picturebox equals DarthVaderThree.png
                    if (PB3Test.ImageLocation == newDirectory + "darthVaderThree.png")
                    {
                        //if the imageLocation of the PB4Test picturebox equals darthVaderFour.png
                        if (PB4Test.ImageLocation == newDirectory + "darthVaderFour.png")
                        {
                            //if the imageLocation of the PB5Test picturebox equals darthVaderFive.png
                            if (PB5Test.ImageLocation == newDirectory + "darthVaderFive.png")
                            {
                                //if the imageLocation of the PB6Test picturebox equals darthVaderSix.png
                                if (PB6Test.ImageLocation == newDirectory + "darthVaderSix.png")
                                {
                                    //if the imageLocation of the PB7Test picturebox equals darthVaderSeven.png
                                    if (PB7Test.ImageLocation == newDirectory + "darthVaderSeven.png")
                                    {
                                        //if the imageLocation of the PB8Test picturebox equals darthVaderEight.png
                                        if (PB8Test.ImageLocation == newDirectory + "darthVaderEight.png")
                                        {
                                            //if the imageLocation of the PB9Test picturebox equals darthVaderNine.png
                                            if (PB9Test.ImageLocation == newDirectory + "darthVaderNine.png")
                                            {
                                                //unhighlight any picturebox's that may be highlighted
                                                makeAllBordersInvisible();
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
        private void highlightShift(int PBClickCounter)
        {
            //this module will be utilized underneath picturebox click events, so keep that in mind

            //if there are borders visible other than the paramater label
            if (bordersSet && PBClickCounter == 0)
            {
                //make all borders invisible
                makeAllBordersInvisible();
            }
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            //enabling the back button to work between the PB1Test picturebox and any of the puzzle pieces
            backButtonModule(PB1TestBorder1, PB1Test, PB1);
            backButtonModule(PB1TestBorder1, PB1Test, PB2);
            backButtonModule(PB1TestBorder1, PB1Test, PB3);
            backButtonModule(PB1TestBorder1, PB1Test, PB4);
            backButtonModule(PB1TestBorder1, PB1Test, PB5);
            backButtonModule(PB1TestBorder1, PB1Test, PB6);
            backButtonModule(PB1TestBorder1, PB1Test, PB7);
            backButtonModule(PB1TestBorder1, PB1Test, PB8);
            backButtonModule(PB1TestBorder1, PB1Test, PB9);
            //use of the backButtonModule regarding the PB2Test picturebox
            backButtonModule(PB2TestBorder1, PB2Test, PB1);
            backButtonModule(PB2TestBorder1, PB2Test, PB2);
            backButtonModule(PB2TestBorder1, PB2Test, PB3);
            backButtonModule(PB2TestBorder1, PB2Test, PB4);
            backButtonModule(PB2TestBorder1, PB2Test, PB5);
            backButtonModule(PB2TestBorder1, PB2Test, PB6);
            backButtonModule(PB2TestBorder1, PB2Test, PB7);
            backButtonModule(PB2TestBorder1, PB2Test, PB8);
            backButtonModule(PB2TestBorder1, PB2Test, PB9);
            //use of the backButtonModule regarding the PB3Test picturebox
            backButtonModule(PB3TestBorder1, PB3Test, PB1);
            backButtonModule(PB3TestBorder1, PB3Test, PB2);
            backButtonModule(PB3TestBorder1, PB3Test, PB3);
            backButtonModule(PB3TestBorder1, PB3Test, PB4);
            backButtonModule(PB3TestBorder1, PB3Test, PB5);
            backButtonModule(PB3TestBorder1, PB3Test, PB6);
            backButtonModule(PB3TestBorder1, PB3Test, PB7);
            backButtonModule(PB3TestBorder1, PB3Test, PB8);
            backButtonModule(PB3TestBorder1, PB3Test, PB9);
            //use of the backButtonModule regarding the PB4Test picturebox
            backButtonModule(PB4TestBorder1, PB4Test, PB1);
            backButtonModule(PB4TestBorder1, PB4Test, PB2);
            backButtonModule(PB4TestBorder1, PB4Test, PB3);
            backButtonModule(PB4TestBorder1, PB4Test, PB4);
            backButtonModule(PB4TestBorder1, PB4Test, PB5);
            backButtonModule(PB4TestBorder1, PB4Test, PB6);
            backButtonModule(PB4TestBorder1, PB4Test, PB7);
            backButtonModule(PB4TestBorder1, PB4Test, PB8);
            backButtonModule(PB4TestBorder1, PB4Test, PB9);
            //use of the backButtonModule regarding the PB5Test picturebox
            backButtonModule(PB5TestBorder1, PB5Test, PB1);
            backButtonModule(PB5TestBorder1, PB5Test, PB2);
            backButtonModule(PB5TestBorder1, PB5Test, PB3);
            backButtonModule(PB5TestBorder1, PB5Test, PB4);
            backButtonModule(PB5TestBorder1, PB5Test, PB5);
            backButtonModule(PB5TestBorder1, PB5Test, PB6);
            backButtonModule(PB5TestBorder1, PB5Test, PB7);
            backButtonModule(PB5TestBorder1, PB5Test, PB8);
            backButtonModule(PB5TestBorder1, PB5Test, PB9);
            //use of the backButtonModule regarding the PB6Test picturebox
            backButtonModule(PB6TestBorder1, PB6Test, PB1);
            backButtonModule(PB6TestBorder1, PB6Test, PB2);
            backButtonModule(PB6TestBorder1, PB6Test, PB3);
            backButtonModule(PB6TestBorder1, PB6Test, PB4);
            backButtonModule(PB6TestBorder1, PB6Test, PB5);
            backButtonModule(PB6TestBorder1, PB6Test, PB6);
            backButtonModule(PB6TestBorder1, PB6Test, PB7);
            backButtonModule(PB6TestBorder1, PB6Test, PB8);
            backButtonModule(PB6TestBorder1, PB6Test, PB9);
            //use of the backButtonModule regarding the PB7Test picturebox
            backButtonModule(PB7TestBorder1, PB7Test, PB1);
            backButtonModule(PB7TestBorder1, PB7Test, PB2);
            backButtonModule(PB7TestBorder1, PB7Test, PB3);
            backButtonModule(PB7TestBorder1, PB7Test, PB4);
            backButtonModule(PB7TestBorder1, PB7Test, PB5);
            backButtonModule(PB7TestBorder1, PB7Test, PB6);
            backButtonModule(PB7TestBorder1, PB7Test, PB7);
            backButtonModule(PB7TestBorder1, PB7Test, PB8);
            backButtonModule(PB7TestBorder1, PB7Test, PB9);
            //use of the backButtonModule regarding the PB8Test picturebox
            backButtonModule(PB8TestBorder1, PB8Test, PB1);
            backButtonModule(PB8TestBorder1, PB8Test, PB2);
            backButtonModule(PB8TestBorder1, PB8Test, PB3);
            backButtonModule(PB8TestBorder1, PB8Test, PB4);
            backButtonModule(PB8TestBorder1, PB8Test, PB5);
            backButtonModule(PB8TestBorder1, PB8Test, PB6);
            backButtonModule(PB8TestBorder1, PB8Test, PB7);
            backButtonModule(PB8TestBorder1, PB8Test, PB8);
            backButtonModule(PB8TestBorder1, PB8Test, PB9);
            //use of the backButtonModule regarding the PB9Test picturebox
            backButtonModule(PB9TestBorder1, PB9Test, PB1);
            backButtonModule(PB9TestBorder1, PB9Test, PB2);
            backButtonModule(PB9TestBorder1, PB9Test, PB3);
            backButtonModule(PB9TestBorder1, PB9Test, PB4);
            backButtonModule(PB9TestBorder1, PB9Test, PB5);
            backButtonModule(PB9TestBorder1, PB9Test, PB6);
            backButtonModule(PB9TestBorder1, PB9Test, PB7);
            backButtonModule(PB9TestBorder1, PB9Test, PB8);
            backButtonModule(PB9TestBorder1, PB9Test, PB9);
        }

        private void clockwiseRotation(Label PBBorder, PictureBox PB)
        {
            //if any picturebox is highlighted
            if (PBBorder.Visible)
            {
                //stretch the imagelayout through code so the rotated images have the same layout as the original
                PB.SizeMode = PictureBoxSizeMode.StretchImage;
                //if the imageLocation of the picturebox equals rotated90.png
                if (PB.ImageLocation.EndsWith("Rotated90.png"))
                {
                    //replace the Rotated90.png ending with Rotated180.png
                    PB.ImageLocation = PB.ImageLocation.Replace("Rotated90.png", "Rotated180.png");
                }
                //if the imageLocation of the picturebox equals rotated180.png
                else if (PB.ImageLocation.EndsWith("Rotated180.png"))
                {
                    //replace the Rotated180.png ending with Rotated270.png
                    PB.ImageLocation = PB.ImageLocation.Replace("Rotated180.png", "Rotated270.png");
                }
                //if the imageLocation of the picturebox equals rotated270.png
                else if (PB.ImageLocation.EndsWith("Rotated270.png"))
                {
                    //replace the Rotated270.png ending with .png
                    PB.ImageLocation = PB.ImageLocation.Replace("Rotated270.png", ".png");
                }
                else
                {
                    //if the imageLocation of the picturebox equals .png
                    //replace the .png ending with Rotated90.png
                    PB.ImageLocation = PB.ImageLocation.Replace(".png", "Rotated90.png");
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
            clockwiseRotation(PB1Border1, PB1);
            clockwiseRotation(PB2Border1, PB2);
            clockwiseRotation(PB3Border1, PB3);
            clockwiseRotation(PB4Border1, PB4);
            clockwiseRotation(PB5Border1, PB5);
            clockwiseRotation(PB6Border1, PB6);
            clockwiseRotation(PB7Border1, PB7);
            clockwiseRotation(PB8Border1, PB8);
            clockwiseRotation(PB9Border1, PB9);
            //clockwise rotation for the board pieces
            clockwiseRotation(PB1TestBorder1, PB1Test);
            clockwiseRotation(PB2TestBorder2, PB2Test);
            clockwiseRotation(PB3TestBorder1, PB3Test);
            clockwiseRotation(PB4TestBorder1, PB4Test);
            clockwiseRotation(PB5TestBorder1, PB5Test);
            clockwiseRotation(PB6TestBorder1, PB6Test);
            clockwiseRotation(PB7TestBorder1, PB7Test);
            clockwiseRotation(PB8TestBorder1, PB8Test);
            clockwiseRotation(PB9TestBorder1, PB9Test);
            //in case the last piece is finished by rotating it when it's already on the board
            determinePuzzleProgress();
        }

        private void PB9Test_Click(object sender, EventArgs e)
        {
            PB9TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB9TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the PB9Test picturebox
                clickEvent(PB2Border1, PB9Test, PB9TestBorder1);
                clickEvent(PB1Border1, PB9Test, PB9TestBorder1);
                clickEvent(PB3Border1, PB9Test, PB9TestBorder1);
                clickEvent(PB4Border1, PB9Test, PB9TestBorder1);
                clickEvent(PB5Border1, PB9Test, PB9TestBorder1);
                clickEvent(PB6Border1, PB9Test, PB9TestBorder1);
                clickEvent(PB7Border1, PB9Test, PB9TestBorder1);
                clickEvent(PB8Border1, PB9Test, PB9TestBorder1);
                clickEvent(PB9Border1, PB9Test, PB9TestBorder1);
                //in case the user is trying to switch board pieces and the second one they click on is PB9Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB9Test, PB9TestBorder1);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB9Test, PB9TestBorder1);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB9Test, PB9TestBorder1);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB9Test, PB9TestBorder1);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB9Test, PB9TestBorder1);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB9Test, PB9TestBorder1);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB9Test, PB9TestBorder1);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB9Test, PB9TestBorder1);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB9Test, PB9TestBorder1);
            }

            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            else if (bordersSet && PB9TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB9TestBorder1);
            }
            //in case this is the last piece required to finish the puzzle
            determinePuzzleProgress();
        }

        private void PB9_Click(object sender, EventArgs e)
        {
            //call highlightShift module under PB9Border1
            highlightShift(PB9ClickCounter);
            //add  1 to clickCounter variable
            PB9ClickCounter++;
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            if (bordersSet && PB9ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB9Border1);
            }
        }

        private void PB5_Click(object sender, EventArgs e)
        {
            //call highlightShift module under PB5Border1
            highlightShift(PB5ClickCounter);
            //add  1 to clickCounter variable
            PB5ClickCounter++;
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it
            if (bordersSet && PB5ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB5Border1);
            }
        }

        private void PB4_Click(object sender, EventArgs e)
        {
            //call highlightShift module under PB4Border1
            highlightShift(PB4ClickCounter);
            //add  1 to clickCounter variable
            PB4ClickCounter++;
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it
            if (bordersSet && PB4ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB4Border1);
            }
        }

        private void PB3_Click(object sender, EventArgs e)
        {
            //call highlightShift module under PB3Border1
            highlightShift(PB3ClickCounter);
            //add  1 to clickCounter variable
            PB3ClickCounter++;
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            if (bordersSet && PB3ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB3Border1);
            }
        }
        private void PB2_Click(object sender, EventArgs e)
        {
            //call highlightShift module under PB2Border1
            highlightShift(PB2ClickCounter);
            //add  1 to clickCounter variable
            PB2ClickCounter++;
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            if (bordersSet && PB2ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB2Border1);
            }
        }

        private void PB1_Click(object sender, EventArgs e)
        {
            //call highlightShift module under PB1Border1
            highlightShift(PB1ClickCounter);
            //add  1 to clickCounter variable
            PB1ClickCounter++;
            //if bordersSet bool variable is true and the picturebox has been clicked on twice, unhighlight it 
            if (bordersSet && PB1ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB1Border1);
            }
        }
        public gamePage()
        {
            InitializeComponent();
        }
        private void makeBordersVisible(Label pbBorder)
        {
            //THE BOOL VARIABLE MUST BE FALSE TO MAKE THE BORDERS VISIBLE, BECAUSE ONLY ONE PUZZLE PIECE CAN BE CHOSEN AT ONE TIME

            if (pbBorder == PB2TestBorder1 && !bordersSet)
            {
                //make the border labels appear visible to indicate the user that they clicked this picturebox
                PB2TestBorder1.Visible = true; PB2TestBorder2.Visible = true; PB2TestBorder3.Visible = true; PB2TestBorder4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB1TestBorder1, make all the PB1TestBorder labels visible
            else if (pbBorder == PB1TestBorder1 && !bordersSet)
            {
                PB1TestBorder1.Visible = true;  PB1TestBorder2.Visible = true; PB1TestBorder3.Visible = true; PB1TestBorder4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB3TestBorder1, make all the PB3TestBorder labels visible
            else if (pbBorder == PB3TestBorder1 && !bordersSet)
            {
                PB3TestBorder1.Visible = true; PB3TestBorder2.Visible = true; PB3TestBorder3.Visible = true; PB3TestBorder4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB4TestBorder1, make all the PB4TestBorder labels visible
            else if (pbBorder == PB4TestBorder1 && !bordersSet)
            {
                PB4TestBorder1.Visible = true; PB4TestBorder2.Visible = true; PB4TestBorder3.Visible = true; PB4TestBorder4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB5TestBorder1, make all the PB5TestBorder labels visible
            else if (pbBorder == PB5TestBorder1 && !bordersSet)
            {
                //make the border labels appear visible to indicate the user that they clicked this picturebox
                PB5TestBorder1.Visible = true; PB5TestBorder2.Visible = true; PB5TestBorder3.Visible = true; PB5TestBorder4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB6TestBorder1, make all the PB6TestBorder labels visible
            else if (pbBorder == PB6TestBorder1 && !bordersSet)
            {
                PB6TestBorder1.Visible = true; PB6TestBorder2.Visible = true; PB6TestBorder3.Visible = true; PB6TestBorder4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB7TestBorder1, make all the PB7TestBorder labels visible
            else if (pbBorder == PB7TestBorder1 && !bordersSet)
            {
                PB7TestBorder1.Visible = true; PB7TestBorder2.Visible = true; PB7TestBorder3.Visible = true; PB7TestBorder4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB8TestBorder1, make all the PB8TestBorder labels visible
            else if (pbBorder == PB8TestBorder1 && !bordersSet)
            {
                PB8TestBorder1.Visible = true; PB8TestBorder2.Visible = true; PB8TestBorder3.Visible = true; PB8TestBorder4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB9TestBorder1, make all the PB9TestBorder labels visible
            else if (pbBorder == PB9TestBorder1 && !bordersSet)
            {
                PB9TestBorder1.Visible = true; PB9TestBorder2.Visible = true; PB9TestBorder3.Visible = true; PB9TestBorder4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB2Border1, make all the PB2Border labels visible
            else if (pbBorder == PB2Border1 && !bordersSet)
            {
                //make the border labels appear visible to indicate the user that they clicked this picturebox
                PB2Border1.Visible = true; PB2Border2.Visible = true; PB2Border3.Visible = true; PB2Border4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB1Border1, make all the PB1Border labels visible
            else if (pbBorder == PB1Border1 && !bordersSet)
            {
                PB1Border1.Visible = true; PB1Border2.Visible = true; PB1Border3.Visible = true; PB1Border4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB3Border1, make all the PB3Border labels visible
            else if (pbBorder == PB3Border1 && !bordersSet)
            {
                PB3Border1.Visible = true; PB3Border2.Visible = true; PB3Border3.Visible = true; PB3Border4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB3Border4, make all the PB4Border labels visible
            else if (pbBorder == PB4Border1 && !bordersSet)
            {
                PB4Border1.Visible = true; PB4Border2.Visible = true; PB4Border3.Visible = true; PB4Border4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB5Border1, make all the PB5Border labels visible
            else if (pbBorder == PB5Border1 && !bordersSet)
            {
                //make the border labels appear visible to indicate the user that they clicked this picturebox
                PB5Border1.Visible = true; PB5Border2.Visible = true; PB5Border3.Visible = true; PB5Border4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB6Border1, make all the PB6Border labels visible
            else if (pbBorder == PB6Border1 && !bordersSet)
            {
                PB6Border1.Visible = true; PB6Border2.Visible = true; PB6Border3.Visible = true; PB6Border4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB7Border1, make all the PB7Border labels visible
            else if (pbBorder == PB7Border1 && !bordersSet)
            {
                PB7Border1.Visible = true; PB7Border2.Visible = true; PB7Border3.Visible = true; PB7Border4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB8Border1, make all the PB8Border labels visible
            else if (pbBorder == PB8Border1 && !bordersSet)
            {
                PB8Border1.Visible = true; PB8Border2.Visible = true; PB8Border3.Visible = true; PB8Border4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
            //if pbBorder = PB9Border1, make all the PB9Border labels visible
            else if (pbBorder == PB9Border1 && !bordersSet)
            {
                PB9Border1.Visible = true; PB9Border2.Visible = true; PB9Border3.Visible = true; PB9Border4.Visible = true;
                //mark the bool variable true so only one piece can be selected at a time
                bordersSet = true;
            }
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


            PB1.Image.Save(newDirectory + "PB1.png");
            var filePath = newDirectory + "PB1.png";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }


            Bitmap bitmap1;
            bitmap1 = (Bitmap)Bitmap.FromFile("PB2.jpg");

            bitmap1.RotateFlip(RotateFlipType.Rotate90FlipY);
            PB1.Image = bitmap1;

        }

        private void absoluteReset()
        {
            //in the case everything gets scrambled, delete all progress and input this code at the bottom of the shuffleGenerator module


            //This is bitmap code to cut a given image into 9 pieces
            //source of the code is on this stackOverflow post: https://stackoverflow.com/questions/13625891/cut-an-image-into-9-pieces-c-sharp
            Image img = Image.FromFile(newDirectory + "darthVader.jpg"); // a.png has 312X312 width and height
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


            //SETTING THE SLICED PICTUREBOX'S TO EACH PB
            PB1.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVaderOne.png
            PB1.Image = bmps[0, 0];
            PB2.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVaderTwo.png
            PB2.Image = bmps[0, 1];
            PB3.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVaderThree.png
            PB3.Image = bmps[0, 2];
            PB4.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVaderFour.png
            PB4.Image = bmps[1, 0];
            PB5.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVaderFive.png
            PB5.Image = bmps[1, 1];
            PB6.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVaderSix.png
            PB6.Image = bmps[1, 2];
            PB7.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVaderSeven.png
            PB7.Image = bmps[2, 0];
            PB8.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVaderEight.png
            PB8.Image = bmps[2, 1];
            PB9.SizeMode = PictureBoxSizeMode.StretchImage;
            //picturebox image will equal darthVaderNine.png
            PB9.Image = bmps[2, 2];



            //ADDING AN IMAGE TO THE FOLDER
            PB1.Image.Save(newDirectory + "PB1.png");


            //ROTATING AN IMAGE
            Bitmap bitmap1;
            bitmap1 = (Bitmap)Bitmap.FromFile("PB1.png");
            bitmap1.RotateFlip(RotateFlipType.Rotate90FlipY);
            PB1.Image = bitmap1;

            //DELETING AN IMAGE FROM THE FOLDER
            var filePath = newDirectory + "PB1.png";
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
        private void placeShuffleOntoPieces(int i, PictureBox PBNum)
        {
            //This is bitmap code to cut a given image into 9 pieces
            //source of the code is on this stackOverflow post: https://stackoverflow.com/questions/13625891/cut-an-image-into-9-pieces-c-sharp
            Image img = Image.FromFile(newDirectory + "darthVader.jpg"); // a.png has 312X312 width and height
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


            //if the generated number equals 1
            if (shufflePuzzlePieces[i] == 1)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVaderOne.png
                PBNum.Image = bmps[0, 0];
                //save the image FromFile to darthVaderOne.png
                PBNum.Image.Save("darthVaderOne.png");
            }
            //if the generated number equals 2
            else if (shufflePuzzlePieces[i] == 2)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVaderTwo.png
                PBNum.Image = bmps[0, 1];
            }
            //if the generated number equals 3
            else if (shufflePuzzlePieces[i] == 3)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVaderThree.png
                PBNum.Image = bmps[0, 2];
            }
            //if the generated number equals 4
            else if (shufflePuzzlePieces[i] == 4)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVaderFour.png
                PBNum.Image = bmps[1, 0];
            }
            //if the generated number equals 5
            if (shufflePuzzlePieces[i] == 5)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVaderFive.png
                PBNum.Image = bmps[1, 1];
            }
            //if the generated number equals 6
            else if (shufflePuzzlePieces[i] == 6)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVaderSix.png
                PBNum.Image = bmps[1, 2];
            }
            //if the generated number equals 7
            else if (shufflePuzzlePieces[i] == 7)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVaderSeven.png
                PBNum.Image = bmps[2, 0];
            }
            //if the generated number equals 8
            else if (shufflePuzzlePieces[i] == 8)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVaderEight.png
                PBNum.Image = bmps[2, 1];
            }
            //if the generated number equals 9
            else if (shufflePuzzlePieces[i] == 9)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVaderNine.png
                PBNum.Image = bmps[2, 2];
            }
        }
        private void rotationShuffleGenerator(PictureBox PB)
        {
            //create a random object
            Random rand = new Random();

            int i = rand.Next(0, 4);
            if (i == 0)
            {
                //change PB.ImageLocation ending from .png to Rotated180.png to rotate the image 180 degrees
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
            PB1ClickCounter = 0; PB2ClickCounter = 0; PB3ClickCounter = 0; PB4ClickCounter = 0; PB5ClickCounter = 0; PB6ClickCounter = 0; PB7ClickCounter = 0; PB8ClickCounter = 0; PB9ClickCounter = 0; PB1TestClickCounter = 0; PB2TestClickCounter = 0; PB3TestClickCounter = 0; PB4TestClickCounter = 0; PB5TestClickCounter = 0; PB6TestClickCounter = 0;  PB7TestClickCounter = 0; PB8TestClickCounter = 0; PB9TestClickCounter = 0;
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
            PB9TestBorder1.Visible = false; PB9TestBorder2.Visible = false; PB9TestBorder3.Visible = false; PB9TestBorder4.Visible = false;
            PB2Border1.Visible = false; PB2Border2.Visible = false; PB2Border3.Visible = false; PB2Border4.Visible = false;
            PB1Border1.Visible = false; PB1Border2.Visible = false; PB1Border3.Visible = false; PB1Border4.Visible = false;
            PB3Border1.Visible = false; PB3Border2.Visible = false; PB3Border3.Visible = false; PB3Border4.Visible = false;
            PB4Border1.Visible = false; PB4Border2.Visible = false; PB4Border3.Visible = false; PB4Border4.Visible = false;
            PB5Border1.Visible = false; PB5Border2.Visible = false; PB5Border3.Visible = false; PB5Border4.Visible = false;
            PB6Border1.Visible = false; PB6Border2.Visible = false; PB6Border3.Visible = false; PB6Border4.Visible = false;
            PB7Border1.Visible = false; PB7Border2.Visible = false; PB7Border3.Visible = false; PB7Border4.Visible = false;
            PB8Border1.Visible = false; PB8Border2.Visible = false; PB8Border3.Visible = false; PB8Border4.Visible = false;
            PB9Border1.Visible = false; PB9Border2.Visible = false; PB9Border3.Visible = false; PB9Border4.Visible = false;
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
                    makeAllBordersInvisible();
                    //make the 'clickedPB' borders visible
                    makeBordersVisible(clickedPBBorder);
                }
                //if both the highlighted and previously clicked picturebox have images on them
                else
                {
                    //unhighlight 'highlightedPB'
                    makeAllBordersInvisible();
                    //highlight clickedPB
                    makeBordersVisible(clickedPBBorder);
                }
            }
        }
        private void gamePage_Load(object sender, EventArgs e)
        {
            //THIS CODE ALLOWS THE DIRECTORY TO BE CORRECT REGARDLESS OF THE COMPUTER OR USER
            //retrive current directory
            string currentDirectory = Environment.CurrentDirectory;
            //make it so that the newDirectory deletes everything past the first 'Darth Vader Puzzle'
            newDirectory = currentDirectory.Replace("\\", "/");
            newDirectory = newDirectory.Replace("Darth Vader Puzzle/bin/Debug/net6.0-windows", "");



            //play ROTS Soundtrack
            SoundPlayer ROTS = new SoundPlayer(newDirectory + "gamePageWAVTrack.wav");
            ROTS.PlayLooping();
            //make all the picturebox borders invisible
            makeAllBordersInvisible();
            //to shuffle the box pieces
            shuffleGenerator();
            //to mix up the orientation of the puzzle pieces
            //rotationShuffleGenerator(PB1);
            //rotationShuffleGenerator(PB2);
            //rotationShuffleGenerator(PB3);
            //rotationShuffleGenerator(PB4);
            //rotationShuffleGenerator(PB5);
            //rotationShuffleGenerator(PB6);
            //rotationShuffleGenerator(PB7);
            //rotationShuffleGenerator(PB8);
            //rotationShuffleGenerator(PB9);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
        }
    }
}
