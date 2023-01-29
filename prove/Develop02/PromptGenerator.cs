using System;
using System.Collections.Generic;

public class PromptGenerator
{
    static Random rand = new Random();
    public List<string> _prompts = new List<string>() 
    // Many of the below  journal prompt ideas came from https://parade.com/1308069/steph-nguyen/journaling-prompts/#:~:text=Try%20these%20daily%20journaling%20prompts%201%20What%20was,you%20feel%20most%20authentically%20yourself%20today%3F%20More%20items
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If there were one thing I could do over today, what would it be?",
        "What is something that made you laugh today?",
        "What is one thing you want to remember from today?",
        "How can you make tomorrow (even) better than today?",
        "What are three things you’re grateful for today?",
        "What is one thing that challenged you today?",
        "When did you fail or mess up today?",
        "How did you take care of yourself today?",
        "How did you care for others today?",
        "How did you make progress toward a goal today? What can you do better tommorrow?"
    };

    public string GeneratePrompt()
    {
        int index = rand.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }
}