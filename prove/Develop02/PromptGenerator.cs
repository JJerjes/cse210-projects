using System;

public class Menu
{
    private Journal journal;

    public Menu()
    {
        journal = new Journal();
    }

    // Lista de preguntas
    private string[] sign = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If you had to do one thing today, what would it be?"
    };

    public void DisplayMenu()
    {
        int option;
        do
        {
            Console.WriteLine("\n*** Menu Journal ***");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Show journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    WriteNewEntry();
                    break;
                case 2:
                    journal.DisplayEntry();
                    break;
                case 3:
                    SaveJournal();
                    break;
                case 4:
                    LoadJournal();
                    break;
                case 5:
                    Console.WriteLine("See you later!"); 
                    break;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        } while (option != 5);
    }

    private void WriteNewEntry()
    {
        Random rand = new Random();
        int index = rand.Next(sign.Length); 
        string ask = sign[index]; 

        Console.WriteLine(ask);
        string answer = Console.ReadLine();  
        journal.SaveToFile(ask, answer);  
    }

    private void SaveJournal()
    {
        Console.Write("Enter the file name to save: ");
        string nameFile = Console.ReadLine();
      
        journal.SaveToFile(nameFile); 
    }

    private void LoadJournal()
    {
        Console.Write("Enter file name to load: ");
        string nameFile = Console.ReadLine();
        journal.LoadFromFile(nameFile); 
    }
}
