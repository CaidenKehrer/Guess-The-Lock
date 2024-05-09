# Guess The Lock

This project is a game called "Guess The Lock" where players attempt to guess a combination lock code. I made it after I saw a tiktok doing a similar game and so I took about 10 minutes and made my version so I could play at any difficulty I wanted.

## Environment

- Visual Studio 2022
- C# (.NET 8)

## Description

"Guess The Lock" is a command-line game written in C#. The game generates a random combination lock code of a specified length and the player has a certain number of turns to guess the code.

The game starts by accepting two command-line arguments: `--length <length>` and `--gameTurns <gameTurns>`. The `length` argument determines the length of the lock combination, and `gameTurns` sets the number of turns the player has to guess the combination.

After each guess, the game provides feedback to the player, indicating how many digits are correct and in the right position, and how many digits are correct but in the wrong position.

The game continues until the player guesses the combination or runs out of turns. If the player guesses the combination, they win the game. If they run out of turns, the game ends and reveals the correct combination.

This game is a fun way to test your memory and deduction skills. Enjoy!

## Installation

To run this project, follow these steps:

1. Clone the repository.
2. Open the project in Visual Studio 2022.
3. Build the project.
4. Run the application.

## Usage

To play the "Guess The Lock" game, you need to run the application with two command-line arguments: `--length <length>` and `--gameTurns <gameTurns>`.

Here's an example of how to run the game:

```sh
dotnet run --project "Guess the lock/Guess the lock.csproj" -- --length 4 --gameTurns 10
```

## Contributing

Contributions are welcome! If you find any issues or have suggestions, please open an issue or submit a pull request.

## License

This project is licensed under Creative Commons.

```

```
