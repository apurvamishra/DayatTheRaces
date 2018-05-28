using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayatTheRaces {
    class Guy {
        public string Name; // The guy's name
        public Bet Mybet = null; // An instance of Bet() that has his bet
        public int Cash; // How much cash he has

        // The last two fields are the guy's GUI controls on the form 
        public RadioButton MyRadioButton; // My Radio Button
        public Label MyLabel; // My Label

        public void UpdateLabels() {
            MyRadioButton.Text = this.Name + " has " + this.Cash + "$ cash";
            // Set my label to my bet's description and the label on my 
            // radio button to show my cash (**)
        }

        public void ClearBet() { // Reset my bet so it's 
        }

        public void PlaceBet( int Amount, int Dog) {
            Mybet = new Bet() { Amount = Amount, Dog = Dog , Bettor = this};
            MyLabel.Text = Mybet.GetDescription(); 
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
        }

        public void Collect(int winner) { // Ask my bet to pay out

        }
    }
}
