using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber =-1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            //add the number if the number is not 0
            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }
        }
        // calculate the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        //calculate the average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        //find the max
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");

        // the smallest positive number
        int minPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            if (number > 0 && number < minPositive)
            {
                minPositive = number;
            }
        }
        if (minPositive == int.MaxValue)
        {
            Console.WriteLine("No positive numbers were enetered.");
        }
        else
        {
            Console.WriteLine($"The smallest positive number is: {minPositive}");
        }

    }
}