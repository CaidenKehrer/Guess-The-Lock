using CommandLine;

namespace Guess_the_lock
{
    class Program
    {
        private const int RequiredArgs = 2;

        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<GameOptions>(args)
                .WithParsed(options =>
                {
                    var game = new Game(options.Length, options.GameTurns);
                    while (game.Run())
                    {
                        Console.Clear();
                    }
                    Console.WriteLine("Game over!");
                })
                .WithNotParsed(errors => PrintUsage());
        }

        static void PrintUsage()
        {
            Console.WriteLine("Usage: GuessTheLock --length <length>");
        }
    }

}
