using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Tell me your score ");
        string valueFromUser=Console.ReadLine ();
        int percentage = int.Parse(valueFromUser);
        string letter = "";
        if (percentage >=90 )
        {
            letter = "A";
        }
        else if (percentage >=80)
        {
            letter = "B"; 
        }
        else if (percentage >=70)
        {
            letter = "C";
        }
        else if (percentage >=70)
        {
            letter = "D";
        }
        else if (percentage >=60)
        {
            letter = "E";
        }
        else
        {
            letter="F";
        }
        Console.WriteLine($"Your score is {letter} .");

        if (percentage>=70)
        {
            Console.WriteLine("You passed the course ");
        }
        else
        {
            Console.Write("You didn't pass the exam ");
        }
    }
}