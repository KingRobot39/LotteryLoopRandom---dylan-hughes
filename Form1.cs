using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryLoopRandom___dylan_hughes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //dylan hughes
        //570170
        //4/13/19
        //randomly pick a 3 digit number and compair it to a user entered 3 digit number 1000 times. if the numbers match display a winning message and stop compairing.

        private void generatebutton_Click(object sender, EventArgs e)
        {
            //input
            //declare variables
            bool firstB;
            bool secondB;
            bool thirdB;
            int countI = 1;
            int randone;
            int randtwo;
            int randthree;

            //validation
            firstB = int.TryParse(firstnumbertextbox.Text, out int firstI);
            secondB = int.TryParse(secondnumbertextbox.Text, out int secondI);
            thirdB = int.TryParse(thirdnumbertextbox.Text, out int thirdI);

            if (firstB == false || secondB == false || thirdB == false)
            {
                MessageBox.Show("Please enter three single digit numbers.");
                return;
            }

            if (firstI < 0 || firstI > 9 || secondI < 0 || secondI > 9 || thirdI < 0 || thirdI > 9)
            {
                MessageBox.Show("Please enter three single digit number.");
                return;
            }

            //clear listbox
            resultlistbox.Items.Clear();

            //random number generator
            Random rand = new Random();

            //loop repeats 1000 times
            while (countI <= 1000)
            {
                //pick three random numbers
                randone = rand.Next(10);
                randtwo = rand.Next(10);
                randthree = rand.Next(10);

                //reset label color
                numberonelabel.BackColor = SystemColors.Control;
                numbertwolabel.BackColor = SystemColors.Control;
                numberthreelabel.BackColor = SystemColors.Control;

                //if compairs generated numbers to user numbers
                if (firstI == randone && secondI == randtwo && thirdI == randthree)
                {
                    //displays picked numbers
                    numberonelabel.Text = randone.ToString();
                    numbertwolabel.Text = randtwo.ToString();
                    numberthreelabel.Text = randthree.ToString();

                    //changes backcolor
                    numberonelabel.BackColor = Color.LightGreen;
                    numbertwolabel.BackColor = Color.LightGreen;
                    numberthreelabel.BackColor = Color.LightGreen;

                    //winner message
                    resultlistbox.Items.Add("Attempt " + countI.ToString() + " number " + randone.ToString() + randtwo.ToString() + randthree.ToString());
                    MessageBox.Show("Congratulations! You matched your number after " + countI.ToString() +" tries!");
                    return;
                }

                //displays picked numbers
                numberonelabel.Text = randone.ToString();
                numbertwolabel.Text = randtwo.ToString();
                numberthreelabel.Text = randthree.ToString();

                //if statements change backcolors if numbers match
                if (firstI == randone)
                {
                    numberonelabel.BackColor = Color.LightGreen;
                }

                if(secondI == randtwo)
                {
                    numbertwolabel.BackColor = Color.LightGreen;
                }

                if (thirdI == randthree)
                {
                    numberthreelabel.BackColor = Color.LightGreen;
                }

                //display result in list box
                resultlistbox.Items.Add("Attempt " + countI.ToString() + " number " + randone.ToString() + randtwo.ToString() + randthree.ToString());

                //countI++
                countI++;
            }

            //fail message
            if(countI == 1001)
            {
                MessageBox.Show("Match failed after 1000 tries.");
                return;
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            //clear button
            firstnumbertextbox.Text = "";
            secondnumbertextbox.Text = "";
            thirdnumbertextbox.Text = "";
            numberonelabel.Text = "";
            numbertwolabel.Text = "";
            numberthreelabel.Text = "";
            numberonelabel.BackColor = SystemColors.Control;
            numbertwolabel.BackColor = SystemColors.Control;
            numberthreelabel.BackColor = SystemColors.Control;
            resultlistbox.Items.Clear();
        }
    }
}
