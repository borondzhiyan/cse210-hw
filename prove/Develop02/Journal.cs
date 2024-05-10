using System;
using System.IO;

public class Journal{
public List<Entry> _entries;
    
    public Journal(){
        _entries=new List<Entry>{};
        }
public void AddEntry(Entry newEntry){
    // ничего не возвращает
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
            // автоматическое закрытие файла
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
        // Entry entry = new Entry();
        Entry entry=new Entry(parts[0], parts[1], parts[2]);
        // entry._date=parts[0];
        // entry._promptText=parts[1];
        // entry._entryText=parts[2];
        _entries.Add(entry);

    }
// 2023, day, text1
// 2024, week, text2



// string[] lines=File.getLines(filename);
// ["2023, day, text1", "2024, week, text2"]

// foreach(string s in lines){
//  string[] p=
}
}
