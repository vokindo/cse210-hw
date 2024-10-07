// JournalEntry.cs
using System;

namespace JournalApp
{
    // Class representing a journal entry
    public class JournalEntry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public DateTime Date { get; set; }

        public JournalEntry(string prompt, string response)
        {
            Prompt = prompt;
            Response = response;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Date: {Date.ToShortDateString()}, Prompt: \"{Prompt}\", Response: \"{Response}\"";
        }
    }
}
