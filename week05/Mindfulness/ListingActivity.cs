class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "List as many things you are grateful for as you can.",
        "List people who have helped you this week.",
        "List goals you are working on."
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity helps you reflect on the positive aspects of your life.";
    }

    public override void Run()
    {
        string prompt = GetRandomItem(_prompts);
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("Start listing. Press Enter after each item. Time begins now!");

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("- ");
            if (Console.KeyAvailable)
            {
                responses.Add(Console.ReadLine());
            }
        }

        _count = responses.Count;
        Console.WriteLine($"\nYou listed {_count} items. Well done!");
    }
}