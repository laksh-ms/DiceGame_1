// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Welcome to Tina's Dice Game!");
Console.WriteLine("Let's start!");
string? decision;
int count = 0;

//Dice Game
do
{
    Console.WriteLine(" ");
    Random random = new Random();
    int dice1 = random.Next(1, 7);
    int dice2 = random.Next(1, 7);

    int sum = dice1 + dice2;

    Console.WriteLine($"I got {dice1} and {dice2}!");

    if (sum % 2 == 0)
    {
        Console.WriteLine("Evens are better than odds!");
    }
    else
    {
        Console.WriteLine("Odds are still cool");
    }
    count ++;
    Console.WriteLine(" ");
    Console.WriteLine("Do you to Play again?(YES/NO)");

    decision = Console.ReadLine();
} while (decision == "YES");


Console.WriteLine($"The number of times the dice was thrown is: {count}");
Console.WriteLine("Nice game!");
Console.WriteLine("Thanks for playing, Come play again soon!");

