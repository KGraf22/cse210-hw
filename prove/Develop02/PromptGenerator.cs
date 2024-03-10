using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            
            "What is a something that made you smile today?",

            "What is memmory of today that you will want to remember?",

            "What are somethings you are grateful for today?",

            "What is something that you have learned in your life that you would want to teach your offspring or future self?",

            "How did you see the hand of the Lord in your life today?"

        };
    }
    
    
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}