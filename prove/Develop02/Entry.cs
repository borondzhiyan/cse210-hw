using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

public Entry(string date, string prompt, string text){
	_date=date;
	_promptText=prompt;
	_entryText=text;
}


    public void Display()
    //не имеет параметров, не принимает  аргументы, не возвращает значения
    {
        Console.WriteLine($"Date: {_date}, - Prompt {_promptText}");
        Console.WriteLine ($"{_entryText}");
        Console.WriteLine ();
    }
}