using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayatTheRaces {
    public partial class Form1 : Form {
        Greyhound[] greyhounds = new Greyhound[4];
        Guy[] guys = new Guy[3];
        Random random1 = new Random();
        int raceLength = 350;


        public Form1() {
            InitializeComponent();
            greyhounds[0] = new Greyhound() { StartingPosition = 18, MyPictureBox = this.greyhound1, RacetrackLength = raceLength, Randomiser = random1 };
            greyhounds[1] = new Greyhound() { StartingPosition = 50, MyPictureBox = this.greyhound2, RacetrackLength = raceLength, Randomiser = random1 };
            greyhounds[2] = new Greyhound() { StartingPosition = 80, MyPictureBox = this.greyhound3, RacetrackLength = raceLength, Randomiser = random1 };
            greyhounds[3] = new Greyhound() { StartingPosition = 110, MyPictureBox = this.greyhound4, RacetrackLength = raceLength, Randomiser = random1 };

            guys[0] = new Guy() { Name = "Anay", Cash = 50, MyRadioButton = radioButton1, MyLabel = label3 };
            guys[1] = new Guy() { Name = "Amit", Cash = 50, MyRadioButton = radioButton2, MyLabel = label4 };
            guys[2] = new Guy() { Name = "Aryana", Cash = 50, MyRadioButton = radioButton3, MyLabel = label5 };

            updateform();
        }

        public void updateform()
        {
            int i;
            for (i = 0; i < 3; i++)
            {
                guys[i].UpdateLabels();
            }
            for (i = 0; i < 4; i++)
            {
                greyhounds[i].TakeStartingPosition();
            }
        }
        private void button2_Click(object sender, EventArgs e) {
            bool winner = false;
            while (!winner) {
                int i;
                for (i = 0; i < 4; i++) {
                    if (greyhounds[i].Run()) {
                        winner = true;
                        MessageBox.Show(i + 1 + " Greyhound Won!");
                        for (i = 0; i < 4; i++) {
                            greyhounds[i].TakeStartingPosition();
                        }
                        break;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (label6.Text)
            {
                case "Anay":
                    guys[0].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                    break;
                case "Amit":
                    guys[1].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                    break;
                case "Aryana":
                    guys[2].PlaceBet((int)numericUpDown1.Value, (int)numericUpDown2.Value);
                    break;
                default:
                    break;
            }

        }

        private void radioButton1_Click(object sender, EventArgs e){ 
            label6.Text = "Anay";
        }
        private void radioButton2_Click(object sender, EventArgs e){
            label6.Text = "Amit";
        }
        private void radioButton3_Click(object sender, EventArgs e){
            label6.Text = "Aryana";
        }
    }
 }
