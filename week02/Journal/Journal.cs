using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry()
    {
        Console.Write("\nWhat song did you listen to? ");
        string song = Console.ReadLine();

        Console.Write("Who is the artist you listened to? ");
        string artist = Console.ReadLine();

        Console.Write("What is the genre? ");
        string genre = Console.ReadLine();

        Console.Write("Which date was the song played? ");
        string date = Console.ReadLine();

        Entry newEntry = new Entry(song, artist, genre, date);
        _entries.Add(newEntry);

        Console.WriteLine("\nEntry added successfully.");
    }

    public void DisplayEntries()
    {
        Console.WriteLine("\nMusic Journal Entries ");
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet. Start logging your music journey today! 🎧");
        }
        else
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry);
                Console.WriteLine(new string('-', 40));
            }
        }
    }

    
    public void SaveToFile()
{
    Console.Write("\nEnter a filename to save your journal (e.g., music_journal.json): ");
    string filename = Console.ReadLine();

   
    string json = JsonSerializer.Serialize(_entries, new JsonSerializerOptions { WriteIndented = true });
    File.WriteAllText(filename, json);

    Console.WriteLine($"Journal was saved successfully to {filename}!");
}



public void LoadFromFile()
{
    Console.Write("\nEnter a filename to load your journal (e.g., music_journal.json): ");
    string filename = Console.ReadLine();

    if (File.Exists(filename))
    {
        
        string json = File.ReadAllText(filename);
        _entries = JsonSerializer.Deserialize<List<Entry>>(json) ?? new List<Entry>();

        Console.WriteLine("Journal loaded successfully.");
    }
    else
    {
        Console.WriteLine("File not found. Try again.");
    }
}

}

