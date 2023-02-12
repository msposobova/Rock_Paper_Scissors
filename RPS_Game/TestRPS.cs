using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using RPS;

namespace testRPS
{
    internal class TestRPS
    {
        static void Main(string[] args)
        {
            //TestRPS ncl = new TestRPS(); 
            bool a = true;
            string result;

            Console.WriteLine("****** Rock, Paper, Scissors ******" + Environment.NewLine);
            
            while (a)
            {
                Console.WriteLine("Please choose one: " + Environment.NewLine +
                        "1.Rock" + Environment.NewLine +
                        "2.Paper" + Environment.NewLine +
                        "3.Scissors" + Environment.NewLine);

                if (!int.TryParse(Console.ReadLine(), out int userChoice))
                {
                    Console.WriteLine("Please enter a valid input.");
                    Console.WriteLine("------------------");
                    continue;
                }

                Random computerChoice = new Random();
                int compChoice = computerChoice.Next(1, 4);

                try
                {
                    result = RPS.RPS.RPSChecker(userChoice, compChoice);
                }

                catch (Exception ex) 
                { 
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("------------------");
                    continue;
                }


                if(userChoice == 1)
                { 
                   Console.WriteLine("User's choice is: Rock" + Environment.NewLine);
                }

                if (userChoice == 2)
                {
                    Console.WriteLine("User's choice is: Paper" + Environment.NewLine);
                }

                if (userChoice == 3)
                {
                   Console.WriteLine("User's choice is: Scissors" + Environment.NewLine);
                }

                if (compChoice == 1)
                {
                   Console.WriteLine("Computer's choice is: Rock" + Environment.NewLine);
                }

                if (compChoice == 2)
                {
                    Console.WriteLine("Computer's choice is: Paper" + Environment.NewLine);
                }

                if (compChoice == 3)
                {
                    Console.WriteLine("Computer's choice is: Scissors" + Environment.NewLine);
                }

                Console.WriteLine(result.ToString());

                Console.WriteLine("Do you want to continue: Y/N" + Environment.NewLine);
                char ch = Console.ReadLine().ToUpper()[0];

                if (ch == 'N')
                {
                    a = false;
                    Console.WriteLine("Hit Enter to quit.");
                }
                Console.WriteLine("************" + Environment.NewLine);
            }

            
                Console.ReadLine();
        }
    }
}
