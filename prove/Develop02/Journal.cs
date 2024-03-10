using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries;
    
    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        if (_entries.Count ==0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (var entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (var entry in _entries)
                {
                    writer.WriteLine(entry.GetDate()+ "|"+ entry.GetPromptText() + "|"+ entry.GetEntryText());
                }
            }
            Console.WriteLine("Journal entry saved");

        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal entry : {ex.Message}");
        }

    }

    public void LoadFromFile(string file)
    {
        try
        {       
            _entries.Clear();
            using (StreamReader reader = new StreamReader(file))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split("|");
                    if (parts.Length == 3)
                    {
                        _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                }

            }
        
            Console.WriteLine("Journal entries loaded from the file successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found. Please try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal entries: {ex.Message}");
        }
    }
}