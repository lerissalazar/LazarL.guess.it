//Lerissa Lazar
//10-22-20
//Guessing game
//The user is going to choose a level, and try to guess the random number based on what level they chose. They get as many tries as
//they need and the computer will output the amount of tries it took.

Console.Clear();

int easyLvl = 11;
int medLvl = 51;
int hardLvl = 101;
int winningNum = 0;
int numTried = 0;
int userInput;
string? mode;
string? userGuess = "";
bool validNum = false;
bool guessAgain = true;
bool playAgain = true;

while (playAgain)
{
    Console.WriteLine("Hey! Lets play a guessing game. Choose the mode you'd like to play in");
    Console.WriteLine("Easy : Guess from 1-10");
    Console.WriteLine("Medium : Guess from 1-50");
    Console.WriteLine("Hard : Guess from 1-100");
    Console.WriteLine("Enter your choice: Easy, Medium, or Hard");
    mode = Console.ReadLine();
    mode = mode.ToLower();

    while (mode != "easy" && mode != "medium" && mode != "hard")
    {
        Console.WriteLine("Invalid choice, pick : easy, medium or hard?");
        mode = Console.ReadLine();
    }

    Console.WriteLine($"You chose {mode} , enter a number");

    Random random = new Random();

    if (mode == "easy")
    {
        winningNum = random.Next(1, easyLvl);
    }
    else if (mode == "medium")
    {
        winningNum = random.Next(1, medLvl);
    }
    else if (mode == "hard")
    {
        winningNum = random.Next(1, hardLvl);
    }
    guessAgain = true;
    while (guessAgain)
    {
        userGuess = Console.ReadLine();
        validNum = int.TryParse(userGuess, out userInput);

        if (validNum)
        {

            if (winningNum < userInput)
            {
                numTried++;
                Console.WriteLine($"The winning number is less than {userInput}");
            }
            else if (winningNum > userInput)
            {
                numTried++;
                Console.WriteLine($"The winning number is greater than {userInput}");
            }
            else
            {
                numTried++;
                Console.WriteLine($"You got it right, you took {numTried} tries!");
                guessAgain = false;
            }
        }
        else
        {
            Console.WriteLine("Invalid response");
        }
    }
    Console.WriteLine("Would you like to play again? Yes or no?");

    string goAgain;
    bool validInput = false;
    while (!validInput)
    {
        goAgain = Console.ReadLine().ToLower();
        if (goAgain == "yes")
        {
            validInput = true;
        }
        else if (goAgain == "no")
        {
            validInput = true;
            playAgain = false;
            Console.WriteLine("Thank you for playing!");
        }
        else
        {
            Console.WriteLine("Invalid repsonse, answer yes or no");
        }
    }
}
