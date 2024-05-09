using CommandLine;
namespace Guess_the_lock
{
    internal class GameOptions
    {
        [Option('l', "length", Required = true, HelpText = "Length of the code")]
        public int Length { get; set; }
        [Option('t', "turns", Required = true, HelpText = "Number of turns")]
        public int GameTurns { get; set; }
    }
}
