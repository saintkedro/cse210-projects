using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ScriptureMemorizer Project.");
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden! If you can successfully memorize this scripture, congratulations!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide or type 'quit' to exit");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(3); // Hide 3 random words

        }
    }

}
