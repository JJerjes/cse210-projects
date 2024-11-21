using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<string> entries;

    public Journal()
    {
        entries = new List<string>();
    }

    public void DisplayEntry()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No entries in the journal.");
        }
        else
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);  
            }
        }
    }

    public void SaveToFile(string question, string answer)
    {

        string entry = $"Question: {question}\nAnswer: {answer}\nDate: {DateTime.Now}\n";

        entries.Add(entry);

        string filePath = "journal.txt";  
        
        using (StreamWriter writer = new StreamWriter(filePath, true)) 
        {
            writer.WriteLine(entry);  
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName, false))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry);
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] fileEntries = File.ReadAllLines(fileName);

            entries.Clear();  

            foreach (var line in fileEntries)
            {
                entries.Add(line); 
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
