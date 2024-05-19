using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> prompts;

    public Prompt()
    {
        prompts = new List<string>
        {
            "What was the best part of my day?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
            "How many times did I laugh today?"
            "Did I help brighten anyone's day? How?"
            ""
        };
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}
