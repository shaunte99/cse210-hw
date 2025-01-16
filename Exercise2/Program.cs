using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What's your grade percentage?");
        string input = Console.ReadLine();

        int gradePercentage = int.Parse(input);

        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, You passed the course.");
        }
        else
        {
            Console.WriteLine("Never give up, You will be great next time.");
        }
    }
}
