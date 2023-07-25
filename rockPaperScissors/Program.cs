using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int userPoints = 0;
            int pcPoints = 0;
            int roundNr = 0;



            while (roundNr < 3)
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissors, Lizard, Spock");
                Random rnd = new Random();
                int pcChoice = rnd.Next(0, 5);
                string userChoise = "";
                string[] validChoises = { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
                bool isValidChoise = false;
                while (!isValidChoise)
                {
                    Console.WriteLine("Please enter your choise (Rock, Paper, Scissors, Lizard, Spock)");
                    string userInput = Console.ReadLine();
                    Console.Clear();
                    
                    if (!string.IsNullOrWhiteSpace(userInput))
                    {
                        string formatedUserInput = userInput.Trim().ToUpper().Substring(0, 1) + userInput.Substring(1).ToLower();
                        if (Array.Exists(validChoises, choise => choise == formatedUserInput))
                        {
                            userChoise = formatedUserInput;
                            isValidChoise = true;
                        }
                    }
                    if (!isValidChoise)
                    {
                        Console.WriteLine("Invalid input. Please try again.");
                    }
                }

                Console.Clear();

                int result = Choises(pcChoice, userChoise);

                if (result == 1)
                {
                    userPoints++;
                    Console.WriteLine("You won this round!");
                }
                else if (result == 2)
                {
                    pcPoints++;
                    Console.WriteLine("You lost this round!");
                }
                else
                {
                    Console.WriteLine("I's a Tie in this round!");
                }

                roundNr++;

            }

            GetWinner(roundNr, userPoints, pcPoints);

            Console.ReadLine();
        }

        public static int Choises(int pcChoice, string userChoise)
        {
            switch (pcChoice)
            {

                case 0:
                    if (userChoise == "Paper" || userChoise == "Spock")
                    {
                        return 1;
                    }
                    else if (userChoise == "Scissors" || userChoise == "Lizard")
                    {
                        return 2;
                    }
                    break;

                case 1:
                    if (userChoise == "Rock" || userChoise == "Spock")
                    {
                        return 2;
                    }
                    else if (userChoise == "Scissors" || userChoise == "Lizard")
                    {
                        return 1;
                    }
                    break;
                case 2:
                    if (userChoise == "Rock" || userChoise == "Spock")
                    {
                        return 1;
                    }
                    else if (userChoise == "Paper" || userChoise == "Lizard")
                    {
                        return 2;
                    }
                    break;
                case 3:
                    if (userChoise == "Rock" || userChoise == "Scissors" || userChoise == "Spock")
                    {
                        return 1;
                    }
                    else if (userChoise == "Paper")
                    {
                        return 2;
                    }
                    break;
                case 4:
                    if (userChoise == "Rock" || userChoise == "Scissors")
                    {
                        return 2;
                    }
                    else if (userChoise == "Paper" || userChoise == "Lizard")
                    {
                        return 1;
                    }
                    break;
            }
            return 0;
        }

        private static void GetWinner(int roundNumber, int userPoints, int pcPoints)
        {
            if (roundNumber == 3)
            {
                Console.WriteLine($"Your result: {userPoints}");
                Console.WriteLine($"Computers result: {pcPoints}");
                if (userPoints > pcPoints)
                {
                    Console.WriteLine("You Won!!!");
                }
                else if (userPoints < pcPoints)
                {
                    Console.WriteLine("You Lost!!!");
                }
                else
                {
                    Console.WriteLine("It's a Tie!!!");
                }
            }
        }
    }
}
