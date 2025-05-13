using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // create first job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2021;
        job1._endYear = 2023;

        // Display Company of first job. 
        Console.WriteLine($"{job1._company}");

        Job job2 = new Job();
        job2._jobTitle = "Software Test Engineer";
        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2024;

        // Display company of second job
        Console.WriteLine($"{job2._company}");
    }
}