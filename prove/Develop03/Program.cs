using System;
using System.ComponentModel;
using System.Xml.Serialization;

// as a stretched requirement, in the class Scripture in the function HideRandomWords the program hides only the words which were non hidden yet. 
class Program
{
    static void Main(string[] args)
    {        
        List<Scripture> _scriptures = new List<Scripture>();
        Reference r1 = new Reference("Proverbs", 3, 5, 6);
        Scripture s1 = new Scripture(r1,"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy path");
        _scriptures.Add(s1);
        Reference r2 = new Reference("Proverbs", 30, 3,4);
        Scripture s2 = new Scripture(r2,"I flunked 'wisdom.' I see no evidence of a holy God. Has anyone ever seen Anyone climb into Heaven and take charge? grab the winds and control them? gather the rains in his bucket? stake out the ends of the earth? Just tell me his name, tell me the names of his sons. Come on now—tell me!");
        _scriptures.Add(s2);
        Reference r3 = new Reference("Proverbs", 10, 5);
        Scripture s3 = new Scripture(r3,"He that gathereth in summer is a wise son: but he that sleepeth in harvest is a son that causeth shame.");
        _scriptures.Add(s3);
        Reference r4 = new Reference("Proverbs", 10, 3);
        Scripture s4 = new Scripture(r3,"the Lord will not suffer the soul of the righteous to danish: but he casteth away the substance of the wicked.");
        _scriptures.Add(s4);



        Random random = new Random();
            int index = random.Next(_scriptures.Count());
            Scripture scripture = _scriptures[index];

        while (true){
           
            Console.WriteLine (scripture.GetDisplayText());
            Console.WriteLine ();
            Console.Write ("Press enter to continue or type 'quit to finish:");
            string choice = Console.ReadLine();
            if (choice =="quit"|| scripture.IsCompletelyHidden()){
                return;
            
        }
        Console.Clear();
        scripture.HideRandomWords(3);


        
        


        }












        // Console.WriteLine(r1.GetDisplayText());
        // Console.WriteLine(r2.GetDisplayText());
        // r1.GetDisplayText();
      




    }
}


