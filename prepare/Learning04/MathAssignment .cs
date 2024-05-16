using System.Reflection.PortableExecutable;
using System.Security.Cryptography;

public class MathAssignment : Assignment{
    string _textbookSection;
    string _problems;
    public MathAssignment(string name, string topic, string problems, string section) : base (name, topic){

        _problems = problems;
        _textbookSection = section;
    }
       
    public string GetHomeworkList(){

        return ($"Section {_textbookSection} Problems {_problems}");
    }
         
}