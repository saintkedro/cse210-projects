using System.Security.Principal;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public override void Run()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.WriteLine("Get ready...");
        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(6);
            Console.Write("\nNow breathe out... ");
            ShowCountDown(6);
        }
       
    }
}