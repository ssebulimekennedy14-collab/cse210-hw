using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine() ?? "";

        if (!double.TryParse(input, out double percentage) || percentage < 0 || percentage > 100)
        {
            Console.WriteLine("Please enter a number from 0 to 100.");
            return;
        }

        string letter;

        if (percentage >= 90)
            letter = "A";
        else if (percentage >= 80)
            letter = "B";
        else if (percentage >= 70)
            letter = "C";
        else if (percentage >= 60)
            letter = "D";
        else
            letter = "F";

        string sign = "";
        int lastDigit = (int)percentage % 10;

        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
                sign = "+";
            else if (lastDigit < 3)
                sign = "-";
        }
        else if (letter == "A" && lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (percentage >= 70)
            Console.WriteLine("Congratulations! You passed the course.");
        else
            Console.WriteLine("Keep working hard. You can do better next time.");
    }
}
