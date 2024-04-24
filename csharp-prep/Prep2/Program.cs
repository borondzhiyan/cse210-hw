using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
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
        else if (percentage >=60)
        {
            letter = "D";
        }
        else if (percentage >=50)
        {
            letter = "E";
        }
        else
        {
            letter="F";
        }

        int lastDigit=percentage % 10;
        string signForGrade = "";

        if (lastDigit>=7)
        {
            if (letter=="A" || letter=="F")
            {
                signForGrade="";
            }
            else
            {
                signForGrade="+";
            }
        if (lastDigit<=3)
            if (letter=="F")
            {
                signForGrade="";
            }
            else
            {
                signForGrade="-";
            }
        }
        Console.WriteLine($"Your score is {letter}{signForGrade}.");

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