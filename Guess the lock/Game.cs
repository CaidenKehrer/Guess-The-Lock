
using System.Text;

namespace Guess_the_lock
{
    internal class Game
    {
        private int Length { get; set; }
        private int GameTurns { get; set; }
        public Game(int _codeLength, int gameTurns)
        {
            Length = _codeLength;
            GameTurns = gameTurns;
        }
        public bool Run()
        {
            var code = GenerateCode();
            Console.WriteLine($"Code generated. Start guessing! ");
            for (var i = 0; i < GameTurns; i++)
            {
                Console.WriteLine($"Turn {i + 1}/{GameTurns}");
                string? guess = null;
                while (guess == null)
                {
                    guess = Guess();
                }
                if (guess == code)
                {
                    Console.WriteLine("You win!");
                    return PlayAgain();
                }
                OutputValidAndClose(guess, code);
            }
            Console.WriteLine($"You lose! The code was {code}");
            return PlayAgain();
        }

        private bool PlayAgain()
        {
            Console.WriteLine("Play again? (y/n)");
            var response = Console.ReadLine();
            return response != null && response.ToLower() == "y";
        }

        private void OutputValidAndClose(string guess, string code)
        {
            var close = guess.Count(code.Contains);
            var valid = guess.Select((character, index) => code[index] == character).Count(val => val);
            Console.WriteLine($"Incorrect guess. - {close - valid} close - {valid} correct.");

        }

        private string? Guess()
        {
            Console.WriteLine("Enter your guess:");
            return VerifyGuess(Console.ReadLine());
        }

        private string? VerifyGuess(string? guess)
        {
            if (guess != null && guess.Length == Length)
            {
                return guess;
            }
            Console.WriteLine("Invalid guess. Try again!");
            return null;
        }

        private string GenerateCode()
        {
            var code = new StringBuilder();
            var random = new Random();
            for (var i = 0; i < Length; i++)
            {
                code.Append(random.Next(10));
            }
            if (code != null)
                return code.ToString();
            throw new Exception("Code generation failed");
        }
    }
}
