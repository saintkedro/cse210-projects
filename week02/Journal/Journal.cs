using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry) //adds a new entry to the journal
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display(); // uses Entry's Display method
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._title}|{entry._date}|{entry._promptText}|{entry._entryText}|{entry._lessonLearned}");
            }
        }
        
    }

    public void LoadFromFile(string filename)
    {
        _entries.Clear(); // Clear current entries

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (parts.Length < 3)
            {
                Console.WriteLine($"Skipped malformed line: {line}");
                continue;
            }

            Entry loadedEntry = new Entry();
            {
                loadedEntry._date = parts[0];
                loadedEntry._title = parts[1];
                loadedEntry._promptText = parts[2];
                loadedEntry._entryText = parts[3];
                loadedEntry._lessonLearned = parts[4];
            }

            _entries.Add(loadedEntry);

        }
    }

}

