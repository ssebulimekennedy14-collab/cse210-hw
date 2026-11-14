using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine() ?? "";

            if (!int.TryParse(input, out int number))
            {
                Console.WriteLine("Please enter a whole number.");
                continue;
            }

            if (number == 0)
                break;

            numbers.Add(number);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("You did not enter any numbers.");
            return;
        }

        int sum = 0;
        int largest = numbers[0];
        int? smallestPositive = null;

        foreach (int number in numbers)
        {
            sum += number;

            if (number > largest)
                largest = number;

            if (number > 0 && (smallestPositive == null || number < smallestPositive))
                smallestPositive = number;
        }

        double average = (double)sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

        if (smallestPositive.HasValue)
            Console.WriteLine($"The smallest positive number is: {smallestPositive.Value}");
        else
            Console.WriteLine("There are no positive numbers.");

        numbers.Sort();
        Console.WriteLine("The sorted list is:");

        foreach (int number in numbers)
            Console.WriteLine(number);
    }
}
