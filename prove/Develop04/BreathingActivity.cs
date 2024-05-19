using System;
using System.Security.Cryptography;


public class BreathingActivity : Activity{
public BreathingActivity() : base ("Breathing activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."){

}

public void Run(){
    base.InitDuration();
    Console.Clear();
    Console.WriteLine("Get Ready");
    base.ShowSpinner(7);
    DateTime startTime = DateTime.Now;
    DateTime endTime = startTime.AddSeconds(GetDuration());
while (DateTime.Now<endTime){
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Breathing in... ");
    base.ShowCountDown(4);
    Console.WriteLine();
    Console.Write("Now Breath out... ");
    base.ShowCountDown(6);   
    Console.WriteLine();
}

}

}