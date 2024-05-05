using System;
using System.IO;

public class Journal{
public List<Entry> _entries;
    
    public Journal(){
        _entries=new List<Entry>{};
        }
public void AddEntry(Entry newEntry){
    _entries.Add(newEntry);
}

public void DisplayAll(){
    foreach (Entry entry in _entries){
        entry.Display();
    }
}

public void SaveToFile(string fileName){
        // string path = @"C:\Users\SUPERSONIC\Desktop\Python\cse210-hw\prove\Develop02";
        // Directory.CreateDirectory(path);
        // string filePath = Path.Combine(fileName);
        using (StreamWriter outputFile = new StreamWriter(fileName)){
        foreach(Entry entry in _entries){
        outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText}");
        }
    }
}

public void LoadFromFile(string fileName){
    _entries=new List<Entry>();
    string[] lines = System.IO.File.ReadAllLines(fileName);
    foreach(string line in lines){
        string [] parts = line.Split(",");
        Entry entry = new Entry();
        entry._date=parts[0];
        entry._promptText=parts[1];
        entry._entryText=parts[2];
        _entries.Add(entry);

    }

}
}
