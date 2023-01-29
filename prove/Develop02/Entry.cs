using System;

public class Entry
{
    public string _entry;
    public string _prompt;
    public static DateTime date = DateTime.Now;
    public string _dateString = date.ToShortDateString();
    public string _timeString = date.ToShortTimeString();


    public void DisplayEntry()
    {
        string _compiledEntry = $"Date: {_dateString} @ {_timeString} - Prompt: {_prompt} \n{_entry}\n";
        Console.WriteLine(_compiledEntry);
    }

}