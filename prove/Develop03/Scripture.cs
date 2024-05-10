using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture{
    private Reference _reference;
    private List<Word> _words;

// 
    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(" ");
        foreach (string word in words){
            Word w = new Word(word);
            _words.Add(w);
        }
    }
    public void HideRandomWords(int numberToHide){

    }
    public string GetDisplayText(){
       return null; 
    }
    public bool IsCompletelyHidden(){
        return false;
    }
}
