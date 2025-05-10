using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string magicAnswer = Console.ReadLine();
        int magicNumber = int.Parse(magicAnswer);

        Console.Write("What is your guess? ");
        string guessAnswer = Console.ReadLine();
        int guessNumber = int.Parse(guessAnswer);

        string result = "";

        if (magicNumber > guessNumber)
        {
            result = "Higher";
        }
        else if (guessNumber == magicNumber)
        {
            result = "Congratulations, you guessed it!";
        }
        else
        {
            result = "Lower";
        }

        Console.WriteLine(result);

    }
}