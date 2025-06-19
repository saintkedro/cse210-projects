class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you overcame a challenge.",
        "Recall a moment of personal growth.",
        "Remember a time you helped someone."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel during it?",
        "What did you learn from it?",
        "How can you apply what you learned in the future?"
    };

    public ReflectingActivity()
    {
        _name = "Reflecting";
        _description = "This activity helps you reflect on times in your life when you have shown stregnth and resilience. This will help you recognize the power you have and how you can use it in other aspects .";
    }

    public override void Run()
    {
        string prompt = GetRandomItem(_prompts);
        Console.WriteLine($"\nPrompt: {prompt}");
        ShowSpinner(2);
        Console.WriteLine("\nNow consider the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = GetRandomItem(_questions);
            Console.WriteLine($"> {question}");
            ShowSpinner(4);
        }
    }
}