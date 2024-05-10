using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Word{

    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
    } 
    public void Hide(){

    }
    public void Show(){

    }

    public bool isHidden(){
        return false;
    }
    public string GetDisplayText(){
        return null;

    }

}