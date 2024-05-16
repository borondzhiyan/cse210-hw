using System;
using System.Reflection.Metadata.Ecma335;

public class Assignment{
    protected string _studentName;
    protected string _topic;

    public Assignment(string name, string title){
        _topic = title;
        _studentName=name;

    }

    public string GetSummary(){
        return _studentName + " - "+ _topic;
    }
    
    public string GetStudentName(){
        return _studentName;
    }
    public string GetTopic(){
        return _topic;
    }
}   
