
static void startGame(int totalGuesses, int top, int bottom)
{
    string[] humiliatingMessages = { "" };

    int randomNumber = new Random().Next(top, bottom);

    Console.WriteLine($"Guess the number between {top} and {bottom} - you have 5 attempts!");

    int guess;
    string userInput;

    userInput = Console.ReadLine();

    while (!int.TryParse(userInput, out guess))
    {
        Console.WriteLine("That is not a number!");
        userInput = Console.ReadLine();
    };
    guess = int.Parse(userInput);

    int guesses = 0;

    while (guess != randomNumber && guesses < totalGuesses)
    {
        Console.WriteLine("Wrong - try again, you have " + (4 - guesses) + " attempts left!");

        userInput = Console.ReadLine();

        while (!int.TryParse(userInput, out guess))
        {
            Console.WriteLine("That is not a number!");
            userInput = Console.ReadLine();
        };
        guess = int.Parse(userInput);

        guesses++;
    }

    if (guess == randomNumber)
    {
        Console.WriteLine($"You guessed it, the number was {randomNumber}.");
    }
    else
    {
        Console.WriteLine($"Yikes, didn't realise you were so bad at this! The number was {randomNumber}. Better luck next time!");
    }
}

startGame(5, 0, 25);
