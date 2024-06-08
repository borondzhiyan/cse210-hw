using System;

public class EventManager{
    private List<Event> _events= new List<Event>();


    public void AddEvent(Event eve){
        _events.Add(eve);
    }
    public void DisplayStandardtDetails(){
        Console.WriteLine("Standard details of the events");
        foreach (Event eve in _events){
            Console.WriteLine(eve.GetStandardDetails());
            Console.WriteLine();
        }
    }
    public void DisplayFullDetails(){
        Console.WriteLine("Full details of the events");
        foreach (Event eve in _events){
            Console.WriteLine(eve.GetFullDetails());
            Console.WriteLine();
        }
    }
        public void DisplayShortDetails(){
        Console.WriteLine("Short description of the events");
        foreach (Event eve in _events){
            Console.WriteLine(eve.GetShortDescription());
            Console.WriteLine();
        }
    }
}