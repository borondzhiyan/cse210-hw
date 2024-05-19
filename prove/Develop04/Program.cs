using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
 
    while (true){
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflectinging Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select the choice from the menu:");
        string choice = Console.ReadLine();
        Console.Clear();
        switch (choice){
            case"1":
            BreathingActivity breathing = new BreathingActivity();
            breathing.DisplayStartingMessage();
            breathing.Run();
            breathing.DisplayEndingMessage();
            break;

            case "2":
            ReflectingActivity reflecting = new ReflectingActivity();
            reflecting.DisplayStartingMessage();
            reflecting.Run();
            reflecting.DisplayEndingMessage();
            break;
            
            case "3":
            ListingActivity listing = new ListingActivity();
            listing.DisplayStartingMessage();
            listing.Run();
            listing.DisplayEndingMessage();
            break;
            
            case "4":
            Console.WriteLine ("Exiting the program.");
            return;

            default:
            Console.WriteLine("Invalid selection, please enter a number 1-4.");
            Thread.Sleep(3000);
            break;
            }
            Console.Clear();
        }
    }
}