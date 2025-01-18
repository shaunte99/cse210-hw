using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        Console.WriteLine(" Welcome to Your Music Journal ");
        Console.WriteLine("\"Music gives a soul to the universe, wings to the mind, flight to the imagination, and life to everything.\" - Plato\n");

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Log a new song");
            Console.WriteLine("2. View your music journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Later! Keep enjoying the music.");
                    break;
                default:
                    Console.WriteLine("Wrong choice. Please try again.");
                    break;
            }
        }
    }
}
