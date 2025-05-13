using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO.Compression;

class Program
{
    static void Main(string[] args)
    {
        /*Work through these core requirements step-by-step to complete the program. Please don't skip ahead and do the whole thing at once, because others on your team may benefit from building the program up slowly.

    1. Compute the sum, or total, of the numbers in the list.

    2. Compute the average of the numbers in the list.

    3. Find the maximum, or largest, number in the list.*/

        Console.WriteLine("Enter a list of numbers, type 0 to quit. ");

        List<int> numbers = new List<int>();

        int userNumber = -1;
        // Collecting numbers
        do
        {
            Console.Write("Enter a number: ");

            userNumber = int.Parse(Console.ReadLine());

            if (userNumber != 0)

            {
                numbers.Add(userNumber);
            }

        } while (userNumber != 0);

        // Calculating the sum
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum of the numbers are: {sum}");

        // Calculating the average
        if (numbers.Count > 0)
        {
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");
        }
        
        // Finding Max Number
        int maxNumber = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The maximum number is: {maxNumber}");
        

    }
}