class Breathing : Activity
{
    public Breathing(int durParam, string titleParam, string descParam)
        : base(durParam, titleParam, descParam) 
    {
    }
    
    protected override void ExecuteActivity()
    {
        int timeElapsed = 0;
        while (timeElapsed < _duration)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(4);
            Console.WriteLine("Breathe out...");
            ShowCountdown(4);
            timeElapsed += 8; // Each breath in and out takes 8 seconds
        }
    }
}