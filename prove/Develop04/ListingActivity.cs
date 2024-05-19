using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class ListingActivity: Activity{
    
    int _count;
    private List<string> _prompts;
    

    public ListingActivity() : base ("Listing activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
        _prompts = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
  
    }

    public void Run(){
        base.InitDuration();
        Console.Clear();
        Console.WriteLine("Get Ready");
        base.ShowSpinner(7);

        Console.WriteLine("List as many responses as you canto the following propmt:");
        string pr=GetRandomPrompt();
        Console.WriteLine($"--- {pr}---");
        Console.Write($"You may begin in ");
        Console.WriteLine();
        base.ShowCountDown(6);
        List<string> answers = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now<endTime){
            Console.Write("> ");
            string answ = Console.ReadLine();
            answers.Add(answ);
            _count = (answers.Count);
            
        }     
        Console.WriteLine($"You listed {_count} items");
    }
    public string GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
