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
        private string newDirectory;
        public string characterChosen;
        public congragulationsForm()
        {
            InitializeComponent();
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
        private void exitProgramButton_Click(object sender, EventArgs e)
        {
            //delete all added images from cutting and rotating through bitmap
            deleteAllAddedFilePaths("darthVader");
            deleteAllAddedFilePaths("spiderman");
            deleteAllAddedFilePaths("batman");
            deleteAllAddedFilePaths("flash");
            //exit app
            Application.Exit();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            //stop the audio that is currently playing

            //THIS CODE ALLOWS THE DIRECTORY TO BE CORRECT REGARDLESS OF THE COMPUTER OR USER
            //retrive current directory
            string currentDirectory = Environment.CurrentDirectory;
            //make it so that the newDirectory deletes everything past the first 'Darth Vader Puzzle'
            newDirectory = currentDirectory.Replace("\\", "/");
            newDirectory = newDirectory.Replace("Darth Vader Puzzle/bin/Debug/net6.0-windows", "");

            SoundPlayer soundPlayer = new SoundPlayer(newDirectory + characterChosen + "gameTrack.wav");
            soundPlayer.Stop();

            //hide this form
            this.Hide();
            //open chooseImage form
            chooseImageForm choose = new chooseImageForm();
            choose.ShowDialog();
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
            dvGifPB.ImageLocation = newDirectory + characterChosen + ".gif";
        }
    }
}
