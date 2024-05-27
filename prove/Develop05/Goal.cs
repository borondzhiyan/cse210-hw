using System;
using System.ComponentModel;
using System.Reflection;

public abstract class Goal{
    private string _shortname;
    private string _description;
    private  int _points;

    public Goal(string name, string description, int points){
        _shortname= name;
        _description=description;
        _points=points;
    } 
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailString(){
        return $"{_shortname} ({_description})";
    }
    public abstract string GetStringRepresentation();

    public int GetPoints(){
        return _points;
    }
    public string GetShortname(){
        return _shortname;
    }
    public string GetDescription(){
        return _description;
    }
    
}
