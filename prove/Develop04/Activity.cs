using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

public class Activity{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description){
        _name = name;
        _description = description;
        
    }
    public void InitDuration(){
        Console.Write("How long, in seconds, would you like for your session?");
        _duration = Convert.ToInt32(Console.ReadLine());
    }
    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }
    public void DisplayEndingMessage(){
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds){ 
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        // animationStrings.Add("|");
        // animationStrings.Add("-");
        // animationStrings.Add("\\");
        // изначальное значение i  и повторяй этот цикл до того как он будет seconds)
        for (int i=0; i<seconds; i++){
            int j = i%animationStrings.Count;
            Console.Write (animationStrings[j]);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
        }
    }
    public void ShowCountDown(int count){
        for (int i=count; i>0; i--){
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
    public int GetDuration(){
        return _duration;
    }
}