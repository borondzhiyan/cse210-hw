using System;


public abstract class Activity{

    private DateOnly _date;
    private int _length;
   
    public Activity ( DateOnly date, int length){
        _date=date;
        _length=length;
    }
    public abstract float GetDistance(); // в каждом наследнике он должен быть реализован
    public abstract float GetSpeed(); // они должны быть реализованы во всех наследниках
    public abstract float GetPace();

    protected abstract string GetTypeActivity();
    public string GetSummary(){
        return $"{_date} {GetTypeActivity()} ({_length} min) - Distance {Math.Round(GetDistance(),2)} km, Speed {Math.Round(GetSpeed(),2)} kph, Pace : {Math.Round(GetPace(),2)} min per km";
    }
    protected float GetLength(){//инкапсуляция. виден только для наследнков и этого класса
        return _length;
    }
}