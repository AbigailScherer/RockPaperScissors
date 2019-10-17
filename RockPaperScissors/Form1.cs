using System;
using System.Windows.Forms;

/*
 *      In the game Rock Paper Scissors, two players 
 *      simultaneously choose one of three options: 
 *      rock, paper, or scissors.
 *      
 *      If both players choose the same option, then
 *      the result is a tie.
 *      
 *      However, if they choose differently, the winner
 *      is determined as follows:
 *      
 *      •	Rock beats scissors, because a rock can break 
 *          a pair of scissors. 
 *          
 *      •	Scissors beats paper, because scissors can cut 
 *          paper. 
 *          
 *      •	Paper beats rock, because a piece of paper can 
 *          cover a rock. 
 *          
 *      Create a game in which the computer randomly chooses 
 *      rock, paper, or scissors. Let the user enter a character, 
 *      r, p, or s, each representing one of the three choices. 
 *      
 *      Then, determine the winner. Save the application as 
 *      RockPaperScissors.
 */

namespace RockPaperScissors
{
    public partial class FormRockPapeerSccissors : Form
    {
        public FormRockPapeerSccissors()
        {
            InitializeComponent();
        }
        string userChoiceStr = "";
        int userChoice = 0;
        string computerChoiceStr = "";
        int computerChoice = 0;
        int userWins = 0;
        int computerWins = 0;
        int ties = 0;

        private void FormRockPapeerSccissors_Load(object sender, EventArgs e)
        {

        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            //Rules
            gameInstructions();
        }

        private void buttonRock_Click(object sender, EventArgs e)
        {
            //Rock button
            userChoiceStr = "Rock";
            userChoice = 1;
            makeComputerChoice();
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            //Paper button
            userChoiceStr = "Paper";
            userChoice = 2;
            makeComputerChoice();
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            //Scissors button
            userChoiceStr = "Scissors";
            userChoice = 3;
            makeComputerChoice();
        }

        private void makeComputerChoice()
        {
            Random rnd = new Random();
            textBoxComputerChoice.Text = rnd.Next(1, 4).ToString();

            textBoxUserChoice.Text = userChoiceStr;

            switch (computerChoice)
            {
                case 1:
                    computerChoiceStr = "Rock";
                    break;
                case 2:
                    computerChoiceStr = "Paper";
                    break;
                case 3:
                    computerChoiceStr = "Scissors";
                    break;
                default:
                    computerChoiceStr = "Rock";
                    break;
            }
            textBoxComputerChoice.Text = computerChoiceStr;
            textBoxUserChoice.Text = userChoiceStr;

            determineWinner();
        }

        private void determineWinner()
        {
            string winner = "";
            if (userChoice == computerChoice)
            {
                winner = "Tie Game";
                ++ties;
            }
            else if ((userChoice == 1) && (computerChoice == 3) ||
                (userChoice == 2) && (computerChoice == 1) ||
                (userChoice == 3) && (computerChoice == 2))
            {
                winner = "User";
                ++userWins;
            }
            else if ((computerChoice == 1) && (userChoice == 3) ||
                (computerChoice == 2) && (userChoice == 1) ||
                (computerChoice == 3) && (userChoice == 2))
            {
                winner = "Computer";
                ++computerWins;
            }
            textBoxWinner.Text = winner;
            textBoxUserWins.Text = userWins.ToString();
            textBoxComputerWIns.Text = computerWins.ToString();
            textBoxTies.Text = ties.ToString();

        }
        private void textBoxUserChoice_TextChanged(object sender, EventArgs e)
        {
            //Users choice
        }

        private void textBoxComputerChoice_TextChanged(object sender, EventArgs e)
        {
            //Computer choice
        }

        private void textBoxWinner_TextChanged(object sender, EventArgs e)
        {
            //Winner
        }

        private void textBoxUserWins_TextChanged(object sender, EventArgs e)
        {
            //Number of user wins
        }

        private void textBoxComputerWIns_TextChanged(object sender, EventArgs e)
        {
            //Number of computer wins
        }

        private void textBoxTies_TextChanged(object sender, EventArgs e)
        {
            //Number of ties
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //Clear button
            clearAllUpperTextBoxes();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Exit button
            if (MessageBox.Show("Exit the program now??",
                                "Exit Program???",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information) ==
                                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonResetAll_Click(object sender, EventArgs e)
        {
            //Reset button
            clearAllUpperTextBoxes();
            clearAllLowerTextBoxes();
            clearAllCounters();
        }

        private void clearAllUpperTextBoxes()
        {
            textBoxUserChoice.Text = "";
            textBoxComputerChoice.Text = "";
            textBoxWinner.Text = "";
        }

        private void clearAllLowerTextBoxes()
        {
            textBoxUserWins.Text = "";
            textBoxComputerWIns.Text = "";
            textBoxTies.Text = "";
        }
        private void clearAllCounters()
        {
            userWins = 0;
            computerWins = 0;
            ties = 0;
        }
        private void gameInstructions()
        {
            string outputStr = "";
            outputStr += "Welcome to Rock Paper Scissors!\n";
            outputStr += "\nIt is you against the computer\n";
            outputStr += "\nEach of the associated images is";
            outputStr += "a button. The player clicks on";
            outputStr += "one of the three buttons, meaning";
            outputStr += "s/he has selected Rock, Paper or scissors.\n";
            outputStr += "\nAfter the player has chosed, the compuer";
            outputStr += "will automatically choose either a 1, 2, or 3";
            outputStr += ", representing the computer's choice of Rock,";
            outputStr += "Paper, or Scissors.\n";
            outputStr += "\nThe program will keep track of the number";
            outputStr += "of player wins, the number of computer wins,";
            outputStr += " and the number of ties. These are shown ";
            outputStr += "in the associated textboxes at the buttom of the program.\n";
            outputStr += "\nYou should press the Clear button before starting a new game.\n";
            outputStr += "\nYou can also press the Restart All button at any time to reset all counters.";

            MessageBox.Show(outputStr,
                "Rock Paper Scissors Rules, ect.",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
