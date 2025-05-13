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

        // second job instance
        Job job2 = new Job();
        job2._jobTitle = "Software Test Engineer";
        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2024;

        // Call method to display job details
        job1.DisplayJobDetails();
        job2.DisplayJobDetails();

        // Create new instance of the Resume class
        Resume resume = new Resume();
        resume._name = "Kingsley Isong"; // Add a name to the resume

        // add jobs to the resume
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        // Verify access and display the first job title using dot notation
        Console.WriteLine($"First Job Title: {resume._jobs[0]._jobTitle}");

    }
}
