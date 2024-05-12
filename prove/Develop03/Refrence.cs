using System;
// ссылка на священное писание 
public class Reference{
    string _book;
    int _chapter;
    int _verse;
    int _endVerse;


    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse){
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse= endVerse;
    }
    public string GetDisplayText(){
        string endverse= ""; // если сделать endverse = null, то при выводе на экран будет "null", а в данном случае будет ""
        if (_endVerse > 0){ // 0 - будет в конце ничего
            endverse = "-"+_endVerse;// прибавится в конце 
        }
        return ($"{_book} {_chapter}:{_verse}{endverse}");
    }
    
}