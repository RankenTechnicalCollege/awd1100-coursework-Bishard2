using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Random randomGenerator = new Random();
        int userWins = 0;
        int compWins = 0;
        int roundsPlayed = 0;

        // Clickable buttons (rock, paper, scissors)
        private void btnRock_Click(object sender, EventArgs e)
        {
            playRound("Rock");
        }
        private void btnPaper_Click(object sender, EventArgs e)
        {
            playRound("Paper");
        }
        private void btnScissors_Click(object sender, EventArgs e)
        {
            playRound("Scissors");
        }
        private void playRound(string userChoice)
        {
            if (roundsPlayed >= 3) return;

            //Picks a random number for the computers choice
            int pick = randomGenerator.Next(3); // 0 rock, 1 paper, 2 scissors
            string compChoice;
            if (pick == 0)
            {
                compChoice = "Rock";
                lblComputer.Text = "Computer picked Rock";
            }
            else if (pick == 1)
            {
                compChoice = "Paper";
                lblComputer.Text = "Computer picked Paper";
            }
            else
            {
                compChoice = "Scissors";
                lblComputer.Text = "Computer picked Scissors";
            }

            string roundResult;

            //Compares userChoice and compChoice
            if (userChoice == compChoice)
            {

            }
            else
            {
                if (userChoice == "Rock")
                {
                    if (compChoice == "Scissors")
                    {
                        userWins++;
                    }
                    else compWins++;
                }
                else if (userChoice == "Paper")
                {
                    if (compChoice == "Rock")
                    {
                        userWins++;
                    }
                    else
                    {
                        compWins++;
                    }
                }
                else
                {
                    if (compChoice == "Paper")
                    {
                        userWins++;
                    }
                    else
                    {
                        compWins++;
                    }
                }
            }

            roundsPlayed++;
            UpdateLabels();

            if (roundsPlayed >= 3)
            {
                btnRock.Enabled = false;
                btnPaper.Enabled = false;
                btnScissors.Enabled = false;

                string final;
                if (userWins > compWins)
                {
                    final = "You are the winner!";
                }
                else if (compWins > userWins)
                {
                    final = "You are the loser!";
                }
                else
                {
                    final = "Its as tie!";
                }

                lblResult.Text = final;
            }
        }
        private void UpdateLabels()
        {
            lblRound.Text = $"Round: {roundsPlayed} of 3";
            lblScore.Text = $"Score - Player: {userWins} Computer: {compWins}";
        }
    }
}