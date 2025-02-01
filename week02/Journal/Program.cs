public class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        bool running = true;

        while (running)
        {
            DisplayMenu();
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Handle writing a new entry
                    break;
                case "2":
                    // Display entries
                    journal.DisplayEntries();
                    break;
                case "3":
                    // Save journal to file
                    break;
                case "4":
                    // Load journal from file
                    break;
                case "5":
                    running = false;
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Exit");
    }
}
