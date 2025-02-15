using System;
using System.Collections.Generic;
using System.IO;
public class MzansiQuest
{
    private List<UbuntuGoal> ubuntuGoals = new List<UbuntuGoal>();
    private int totalPoints = 0;

    public void Start()
    {
        Console.WriteLine("🦁 Welcome to **Mzansi Quest** – Your Ultimate Goal Hustle 🇿🇦");
        while (true)
        {
            Console.WriteLine("\nSelect Your Action:");
            Console.WriteLine("1.  Add New Goal");
            Console.WriteLine("2.  Log Progress");
            Console.WriteLine("3.  View All Goals");
            Console.WriteLine("4.  View XP Points");
            Console.WriteLine("5.  Save Your Hustle");
            Console.WriteLine("6.  Load Saved Hustle");
            Console.WriteLine("7.  Exit");

            string userChoice = Console.ReadLine();
            switch (userChoice)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    LogProgress();
                    break;
                case "3":
                    ShowGoals();
                    break;
                case "4":
                    Console.WriteLine($" Your XP: {totalPoints} points");
                    break;
                case "5":
                    SaveAllGoals();
                    break;
                case "6":
                    LoadAllGoals();
                    break;
                case "7":
                    Console.WriteLine("Totsiens! Keep grinding, Mzansi legend!");
                    return;
                default:
                    Console.WriteLine("Eish, invalid option! Try again.");
                    break;
            }
        }
    }

    private void AddGoal()
    {
        Console.WriteLine("Select Goal Type: 1) Once-Off  2) Forever  3) Hustle List ");
        string goalType = Console.ReadLine();

        Console.Write("Give your Goal a Name (e.g., 'Ace Final Exams', 'Learn Xhosa'): ");
        string goalName = Console.ReadLine();
        Console.Write("Points for Success (e.g., 100 XP): ");
        int points = int.Parse(Console.ReadLine());

        if (goalType == "1")
            ubuntuGoals.Add(new OneTimeGoal(goalName, points));
        else if (goalType == "2")
            ubuntuGoals.Add(new ForeverGoal(goalName, points));
        else if (goalType == "3")
        {
            Console.Write("How many times to complete this goal? (e.g., 5 times): ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus XP on Completion: ");
            int bonusXP = int.Parse(Console.ReadLine());
            ubuntuGoals.Add(new HustleListGoal(goalName, points, target, bonusXP));
        }
        else
            Console.WriteLine("Hawu! Invalid choice.");
    }

    private void LogProgress()
    {
        ShowGoals();
        Console.Write("Choose a goal to log progress: ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice < 0 || choice >= ubuntuGoals.Count)
        {
            Console.WriteLine("Wrong choice, bru.");
            return;
        }

        totalPoints += ubuntuGoals[choice].LogProgress();
        Console.WriteLine("Mooi! Your progress is locked in.");
    }

    private void ShowGoals()
    {
        Console.WriteLine("\n Your Mzansi Hustle Goals:");
        for (int i = 0; i < ubuntuGoals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {ubuntuGoals[i].DisplayStatus()}");
        }
    }

    private void SaveAllGoals()
    {
        using (StreamWriter writer = new StreamWriter("ubuntu_hustle.txt"))
        {
            writer.WriteLine(totalPoints);
            foreach (UbuntuGoal g in ubuntuGoals)
                writer.WriteLine(g.SaveGoal());
        }
        Console.WriteLine(" Your hustle is saved!");
    }

    private void LoadAllGoals()
    {
        if (!File.Exists("ubuntu_hustle.txt"))
        {
            Console.WriteLine("No saved hustle found.");
            return;
        }

        string[] dataLines = File.ReadAllLines("ubuntu_hustle.txt");
        totalPoints = int.Parse(dataLines[0]);
        ubuntuGoals.Clear();

        for (int i = 1; i < dataLines.Length; i++)
        {
            string[] parts = dataLines[i].Split(':');
            string type = parts[0];
            string[] data = parts[1].Split(',');

            if (type == "OneTime")
                ubuntuGoals.Add(new OneTimeGoal(data[0], int.Parse(data[1])));
            else if (type == "Forever")
                ubuntuGoals.Add(new ForeverGoal(data[0], int.Parse(data[1])));
            else if (type == "HustleList")
                ubuntuGoals.Add(new HustleListGoal(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[4])));
        }
        Console.WriteLine(" Hustle loaded successfully!");
    }
}
