using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while (true)
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    string randomPrompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {randomPrompt}");
                    Console.WriteLine("Enter your response: ");
                    string entryText = Console.ReadLine();
                    theJournal.AddEntry(new Entry(DateTime.Now.ToString("yyyy-MM-dd"), promptGenerator.GetRandomPrompt(), entryText));
                    theJournal.DisplayAll();
                    break; 
                case "2":
                    theJournal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Enter filename to save:");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;
                case "4":
                    Console.WriteLine("Enter filename to load:");
                    string loadFile =Console.ReadLine();
                    theJournal.LoadFromFile(loadFile);
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;

            }
        }
       

    }
}