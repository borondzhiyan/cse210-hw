using System;

public class Lecture : Event {
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateOnly date, TimeOnly time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker=speaker;
        _capacity=capacity;
    }

    public override string GetFullDetails()
    {
        return $"Event: Lecture, Speaker {_speaker}, Capacity {_capacity}\n"+
        base.GetStandardDetails();
    }

    public override string GetShortDescription()
    {
        return $"Event: Lecture, Title : {base.GetTitle()}, Date : {base.GetDate()}";

    }
}