using System;
using System.IO;

public class Journal
{
    List<Entry> _entries = new List<Entry>();

    // Adds an entry to _entries
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // iterates through _entries, using Entry.Display()
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string file)
    {
        string filename = $"{file}.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        } 
    }
    public void LoadFromFile(string file)
    {
        
    }
}