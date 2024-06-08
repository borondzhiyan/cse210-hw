using System;

public class Reception : Event {
    private string _email;

    public Reception(string title, string description, DateOnly date, TimeOnly time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string GetFullDetails()
    {
         return $"Event: Reception, Reristration email {_email}\n"+
        base.GetStandardDetails();
    }

    public override string GetShortDescription()
    {
        return $"Event: Reception, Title : {base.GetTitle()}, Date : {base.GetDate()}";

    }
}