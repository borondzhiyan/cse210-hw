using System;

public abstract class Event{
    private string _title;
    private string _description;
    private DateOnly _date;
    private TimeOnly _time;
    private Address _address;
     
    public Event (string title, string description, DateOnly date, TimeOnly time, Address address){
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }
    public string GetStandardDetails(){
        return $"Title: {_title}\n"+
        $"Description: {_description}\n"+
        $"Date: {_date} Time: {_time}\n"+
        $"Address: {_address.GetAddress()}\n";
    }
    
    public abstract string GetFullDetails();
    public abstract string GetShortDescription();

    public string GetTitle(){
        return _title;
    }
    public DateOnly GetDate(){
        return _date;
    }
}
