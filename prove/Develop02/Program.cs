using System;
using System.IO;
// using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args) {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        Console.WriteLine ("Welcome to Your Daily Journal!");

        while (true) {
            Console.WriteLine ("Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? (1-5)");
            string choice = Console.ReadLine();

            switch (choice){
                case "1":
                string date = DateTime.Now.ToString();
                
                string prompt = generator.GenerateRandomPrompt();
                Console.WriteLine($"{prompt}");
                Console.Write("> ");
                string entryText = Console.ReadLine();
                Entry newEntry = new Entry(date, prompt,entryText); 
                // {
                    // _date = date,
                    // _promptText=prompt,
                    // _entryText = entryText,
                // };
                journal.AddEntry(newEntry);
                break;

                case "2":
                journal.DisplayAll();
                break;

                case "3":
                Console.WriteLine("What is the filename?");
                string LoadFileName=Console.ReadLine();
                journal.LoadFromFile(LoadFileName);
                Console.WriteLine($"Journal entries loaded from {LoadFileName}");   
                break;

                case "4":
                Console.Write("Please enter the filename you would like to save to: ");
                string SaveFileName = Console.ReadLine();
                journal.SaveToFile(SaveFileName);
                Console.WriteLine($"The file was saved in {SaveFileName}");
                break;

                case "5":
                Console.WriteLine ("Exiting the program.");
                return;

                default:
                Console.WriteLine("Invalid selection, please enter a number 1-5.");
                break;
            }
        }
    }

}
