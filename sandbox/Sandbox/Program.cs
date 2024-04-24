using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Sandbox World!");
        // string school = "BYU";
        // Console. WriteLine($"I am at {school}.");

        // Console.WriteLine("what's your favorite color? ");
        // string color = Console.ReadLine();
        // Console.WriteLine($"your color is {color}");
        Console.Write("Enter the number: ");
        string valueFromUser = Console.ReadLine ();

        int x=int.Parse (valueFromUser);
        int y=3;

        if (x>y)
        {
            Console.WriteLine("Greater");
        }
        else if (x<y)
        {
            Console.WriteLine("Less");
        }
        else
        {
            Console.WriteLine("equal");
        }
    }

        
}