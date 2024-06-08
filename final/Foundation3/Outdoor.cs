using System;

public class Outdoor : Event{
    private string _forecast;

    public Outdoor(string title, string description, DateOnly date, TimeOnly time, Address address, string forecast) : base(title, description, date, time, address)
    {
        _forecast=forecast;
    }

    public override string GetFullDetails()
    {
          return $"Event: Outdoor gathering, Weather: {_forecast}\n"+
        base.GetStandardDetails();
    }

    public override string GetShortDescription()
    {
        return $"Event: Outdoor gathering, Title : {base.GetTitle()}, Date : {base.GetDate()}";
    }
}