using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create a few sample scriptures
        Reference ref1 = new Reference("John", 3, 16);
        Scripture scripture1 = new Scripture("For God so loved the world that He gave His one and only Son, that whoever believes in Him shall not perish but have eternal life.", ref1);

        Reference ref2 = new Reference("2 Nephi", 31, 15, 16);
        Scripture scripture2 = new Scripture("15 And I heard a voice from the Father, saying: Yea, the words of my Beloved are true and faithful. He that endureth to the end, the same shall be saved.\n\n16 And now, my beloved brethren, I know by this that unless a man shall endure to the end, in following the example of the Son of the living God, he cannot be saved.", ref2);

        // List of scriptures
        List<Scripture> scriptures = new List<Scripture> { scripture1, scripture2 };

        // Menu loop
        while (true)
        {
            Console.WriteLine("Choose a scripture to practice:");
            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scriptures[i].Ref}");
            }
            Console.WriteLine("Enter the number of the scripture or 'q' to quit:");

            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                break;
            }

            if (int.TryParse(input, out int choice) && choice > 0 && choice <= scriptures.Count)
            {
                Scripture selectedScripture = scriptures[choice - 1];
                PracticeScripture(selectedScripture);
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    public static void PracticeScripture(Scripture scripture)
    {
        string currentText = scripture.Text;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.Ref);
            Console.WriteLine(currentText);
            Console.WriteLine("\nPress Enter to hide 2 more words or 'q' to quit practicing.");

            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                break;
            }

            currentText = WordHider.HideWords(currentText, 2);
        }
    }
}
