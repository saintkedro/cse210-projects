using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the ScriptureMemorizer Project.");
        //Exceeding requirements...
        // Added 20 Scriptures
        // Type 'Next' to Skip to next scripture 
        // Let program work with a list of scriptures rather than a single one. 
        // Choose scriptures at random to present to the user.

        // Reference reference = new Reference("Proverbs", 3, 5, 6);
        // string text = "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";

        //Scripture scripture = new Scripture(reference, text);

        // Create a list of Scriptures (Bible and Book of Mormon)
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."),
            new Scripture(new Reference("2 Nephi", 2, 25), "Adam fell that men might be; and men are, that they might have joy."),
            new Scripture(new Reference("Mosiah", 2, 17), "When ye are in the service of your fellow beings ye are only in the service of your God."),
            new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ which strengtheneth me."),
            new Scripture(new Reference("Alma", 37, 6), "By small and simple things are great things brought to pass."),
            new Scripture(new Reference("Matthew", 5, 14), "Ye are the light of the world. A city that is set on an hill cannot be hid."),
            new Scripture(new Reference("Ether", 12, 27), "And if men come unto me I will show unto them their weakness."),
            new Scripture(new Reference("Romans", 8, 28), "All things work together for good to them that love God."),
            new Scripture(new Reference("Helaman", 5, 12), "Remember, it is upon the rock of our Redeemer, who is Christ, the Son of God, that ye must build your foundation."),
            new Scripture(new Reference("James", 1, 5), "If any of you lack wisdom, let him ask of God, that giveth to all men liberally."),
            new Scripture(new Reference("Jacob", 2, 18), "Before ye seek for riches, seek ye for the kingdom of God."),
            new Scripture(new Reference("1 Nephi", 3, 7), "I will go and do the things which the Lord hath commanded."),
            new Scripture(new Reference("Isaiah", 40, 31), "But they that wait upon the Lord shall renew their strength."),
            new Scripture(new Reference("D&C", 4, 2), "O ye that embark in the service of God, see that ye serve him with all your heart."),
            new Scripture(new Reference("Matthew", 6, 33), "But seek ye first the kingdom of God, and his righteousness."),
            new Scripture(new Reference("Mosiah", 3, 19), "The natural man is an enemy to God."),
            new Scripture(new Reference("Luke", 1, 37), "For with God nothing shall be impossible."),
            new Scripture(new Reference("Doctrine and Covenants", 10, 5), "Pray always, that you may come off conqueror."),
            new Scripture(new Reference("Psalms", 23, 1), "The Lord is my shepherd; I shall not want.")
        };

        Random random = new Random();
        scriptures = scriptures.OrderBy(s => random.Next()).ToList();

        // Loop through each scriptures
        foreach (var scripture in scriptures)
        {
            bool goToNext = false;

            while (!goToNext)
            {

                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());

                // If all words are hidden, show a congratulatory message and go to the next scripture
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words are hidden! If you can successfully memorize this scripture, congratulations!");
                    Console.WriteLine("\nPress Enter to continue to the next scripture...");
                    Console.ReadLine();
                    goToNext = true;
                    break;
                }

                Console.WriteLine("\nPress Enter to hide, type 'next' to move to the next scripture or type 'quit' to exit");
                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                break;

                else if (input.ToLower() == "next")
                goToNext = true;

                else
                scripture.HideRandomWords(3); // Hide 3 more random words
            }
        }

        // Final message after all scriptures are completed
        Console.WriteLine("\nYou have completed all scriptures. Well done!");
    }
}
