using System;

namespace JournalProgram
{
    public class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; }

        public Entry(string prompt, string response)
        {
            Prompt = prompt;
            Response = response;
            Date = DateTime.Now.ToShortDateString();
        }

        public override string ToString()
        {
            return $"[{Date}] {Prompt}\n{Response}\n";
        }
    }
}
