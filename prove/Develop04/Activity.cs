abstract class Activity 
{
    // Attributes
    protected int _duration; 

    protected string _title; 

    protected string _desc;

    // Constructor
    public Activity(int durParam, string titleParam, string descParam)
    {
        _duration = durParam;
        _title = titleParam;
        _desc = descParam;
    }

    public void Start()
    {
        Console.Clear();
        Console.WriteLine($"Starting {_title} Activity");
        Console.WriteLine(_desc);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        ExecuteActivity();
        End();
    }

    public void End()
    {
        Console.WriteLine($"Good job! You completed the {_title} Activity in {_duration} seconds.");
        ShowSpinner(3);
    }

    protected abstract void ExecuteActivity();
    

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}