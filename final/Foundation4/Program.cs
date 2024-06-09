using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
    ActivityManager manager = new ActivityManager();
    Activity running = new Running(new DateOnly(2024, 6, 14), 30, 3.0f);
    Activity running1 = new Running(new DateOnly(2024, 5, 14), 35, 4.0f);
    Activity cycling = new Cycling(new DateOnly(2024, 4, 14), 30,30);
    Activity cycling1 = new Cycling(new DateOnly(2024, 4, 15), 40,25);
    Activity swimming = new Swimming(new DateOnly(2024, 4, 16),45,30);

    manager.AddActivity(running);
    manager.AddActivity(running1);
    manager.AddActivity(cycling);
    manager.AddActivity(cycling1);
    manager.AddActivity(swimming);

    manager.DisplaySummary();
    }

}

