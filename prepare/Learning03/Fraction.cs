using System;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

// почему класс публичный а переменные частные?
public class Fraction {
    private int _top;
    private int _bottom;
// если не делать конструктор - перевменные будут иметь нулевые значения.
// в нашем случае, верхние переменные будут переопределены
    public Fraction (){
        _bottom = 1;
        _top = 1;
    }
    public Fraction (int WholeNumber){
        _top=WholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom){
        _top=top;
        _bottom=bottom;
    }

    public string GetFractionString(){
        string text=$"{_top}/{_bottom}";
        return text;
    }

    public double GetFractionValue(){
        double value = _top/_bottom;
        return value;
    }
    



}
    