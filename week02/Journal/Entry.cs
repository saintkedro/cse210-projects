using System;
using System.Collections.Generic;

public class Entry
{
    public string _title;
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _lessonLearned;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Title: {_title} - Prompt: {_promptText}");
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"Lesson Learned: {_lessonLearned}\n");

    }
}