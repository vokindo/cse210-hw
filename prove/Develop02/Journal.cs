// Journal.cs
using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class Journal
    {
        private List<JournalEntry> entries;

        public Journal()
        {
            entries = new List<JournalEntry>();
        }

        public void AddEntry(JournalEntry entry)
        {
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            if (entries.Count == 0)
            {
                Console.WriteLine("The journal is empty.");
            }
            else
            {
                foreach (var entry in entries)
                {
                    Console.WriteLine(entry);
                    Console.WriteLine("-----------------------------");
                }
            }
        }

        public void SaveJournalToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"\"{entry.Date}\",\"{entry.Prompt}\",\"{entry.Response}\"");
                }
            }
            Console.WriteLine($"Journal saved to {filename}");
        }

        public void LoadJournalFromFile(string filename)
        {
            if (File.Exists(filename))
            {
                entries.Clear();
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(new[] { "\",\"" }, StringSplitOptions.None);
                        if (parts.Length == 3)
                        {
                            string date = parts[0].Trim('"');
                            string prompt = parts[1].Trim('"');
                            string response = parts[2].Trim('"');

                            entries.Add(new JournalEntry(prompt, response) { Date = DateTime.Parse(date) });
                        }
                    }
                }
                Console.WriteLine($"Journal loaded from {filename}");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
