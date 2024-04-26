using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName= PromptUserName();
        int numberInt=PromptUserNumber();
        Outcome(userName,numberInt);
        
    }
    static void DisplayWelcome()
    {
        Console.WriteLine ("Welcome to the program");
    }

    static string PromptUserName ()
    {
        Console.Write ("Please enter your name: ");
        string userName=Console.ReadLine ();
        return userName;
    }
    static int PromptUserNumber ()
    {
        Console.Write ("Please enter your favorite number: ");
        string userNumber=Console.ReadLine();
        int numberInt = int.Parse(userNumber);
        return numberInt;
    }
    static void Outcome (string userName,int numberInt)
    {
      Console.WriteLine($"{userName}, the square of your number is : {numberInt*numberInt}");  
    }

}