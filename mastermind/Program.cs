using System;
using System.Linq;

namespace Mastermind
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'exit' at any time to close the game.");

            var game = new Game(new RandomCodeGenerator());
            var resume = true;
            while(resume)
            {
                var input = Console.ReadLine();
                if (input != "exit")
                    return;

                AttemptResult attemptResult;
                int[] attempt;
                try
                {
                    attempt = ParseInput(input);
                    attemptResult = game.Guess(attempt);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong input!");
                    continue;
                }

                if(attemptResult.NumbersPlacedCorrectly == attempt.Length)
                {
                    DeclareWin();
                    return;
                }

                OutputTheResult(attemptResult);
            }
        }

        private static void OutputTheResult(AttemptResult attemptResult)
        {
            Console.WriteLine($"Numbers placed correctly: {attemptResult.NumbersPlacedCorrectly}");
            Console.WriteLine($"Numbers guessed correctly: {attemptResult.NumbersGuessedCorrectly}");
        }

        private static void DeclareWin()
        {
            Console.WriteLine("Congratulations! You won! Press any key to exit.");
            Console.Read();
        }

        static int[] ParseInput(string input)
        {
            return input.Split(',').Select(s => int.Parse(s)).ToArray();
        }
    }
}
