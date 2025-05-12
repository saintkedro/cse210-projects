using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 to quit. ");

        List<int> numbers = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)

        {
            Console.Write("Enter a number: ");

            string userResponse = Console.ReadLine();

            userNumber = int.Parse(userResponse);

            numbers.Add(userNumber);
        }

        // Calculating the sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers are: {sum}");
        
    


            
        

    }
}