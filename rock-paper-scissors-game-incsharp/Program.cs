using System;

namespace rock_paper_scissors_game_incsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); // Random number generator for computer's choice
            bool playAgain = true; // Flag to control if the game should continue
            string player; // Player's choice (ROCK, PAPER, SCISSORS)
            string computer; // Computer's choice (ROCK, PAPER, SCISSORS)
            string answer; // Player's answer to play again or not

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                // Ask the player to enter ROCK, PAPER, or SCISSORS until valid input is provided
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper(); // Convert input to uppercase for case-insensitive comparison
                }

                // Generate computer's choice randomly
                switch (random.Next(1, 4)) // Changed random.Next(1.4) to random.Next(1, 4) to generate 1, 2, or 3
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                // Display player's and computer's choices
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                // Determine the winner
                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else // computer == "SCISSORS"
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        else // computer == "SCISSORS"
                        {
                            Console.WriteLine("You lose!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else // computer == "SCISSORS"
                        {
                            Console.WriteLine("It's a draw!");
                        }
                        break;
                }

                // Ask the player if they want to play again
                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper(); // Convert answer to uppercase for case-insensitive comparison

                // Check the player's answer to continue or quit the game
                if (answer == "Y")
                {
                    playAgain = true;
                }
                else if (answer == "N")
                {
                    playAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Exiting game.");
                    playAgain = false; // Exit the game for any invalid input
                }
            }

            Console.WriteLine("Thanks for Playing!");
            
        }
    }
}
// Made by GAURAV KHATRI from PAKISTAN