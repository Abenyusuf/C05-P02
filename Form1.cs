//Name : Ahmed Benyusuf
//Class and Section (CS 313 01)
//Assignment (Program 02 Chapter 05)
//Description of the Program : This program is a dice roller that generates two random numbers between 1 and 6 and displays the corresponding dice images for each number.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05_P02
{
    public partial class DiceRoller : Form
    {
        public DiceRoller()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RollButton_Click(object sender, EventArgs e)
        {

            //Hide all of the possible dice images
                DiceOnePictureBoxA.Visible = false;
                DiceOnePictureBoxB.Visible = false;

                DiceTwoPictureBoxA.Visible = false;
                DiceTwoPictureBoxB.Visible = false;

                DiceThreePictureBoxA.Visible = false;
                DiceThreePictureBoxB.Visible = false;

                DiceFourPictureBoxA.Visible = false;
                DiceFourPictureBoxB.Visible = false;

                DiceFivePictureBoxA.Visible = false;
                DiceFivePictureBoxB.Visible = false;

            
                DiceSixPictureBoxA.Visible = false;
                DiceSixPictureBoxB.Visible = false;

            //Create a random number generator
            Random rnd = new Random();
            //Generate two random numbers between 1 and 6
            int DiceA = rnd.Next(1, 7);
            int DiceB = rnd.Next(1, 7);

            //Display the dice images for the first dice
            if (DiceA == 1)
            {
                //Displays the dice image for the first die
                DiceOnePictureBoxA.Visible = true;
            }
            else if (DiceA == 2)
            {
                //Displays the dice image for the second die
                DiceTwoPictureBoxA.Visible = true;
            }
            else if (DiceA == 3)
            {
                //Displays the dice image for the third die
                DiceThreePictureBoxA.Visible = true;
            }
            else if (DiceA == 4)
            {
                //Displays the dice image for the fourth die
                DiceFourPictureBoxA.Visible = true;
            }
            else if (DiceA == 5)
            {
                //Displays the dice image for the fifth die
                DiceFivePictureBoxA.Visible = true;
            }
            else if (DiceA == 6)
            {
                //Displays the dice image for the sixth die
                DiceSixPictureBoxA.Visible = true;
            }

            //Display the dice images for the second dice
            if (DiceB == 1)
            {
                //Displays the dice image for the first die
                DiceOnePictureBoxB.Visible = true;
            }
            else if (DiceB == 2)
            {
                //Displays the dice image for the second die
                DiceTwoPictureBoxB.Visible = true;
            }
            else if (DiceB == 3)
            {
                //Displays the dice image for the third die
                DiceThreePictureBoxB.Visible = true;
            }
            else if (DiceB == 4)
            {
                //Displays the dice image for the fourth die
                DiceFourPictureBoxB.Visible = true;
            }
            else if (DiceB == 5)
            {
                //Displays the dice image for the fifth die
                DiceFivePictureBoxB.Visible = true;
            }
            else if (DiceB == 6)
            {
                //Displays the dice image for the sixth die
                DiceSixPictureBoxB.Visible = true;
            }
        }


    }
    }

