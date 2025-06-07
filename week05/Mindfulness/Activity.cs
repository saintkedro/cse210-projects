abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private static Random _random = new Random();

    public void SetDuration(int seconds)
    {
        _duration = seconds;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine($"Duration: {_duration} seconds");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nGood job! You have completed the {_name} Activity.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "/", "-", "\\", "|" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < end)
        {
            Console.Write(spinner[i % 4]);
            Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }

    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    protected string GetRandomItem(List<string> items)
    {
        int index = _random.Next(items.Count);
        return items[index];
    }

    public abstract void Run();

}