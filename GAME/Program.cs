using System;

class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.White;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;

        Random random = new Random();
        string[] choices = { "rock", "paper", "scissors" };

        Console.WriteLine("Welcome to Rock, Paper, Scissors!");

        int playerScore = 0;
        int computerScore = 0;

        do
        {
            Console.WriteLine("Enter your choice (rock, paper, or scissors):");
            string playerChoice = Console.ReadLine().ToLower();

            if (Array.IndexOf(choices, playerChoice) == -1)
            {
                Console.WriteLine("Invalid choice,you lost a point! Please try again.");
                Console.WriteLine("If you continue to play, the computer score will be counted in, if you press no the game will end.");
            }




            int randomIndex = random.Next(choices.Length);
            string computerChoice = choices[randomIndex];

            Console.WriteLine($"Computer chooses {computerChoice}");

            if (playerChoice == computerChoice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerChoice == "rock" && computerChoice == "scissors")
            {
                Console.WriteLine("You win! Rock smashes scissors");
                playerScore++;
            }

            else if (playerChoice == "paper" && computerChoice == "rock")
            {
                Console.WriteLine("You win! Paper covers Rock");
                playerScore++;
            }

            else if (playerChoice == "Scissors" && computerChoice == "Paper")
            {
                Console.WriteLine("You win! Scissors cut Paper");
                playerScore++;
            }
            else
            {
                Console.WriteLine("Computer wins!");
                computerScore++;
            }

            

            Console.WriteLine("Play again? (yes/no)");
        } while (Console.ReadLine().ToLower() == "yes");
        Console.WriteLine($"Score: Player {playerScore}, Computer {computerScore}");
        Console.WriteLine("Thanks for playing. Goodbye!");


    }
}
