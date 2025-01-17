using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    public class Journal
    {
        private List<Entry> entries = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("No journal entries yet. Start writing!");
            }
            else
            {
                foreach (Entry entry in entries)
                {
                    Console.WriteLine(entry.ToString());
                }
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine($"Journal saved to {filename}.");
        }

        public void LoadFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                entries.Clear();
                string[] lines = File.ReadAllLines(filename);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
                    }
                }
                Console.WriteLine($"Journal loaded from {filename}.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
