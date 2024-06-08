using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        EventManager manager = new EventManager();
        Address address1=new Address("Lenin","New York","Russia");
        Event lecture = new Lecture("Math", "New methods in math", new DateOnly(2024,3,14), new TimeOnly(10,30), address1,"Ivanov",30);
        Address address2=new Address("Busch","Aspen","Bangladesh");
        Event reception = new Reception("President VIP", "Free drinks and food", new DateOnly(2024,3,14), new TimeOnly(20,00),address2,"aaa@email.com");
        Address address3=new Address("Garbage","Orlando","India");
        Event outdoor = new Outdoor("Concert", "Famous piano player Visent T.", new DateOnly(2024,5,12), new TimeOnly(19,00),address3,"+25C,Overcast");
    
    manager.AddEvent(lecture);
    manager.AddEvent(reception);
    manager.AddEvent(outdoor);

    manager.DisplayShortDetails();
    Console.WriteLine();
    manager.DisplayStandardtDetails();
    Console.WriteLine();
    manager.DisplayFullDetails();
    }

}