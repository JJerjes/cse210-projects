using System;
class Program
{
    static void Main(string[] args)
    {
        string keep_playing = "yes";

        while (keep_playing == "yes")
        {
            Random numbeRandom = new Random();
            int number = numbeRandom.Next(1, 10);

            int account = 0;
            int guess = -1;

            while (guess != number)
            {
                Console.Write("Guess the number (1 to 10)");
                guess = int.Parse(Console.ReadLine());
                account++;

                if (number > guess)
                {
                    Console.WriteLine("Higther");
                }
                else if (number < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                Console.WriteLine($"You triet {account} times");
            }
            Console.Write($"Do you want to keep playing (yes/no): ");
            keep_playing = Console.ReadLine().ToLower();
        }
        Console.WriteLine("Thank You!!");
    }
}
