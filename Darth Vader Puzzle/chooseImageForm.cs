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
    public partial class chooseImageForm : Form
    { 
        //for characterChosen variable on gamePage form
        private string character;
        public chooseImageForm()
        {
            InitializeComponent();
        }

        private void browseButton_Click(object sender, EventArgs e)
        {

        }
        private void openGamePage(string character)
        {
            //THIS CODE ALLOWS THE DIRECTORY TO BE CORRECT REGARDLESS OF THE COMPUTER OR USER
            //retrive current directory
            string currentDirectory = Environment.CurrentDirectory;
            //make it so that the newDirectory deletes everything past the first 'Darth Vader Puzzle'
            string newDirectory = currentDirectory.Replace("\\", "/");
            newDirectory = newDirectory.Replace("Darth Vader Puzzle/bin/Debug/net6.0-windows", "");

            //create instance of gamePage form
            gamePage game = new gamePage();
            //make the characterChosen variable on the gamePage form equal the character that was chosen
            game.characterChosen = character;
            //set the puzzle image of the character chosen for the user to look at as a reference
            game.puzzleImageDisplayPB.SizeMode = PictureBoxSizeMode.StretchImage;
            game.puzzleImageDisplayPB.ImageLocation = newDirectory + character + ".jpg";
            //hide this form
            this.Hide();
            //open gamePage
            game.ShowDialog();
        }
        private void darthVaderRB_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void deleteAllAddedFilePaths(string character)
        {
            //THIS CODE ALLOWS THE DIRECTORY TO BE CORRECT REGARDLESS OF THE COMPUTER OR USER
            //retrive current directory
            string currentDirectory = Environment.CurrentDirectory;
            //make it so that the newDirectory deletes everything past the first 'Darth Vader Puzzle'
            string newDirectory = currentDirectory.Replace("\\", "/");
            newDirectory = newDirectory.Replace("Darth Vader Puzzle/bin/Debug/net6.0-windows", "");

            //for loop comes into use in filepath directory later in this module
            for (int i = 1; i < 10; i++)
            {
                //string variable writes out the number i in the for loop currently equals
                string num = "One";
                if (i == 1)
                {
                    num = "One";
                }
                else if (i == 2)
                {
                    num = "Two";
                }
                else if (i == 3)
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
                else if (i == 9)
                {
                    num = "Nine";
                }

                //deleting all images that are preexisting in the folder from previous playing of the program
                //make 4 different filepath for each possible rotation the images can be in(ex: 90, 180, 270)
                var filePath1 = newDirectory + character + num + ".jpg";
                var filePath2 = newDirectory + character + num + "Rotated90.jpg";
                var filePath3 = newDirectory + character + num + "Rotated180.jpg";
                var filePath4 = newDirectory + character + num + "Rotated270.jpg";
                //if any of the filepath exists, delete it
                if (File.Exists(filePath1))
                {
                    File.Delete(filePath1);
                }
                if (File.Exists(filePath2))
                {
                    File.Delete(filePath2);
                }
                if (File.Exists(filePath3))
                {
                    File.Delete(filePath3);
                }
                if (File.Exists(filePath4))
                {
                    File.Delete(filePath4);
                }
            }
        }

        private void chooseImageForm_Load(object sender, EventArgs e)
        {
            gamePage game = new gamePage();
            game.characterChosen = "flash";
            game.ShowDialog();

            //delete any added file paths from previous plays of the program
            deleteAllAddedFilePaths("batman");
            deleteAllAddedFilePaths("darthVader");
            deleteAllAddedFilePaths("flash");
            deleteAllAddedFilePaths("spiderman");
        }
        private void hightlightPB(PictureBox PB)
        {
            if (PB.BorderStyle == BorderStyle.None)
            {
                //hightlight the border of spidermanPB
                PB.BorderStyle = BorderStyle.Fixed3D;
            }
            else if (PB.BorderStyle == BorderStyle.Fixed3D)
            {
                //unhighlight the border of spidermanPB
                PB.BorderStyle = BorderStyle.None;
            }
        }
        private void spidermanRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void batmanRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void flashRB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void darthVaderCB_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void unhighlightAllPBs()
        {
            spidermanPB.BorderStyle = BorderStyle.None;
            flashPB.BorderStyle = BorderStyle.None;
            batmanPB.BorderStyle = BorderStyle.None;
            darthVaderPB.BorderStyle = BorderStyle.None;
        }
 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if no other picturebox's are highlighted
            if(spidermanPB.BorderStyle == BorderStyle.None && flashPB.BorderStyle == BorderStyle.None && batmanPB.BorderStyle == BorderStyle.None)
            {
                hightlightPB(darthVaderPB);
            }
            else
            {
                unhighlightAllPBs();
                hightlightPB(darthVaderPB);
            }
            
        }

        private void spidermanCB_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void spidermanPB_Click(object sender, EventArgs e)
        {
            //if no other picturebox's are highlighted
            if (darthVaderPB.BorderStyle == BorderStyle.None && flashPB.BorderStyle == BorderStyle.None && batmanPB.BorderStyle == BorderStyle.None)
            {
                hightlightPB(spidermanPB);
            }
            else
            {
                unhighlightAllPBs();
                hightlightPB(spidermanPB);
            }
            
        }

        private void batmanPB_Click(object sender, EventArgs e)
        {
            //if no other picturebox's are highlighted
            if (spidermanPB.BorderStyle == BorderStyle.None && flashPB.BorderStyle == BorderStyle.None && darthVaderPB.BorderStyle == BorderStyle.None)
            {
                hightlightPB(batmanPB);
            }
            else
            {
                unhighlightAllPBs();
                hightlightPB(batmanPB);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //if no other picturebox's are highlighted
            if (spidermanPB.BorderStyle == BorderStyle.None && darthVaderPB.BorderStyle == BorderStyle.None && batmanPB.BorderStyle == BorderStyle.None)
            {
                hightlightPB(flashPB);
            }
            else
            {
                unhighlightAllPBs();
                hightlightPB(flashPB);
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            //open gamePage form and make the characterChosen variable on that form equal the character chosen on this form
            if(darthVaderPB.BorderStyle == BorderStyle.Fixed3D)
            {
                openGamePage("darthVader");
            }
            else if(batmanPB.BorderStyle == BorderStyle.Fixed3D)
            {
                openGamePage("batman");
            }
            else if(flashPB.BorderStyle == BorderStyle.Fixed3D)
            {
                openGamePage("flash");
            }
            else if(spidermanPB.BorderStyle == BorderStyle.Fixed3D)
            {
                openGamePage("spiderman");
            }
        }
    }
}
