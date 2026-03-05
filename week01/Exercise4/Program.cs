using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int userNumber;
        int total = 0;
        double avg = 0;
        int largestNumber = 0;
        int smallestPosNumber = 0;
        // Create a int list and 
        List<int> numbers = new List<int>();
        // loop to add number into the list
        do
        {
            Console.Write("Enter a int number (0 to quit): ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
            // if user enter 0, it will stop.
        } while (userNumber != 0);

        foreach (int number in numbers)
        {
            total += number;
            if (largestNumber < number)
            {
                largestNumber = number;
                if (smallestPosNumber == 0)
                {
                    smallestPosNumber = number;
                }
            }
            if (number != 0 && number > 0 && number < smallestPosNumber)
            {
                smallestPosNumber = number;
            }
        }
        avg = (float)total / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest Positive number is: {smallestPosNumber}");
        numbers.Sort();
        for (int i = 0; i < numbers.Count; i++){
            Console.WriteLine(numbers[i]);
        }
    }
}