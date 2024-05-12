using System;
using System.Security.Cryptography.X509Certificates;

public class Scripture{
    private Reference _reference;
    private List<Word> _words;

// этот конструктор разделяет входящую строку на слова представляя какждое слово как тип класса Word
    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(" ");
        foreach (string word in words){
            Word w = new Word(word);
            _words.Add(w);
        }
    }
    // hides only the words that  has not been hidden yet
    public void HideRandomWords(int numberToHide){
        // создаем  лист с индексами, которые еще не были скрыты
        List<int> indexes = new List<int>();
        for (int i=0; i<_words.Count; i++){          
            if (!_words[i].isHidden()){
                indexes.Add(i);
            }
        }
        // i=0 - начальное значение нашей искусственной преременной. i<number - выполняем цикл нет - вылетаем из цикла. i++ - прибавляем на единицу после каждой итерации
        for (int i=0; i<numberToHide; i++){
            //  int index = (new Random()).Next(_words.Count());
            Random random = new Random();
            int index = random.Next(indexes.Count);
            _words[indexes[index]].Hide(); //по индексу сделает слова hide 

        }
    }
    // возвращает строковое полное  представление scripture, состоящее из назвния стиха и номера и самого текста
    public string GetDisplayText(){
        string text = _reference.GetDisplayText();
        foreach (Word word in _words){
            text+= " "+word.GetDisplayText();
        }
        return text; 
    }
    // проверяет все ли слова скрыты
    public bool IsCompletelyHidden(){
        foreach (Word word in _words){
            if (!word.isHidden()){
                return false;
            }
        }
        return true;
    }
}
