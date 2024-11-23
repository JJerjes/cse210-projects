using System;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("Juan", 3, "16");
        var scripture = new Scripture(reference, "For God so loved the world that he gave his only begotten Son");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press Enter to hide a word or type 'quit' to exit");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All the words have been hidden");
    }
}
