using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness program:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();
            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new Breathing(0, "Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    break;
                
                case "2":
                    activity = new Reflection(0, "Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    break;
                
                case "3":
                    activity = new Listing(0, "Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    break;
                
                case "4":
                    return;
                
                default:
                    Console.WriteLine("Invalid choice, try again. ");
                    ShowSpinner(2);
                    continue;
            }

            activity?.Start();

            static void ShowSpinner(int seconds)
            {
                for (int i = 0; i < seconds; i++)
                {
                    Console.Write(".");
                    System.Threading.Thread.Sleep(1000);
                }

                Console.WriteLine();
            }
        }
    }
}