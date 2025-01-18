using System;

namespace JournalProgram
{
    class KamoJournalMaster
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            string[] prompts = {
                "Who was the most interesting person you met today?",
                "What was the best part of your day?",
                "How did you see God's hand in your life today?",
                "What was the strongest emotion you felt today?",
                "If you could redo one thing today, what would it be?"
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nJournal Menu:");
                Console.WriteLine("1. Write a New Entry");
                Console.WriteLine("2. Display Journal");
                Console.WriteLine("3. Save Journal");
                Console.WriteLine("4. Load Journal");
                Console.WriteLine("5. Quit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Random random = new Random();
                        string prompt = prompts[random.Next(prompts.Length)];
                        Console.WriteLine($"\nPrompt: {prompt}");
                        Console.Write("Your response: ");
                        string response = Console.ReadLine();
                        journal.AddEntry(new Entry(prompt, response));
                        Console.WriteLine("Entry added!");
                        break;
                    case "2":
                        Console.WriteLine("\nJournal Entries:");
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.Write("Enter filename to save journal: ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;
                    case "4":
                        Console.Write("Enter filename to load journal: ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
