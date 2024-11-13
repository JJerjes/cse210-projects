using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list if number, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter Number: ");

            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        if (numbers.Count > 0)
        {
            int suma = 0;
            foreach (int num in numbers)
            {
                suma += num;
            }
            double average = (double)suma / numbers.Count;

            int largest = numbers[0];
            foreach (int num in numbers)

            {
                if (num > largest)
                {
                    largest = num;
                }
            }

            Console.WriteLine($"The suma is: {suma}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}



