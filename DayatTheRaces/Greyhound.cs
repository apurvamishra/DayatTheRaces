using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace DayatTheRaces {
    class Greyhound {
        public int StartingPosition; // Where my PictureBox starts
        public int RacetrackLength; // How long the racetrack is 
        public PictureBox MyPictureBox; // My PictureBox object
        public int Location = 0; // My location on the racetrack
        public Random Randomiser; //an instance of Random

        public bool Run() {
            // Move forward either 1, 2, 3 or 4 spaces at random
            // Update the position of my PictureBox on the form 
            // Return true if I won the race 
            Point p = MyPictureBox.Location;
            p.X += Randomiser.Next(2);
            MyPictureBox.Location = p;
            if(p.X >= RacetrackLength) {
                return true;
            } else {
                return false;
            } 
        }
        
        public void TakeStartingPosition() {
          MyPictureBox.Location = new Point(30, StartingPosition);
          
        }
    }
}
