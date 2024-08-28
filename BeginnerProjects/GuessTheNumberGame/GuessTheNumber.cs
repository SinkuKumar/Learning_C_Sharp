using System;

namespace BeginnerProjects.GuessTheNumberGame
{
    class GuessTheNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess The Number Game");

            Random rnd = new Random();
            int rnd_num = rnd.Next(0, 100);

            while (true)
            {
                while (true)
                {
                    try
                    {
                        Console.Write("Guess a number between 0 to 99: ");
                        int guess = int.Parse(Console.ReadLine());

                        if (guess > rnd_num)
                        {
                            Console.WriteLine("The guess is too high.");
                        }
                        else if (guess < rnd_num)
                        {
                            Console.WriteLine("The guess is too low.");
                        }
                        else if (guess == rnd_num)
                        {
                            Console.WriteLine("Your guess is right.");
                            break;
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid number");
                        break;
                    }
                }

                Console.Write("Do you want to play the game again? (yes/no): ");
                string continueCalculation = Console.ReadLine().ToLower();

                if (continueCalculation != "yes")
                {
                    break;
                }
            }
        }
    }
}
