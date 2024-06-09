using System;

public class ActivityManager{
    private List<Activity> _activities = new List<Activity>();


    public void AddActivity(Activity activity){
        _activities.Add(activity);
    }

    public void DisplaySummary(){
        foreach(Activity activity in _activities){
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}