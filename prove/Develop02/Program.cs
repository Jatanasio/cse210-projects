    //example from class

    // static public Journal workingJournal;
    // {
    //     static public WriteNewEntry();
    //     {
    //         Prompt prompter = newPrompt();
    //         string s = prompter.GeneratePrompt();
    //         Console.WriteLine(s);
    //         string uR = Console.ReadLine();
    //         //date,time = dt
    //         Entry CaptainLog = newEntry();
    //         CaptainLog._givenPrompt = s;
    //         CaptainLog._entryDateTime = dt;
    //         CaptainLog._entryText = uR;
    //         workingJournal.AppendEntry(CaptainLog);
    //         CaptainLog.Display();
    //     }
    // }

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Prompt prompt = new Prompt();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = prompt.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    Entry newEntry = new Entry
                    {
                        Prompt = randomPrompt,
                        Response = response,
                        Date = DateTime.Now.ToString() // Store date as a string
                    };
                    journal.AddEntry(newEntry);
                    Console.WriteLine("Entry saved.");
                    break;
                case "2":
                    List<Entry> entries = journal.GetEntries();
                    if (entries.Count == 0)
                    {
                        Console.WriteLine("The journal is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Journal Entries:");
                        foreach (Entry entry in entries)
                        {
                            Console.WriteLine($"Date: {entry.Date}");
                            Console.WriteLine($"Prompt: {entry.Prompt}");
                            Console.WriteLine($"Response: {entry.Response}");
                            Console.WriteLine();
                        }
                    }
                    break;
                case "3":
                    Console.Write("Enter file name to save the journal: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    Console.WriteLine("Journal saved to file.");
                    break;
                case "4":
                    Console.Write("Enter file name to load the journal: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    Console.WriteLine("Journal loaded from file.");
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

