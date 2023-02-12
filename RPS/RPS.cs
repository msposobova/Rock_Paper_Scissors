using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RPS
{

    public class RPS
    {
        public static string RPSChecker(int userChoice, int compChoice)
        {

            if (userChoice < 1 || userChoice > 3)   
            {
                throw new Exception("Please enter a number 1, 2 or 3.");
            }


            if (userChoice == compChoice) //tie
            {
                    return "It's a tie";
            }

            else if ((compChoice == 1 && userChoice == 2) || (compChoice == 2 && userChoice == 3) || (compChoice == 3 && userChoice == 1)) //user wins
            {
                return "User wins";
            }
            else //comp wins
            {
                return "Computer Wins";
            }
        }
    }
}