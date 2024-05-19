using System;
using System.Security.Cryptography.X509Certificates;

public class ReflectingActivity : Activity{
    private List<string> _prompts;
    private List<string> _questions;
    
    public ReflectingActivity() : base ("Reflection activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){
        _prompts = new List<string>{
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really difficult",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
    
        _questions = new List<string>{
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run(){
        base.InitDuration();
        Console.Clear();
        Console.WriteLine("Get Ready");
        base.ShowSpinner(7);
        Console.WriteLine();
        string random = GetRandomPrompt();
        Console.WriteLine();
        Console.WriteLine($"--- {random} ---");
        Console.WriteLine();
        Console.WriteLine($"When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following questions as they related to this experience.");
        Console.Write($"You may begin in ");
        base.ShowCountDown(6);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        Console.Clear();
        while (DateTime.Now<endTime){
            string question = GetRandomQuestion();
            Console.Write($"> {question}");
            base.ShowSpinner(7);
            Console.WriteLine();
        }
    }

    public string GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetRandomQuestion(){
        Random random= new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }
}