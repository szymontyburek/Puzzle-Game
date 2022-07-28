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
        int PB1ClickCounter, PB2ClickCounter, PB3ClickCounter, PB4ClickCounter, PB5ClickCounter, PB6ClickCounter, PB7ClickCounter, PB8ClickCounter, PB9ClickCounter, PB1TestClickCounter, PB2TestClickCounter, PB3TestClickCounter, PB4TestClickCounter, PB5TestClickCounter, PB6TestClickCounter, PB7TestClickCounter, PB8TestClickCounter, PB9TestClickCounter = 0;
        //create an integer array that determines the placement of the puzzle pieces
        int[] shufflePuzzlePieces = new int[9];
        private void PB6_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB6ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB6ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB6ClickCounter == 2)
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
            //add  1 to clickCounter variable
            PB7ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB7ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB7ClickCounter == 2)
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
            //add  1 to clickCounter variable
            PB8ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB8ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB8ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB8Border1);
            }
        }

        private void PB1Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB1TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB1TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the picturebox that was clicked last
                clickEvent(PB2Border1, PB1Test);
                clickEvent(PB1Border1, PB1Test);
                clickEvent(PB3Border1, PB1Test);
                clickEvent(PB4Border1, PB1Test);
                clickEvent(PB5Border1, PB1Test);
                clickEvent(PB6Border1, PB1Test);
                clickEvent(PB7Border1, PB1Test);
                clickEvent(PB8Border1, PB1Test);
                clickEvent(PB9Border1, PB1Test);
                //in case the user is trying to switch board pieces and the second one they click on is PB1Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB1Test);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB1Test);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB1Test);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB1Test);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB1Test);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB1Test);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB1Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB1Test);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB1Test);
            }
            else if (bordersSet && PB1TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB1TestBorder1);
            }
        }

        private void PB2Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB2TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB2TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the picturebox that was clicked last
                clickEvent(PB2Border1, PB2Test);
                clickEvent(PB1Border1, PB2Test);
                clickEvent(PB3Border1, PB2Test);
                clickEvent(PB4Border1, PB2Test);
                clickEvent(PB5Border1, PB2Test);
                clickEvent(PB6Border1, PB2Test);
                clickEvent(PB7Border1, PB2Test);
                clickEvent(PB8Border1, PB2Test);
                clickEvent(PB9Border1, PB2Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB4Test, PB1Test);
                //in case the user is trying to switch board pieces and the second one they click on is PB2Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB2Test);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB2Test);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB2Test);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB2Test);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB2Test);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB2Test);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB2Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB2Test);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB2Test);
            }
            else if (bordersSet && PB2TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB2TestBorder1);
            }
        }

        private void PB3Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB3TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB3TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the picturebox that was clicked last
                clickEvent(PB2Border1, PB3Test);
                clickEvent(PB1Border1, PB3Test);
                clickEvent(PB3Border1, PB3Test);
                clickEvent(PB4Border1, PB3Test);
                clickEvent(PB5Border1, PB3Test);
                clickEvent(PB6Border1, PB3Test);
                clickEvent(PB7Border1, PB3Test);
                clickEvent(PB8Border1, PB3Test);
                clickEvent(PB9Border1, PB3Test);
                //in case the user is trying to switch board pieces and the second one they click on is PB3Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB3Test);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB3Test);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB3Test);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB3Test);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB3Test);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB3Test);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB3Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB3Test);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB3Test);
            }
            else if (bordersSet && PB3TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB3TestBorder1);
            }
        }

        private void PB4Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB4TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB4TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the picturebox that was clicked last
                clickEvent(PB2Border1, PB4Test);
                clickEvent(PB1Border1, PB4Test);
                clickEvent(PB3Border1, PB4Test);
                clickEvent(PB4Border1, PB4Test);
                clickEvent(PB5Border1, PB4Test);
                clickEvent(PB6Border1, PB4Test);
                clickEvent(PB7Border1, PB4Test);
                clickEvent(PB8Border1, PB4Test);
                clickEvent(PB9Border1, PB4Test);
                //in case the user is trying to switch board pieces and the second one they click on is PB4Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB4Test);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB4Test);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB4Test);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB4Test);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB4Test);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB4Test);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB4Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB4Test);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB4Test);
            }
            else if (bordersSet && PB4TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB4TestBorder1);
            }
        }

        private void PB5Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB5TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB5TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the picturebox that was clicked last
                clickEvent(PB2Border1, PB5Test);
                clickEvent(PB1Border1, PB5Test);
                clickEvent(PB3Border1, PB5Test);
                clickEvent(PB4Border1, PB5Test);
                clickEvent(PB5Border1, PB5Test);
                clickEvent(PB6Border1, PB5Test);
                clickEvent(PB7Border1, PB5Test);
                clickEvent(PB8Border1, PB5Test);
                clickEvent(PB9Border1, PB5Test);
                //in case the user is trying to switch board pieces and the second one they click on is PB5Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB5Test);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB5Test);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB5Test);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB5Test);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB5Test);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB5Test);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB5Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB5Test);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB5Test);
            }
            else if (bordersSet && PB5TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB5TestBorder1);
            }
        }

        private void PB6Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB6TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB6TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the picturebox that was clicked last
                clickEvent(PB2Border1, PB6Test);
                clickEvent(PB1Border1, PB6Test);
                clickEvent(PB3Border1, PB6Test);
                clickEvent(PB4Border1, PB6Test);
                clickEvent(PB5Border1, PB6Test);
                clickEvent(PB6Border1, PB6Test);
                clickEvent(PB7Border1, PB6Test);
                clickEvent(PB8Border1, PB6Test);
                clickEvent(PB9Border1, PB6Test);
                //in case the user is trying to switch board pieces and the second one they click on is PB6Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB6Test);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB6Test);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB6Test);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB6Test);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB6Test);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB6Test);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB6Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB6Test);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB6Test);
            }
            else if (bordersSet && PB6TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB6TestBorder1);
            }
        }

        private void PB7Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB7TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB7TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the picturebox that was clicked last
                clickEvent(PB2Border1, PB7Test);
                clickEvent(PB1Border1, PB7Test);
                clickEvent(PB3Border1, PB7Test);
                clickEvent(PB4Border1, PB7Test);
                clickEvent(PB5Border1, PB7Test);
                clickEvent(PB6Border1, PB7Test);
                clickEvent(PB7Border1, PB7Test);
                clickEvent(PB8Border1, PB7Test);
                clickEvent(PB9Border1, PB7Test);
                //in case the user is trying to switch board pieces and the second one they click on is PB7Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB7Test);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB7Test);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB7Test);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB7Test);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB7Test);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB7Test);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB7Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB7Test);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB7Test);
            }
            else if (bordersSet && PB7TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB7TestBorder1);
            }
        }

        private void PB8Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB8TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB8TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the picturebox that was clicked last
                clickEvent(PB2Border1, PB8Test);
                clickEvent(PB1Border1, PB8Test);
                clickEvent(PB3Border1, PB8Test);
                clickEvent(PB4Border1, PB8Test);
                clickEvent(PB5Border1, PB8Test);
                clickEvent(PB6Border1, PB8Test);
                clickEvent(PB7Border1, PB8Test);
                clickEvent(PB8Border1, PB8Test);
                clickEvent(PB9Border1, PB8Test);
                //in case the user is trying to switch board pieces and the second one they click on is PB8Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB8Test);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB8Test);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB8Test);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB8Test);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB8Test);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB8Test);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB8Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB8Test);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB8Test);
            }
            else if (bordersSet && PB8TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB8TestBorder1);
            }
        }

        private void PB9Test_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB9TestClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB9TestClickCounter == 1)
            {
                //put the image around the highlighted picturebox onto the picturebox that was clicked last
                clickEvent(PB2Border1, PB9Test);
                clickEvent(PB1Border1, PB9Test);
                clickEvent(PB3Border1, PB9Test);
                clickEvent(PB4Border1, PB9Test);
                clickEvent(PB5Border1, PB9Test);
                clickEvent(PB6Border1, PB9Test);
                clickEvent(PB7Border1, PB9Test);
                clickEvent(PB8Border1, PB9Test);
                clickEvent(PB9Border1, PB9Test);
                //in case the user is trying to switch board pieces and the second one they click on is PB9Test
                clickEventBetweenBoardPieces(PB1TestBorder1, PB1Test, PB9Test);
                clickEventBetweenBoardPieces(PB2TestBorder1, PB2Test, PB9Test);
                clickEventBetweenBoardPieces(PB3TestBorder1, PB3Test, PB9Test);
                clickEventBetweenBoardPieces(PB4TestBorder1, PB4Test, PB9Test);
                clickEventBetweenBoardPieces(PB5TestBorder1, PB5Test, PB9Test);
                clickEventBetweenBoardPieces(PB6TestBorder1, PB6Test, PB9Test);
                clickEventBetweenBoardPieces(PB7TestBorder1, PB7Test, PB9Test);
                clickEventBetweenBoardPieces(PB8TestBorder1, PB8Test, PB9Test);
                clickEventBetweenBoardPieces(PB9TestBorder1, PB9Test, PB9Test);
            }
            else if (bordersSet && PB9TestClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB9TestBorder1);
            }
        }

        private void PB9_Click(object sender, EventArgs e)
        {
            //add  1 to clickCounter variable
            PB9ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB9ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB9ClickCounter == 2)
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
            //add  1 to clickCounter variable
            PB5ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB5ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB5ClickCounter == 2)
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
            //add  1 to clickCounter variable
            PB4ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB4ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB4ClickCounter == 2)
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
            //add  1 to clickCounter variable
            PB3ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB3ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB3ClickCounter == 2)
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
            //add  1 to clickCounter variable
            PB2ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB2ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB2ClickCounter == 2)
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
            //add  1 to clickCounter variable
            PB6ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB6ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB6ClickCounter == 2)
            {
                makeAllBordersInvisible();
            }
            //if bordersSet variable is not true, make the border labels appear
            else if (!bordersSet)
            {
                makeBordersVisible(PB6Border1);
            }




            //add  1 to clickCounter variable
            PB1ClickCounter++;
            //if bordersSet variable is true, which means that one of the testPB's are selected, use the clickEvent module to put an image onto the testPB
            if (bordersSet && PB1ClickCounter == 1)
            {
                clickEvent(PB2TestBorder1, PB2Test);
                clickEvent(PB1TestBorder1, PB1Test);
                clickEvent(PB3TestBorder1, PB3Test);
                clickEvent(PB4TestBorder1, PB4Test);
            }
            else if (bordersSet && PB1ClickCounter == 2)
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
                PB1TestBorder1.Visible = true; PB1TestBorder2.Visible = true; PB1TestBorder3.Visible = true; PB1TestBorder4.Visible = true;
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
        private void clickEvent(Label pbBorder, PictureBox PBTest)
        {
            //stretch the imagelayout through code so the rotated images have the same layout as the original
            PBTest.SizeMode = PictureBoxSizeMode.StretchImage;
            //if said image is clicked and the borders are visible on PB2
            if (pbBorder.Visible && pbBorder == PB2Border1)
            {
                //match the blank PB image with the PB2 image that has been clicked
                PBTest.ImageLocation = PB2.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB2 on the pieces because it is on the board
                PB2.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB1
            else if (pbBorder.Visible && pbBorder == PB1Border1)
            {
                //match the blank PB image with the PB1 image that has been clicked
                PBTest.ImageLocation = PB1.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB1 on the pieces because it is on the board
                PB1.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB3
            else if (pbBorder.Visible && pbBorder == PB3Border1)
            {
                //match the blank PB image with the PB3 image that has been clicked
                PBTest.ImageLocation = PB3.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB3 on the pieces because it is on the board
                PB3.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB4
            else if (pbBorder.Visible && pbBorder == PB4Border1)
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
            if (pbBorder.Visible && pbBorder == PB5Border1)
            {
                //match the blank PB image with the PB2 image that has been clicked
                PBTest.ImageLocation = PB5.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB5 on the pieces because it is on the board
                PB5.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB6
            else if (pbBorder.Visible && pbBorder == PB6Border1)
            {
                //match the blank PB image with the PB1 image that has been clicked
                PBTest.ImageLocation = PB6.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB6 on the pieces because it is on the board
                PB6.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB3
            else if (pbBorder.Visible && pbBorder == PB7Border1)
            {
                //match the blank PB image with the PB3 image that has been clicked
                PBTest.ImageLocation = PB7.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB7 on the pieces because it is on the board
                PB7.Visible = false;
            }
            //if said image is clicked and the borders are visible on PB8
            else if (pbBorder.Visible && pbBorder == PB8Border1)
            {
                //match the blank PB image with the PB4 image that has been clicked
                PBTest.ImageLocation = PB8.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB8 on the pieces because it is on the board
                PB8.Visible = false;

            }
            //if said image is clicked and the borders are visible on PB9
            else if (pbBorder.Visible && pbBorder == PB9Border1)
            {
                //match the blank PB image with the PB4 image that has been clicked
                PBTest.ImageLocation = PB9.ImageLocation;
                //make the borders invisible
                makeAllBordersInvisible();
                //eliminate the option to choose PB9 on the pieces because it is on the board
                PB9.Visible = false;

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
                PBNum.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader1.png";
            }
            //if the generated number equals 2
            else if (shufflePuzzlePieces[i] == 2)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader2.png
                PBNum.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader2.png";
            }
            //if the generated number equals 3
            else if (shufflePuzzlePieces[i] == 3)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader3.png
                PBNum.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader3.png";
            }
            //if the generated number equals 4
            else if(shufflePuzzlePieces[i] == 4)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader4.png
                PBNum.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader4.png";
            }
            //if the generated number equals 5
            if (shufflePuzzlePieces[i] == 5)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader5.png
                PBNum.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader5.png";
            }
            //if the generated number equals 6
            else if (shufflePuzzlePieces[i] == 6)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader6.png
                PBNum.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader6.png";
            }
            //if the generated number equals 7
            else if (shufflePuzzlePieces[i] == 7)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader7.png
                PBNum.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader7.png";
            }
            //if the generated number equals 8
            else if (shufflePuzzlePieces[i] == 8)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader8.png
                PBNum.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader8.png";
            }
            //if the generated number equals 9
            else if (shufflePuzzlePieces[i] == 9)
            {
                PBNum.SizeMode = PictureBoxSizeMode.StretchImage;
                //picturebox image will equal darthVader9.png
                PBNum.ImageLocation = "C:/Users/szymo/Desktop/C/Darth Vader Puzzle/darthVader9.png";
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
            //make all the picturebox borders invisible
            makeAllBordersInvisible();
            //to shuffle the box pieces
            shuffleGenerator();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

        }
    }
}
