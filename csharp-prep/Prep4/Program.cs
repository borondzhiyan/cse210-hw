using System;
using System.Globalization;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> list= new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int numberint=-1;
        while (numberint!=0)
        {
            Console.Write("Enter number: ");
            string userNumber=Console.ReadLine ();
            numberint = int.Parse(userNumber);
            if (numberint!=0)
            {
                list.Add(numberint);
            }
        }
        if (list.Count>0)
        {
            int sum = 0;
            foreach (int i in list)
            {   
                sum +=i;  
            }
            Console.WriteLine($"The total sum is {sum}.");

            int count = (list.Count);
            float average=sum/count;
            Console.WriteLine($"The average is: {average}");

            int largest=list[0];

            foreach (int i in list)
            if (i>largest)
            {
                largest=i;
            }
            Console.WriteLine($"The largest number is: {largest}");
        }
        else
            Console.WriteLine($"The list is empty");

    }
        
}