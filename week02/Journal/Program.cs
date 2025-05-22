using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal(); // create journal object
        PromptGenerator promptGenerator = new PromptGenerator();
        string userChoice = "";

        Console.WriteLine("Hello! Welcome to the Journal Program...");


        while (userChoice != "5") // loop until user chooses to quit

        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the Journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt(); // gets a random prompt
                Console.WriteLine($"{prompt}: ");
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry
                {
                    _date = DateTime.Now.ToShortDateString(),
                    _promptText = prompt,
                    _entryText = response
                };

                journal.AddEntry(newEntry);
                Console.WriteLine("Entry added.\n");
            }
            else if (userChoice == "2")
            {
                Console.WriteLine("Your Journal Entries:");
                journal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.WriteLine("Enter filename to save to (e.g., journal.txt): ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Journal Saved.\n");
            }
            else if (userChoice == "4")
            {
                Console.WriteLine("Enter filename to load (e.g., journal.txt):");
                string filename = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(filename) && File.Exists(filename))
                {
                    journal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded from file.");
                }
                else
                {
                    Console.WriteLine("File not found or invalid filenme.");
                }
            }
            
            else if (userChoice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }

        }
    }
} 