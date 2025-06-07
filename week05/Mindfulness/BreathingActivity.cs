class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by guiding you through slow breathing.";
    }

    public override void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(3);
            Console.Write("\nBreathe out... ");
            ShowCountDown(3);
            Console.WriteLine();
        }
    }
}