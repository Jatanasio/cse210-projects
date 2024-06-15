class Listing : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(int durParam, string titleParam, string descParam)
        : base(durParam, titleParam, descParam)
    {
    }

    protected override void ExecuteActivity()
    {
        Random random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine(prompt);
        ShowCountdown(5);
        Console.WriteLine("Start listing items:");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            itemCount++;
        }
        Console.WriteLine($"You listed {itemCount} items.");
    }
}
