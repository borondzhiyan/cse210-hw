using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Word{

    private string _text;
    private bool _isHidden;

    public Word(string text){
        //сам текст слова
        _text = text;

        //признак скрытия слова
        _isHidden = false;
    } 

    //помечат признак, что слово должно быть скрыто
    public void Hide(){
        _isHidden= true;
    }

    //помечат признак, что слово должно быть показано
    public void Show(){
        _isHidden=false;
    }

    //вощвращает значение переменной _isHidden 
    public bool isHidden(){
        return _isHidden;
    }
    
    // вощвращает строковое представление слова в зависимости от вощвращаемого значения функции isHidden()
    public string GetDisplayText(){
        if (isHidden()){// проевряет зачение которое возвращает isHidden (true/false). If true - выполняется то что дальше в If, если false эта if пропускается. 
        return "____";
        }
        else {return _text;}

    }

}