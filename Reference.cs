using System;

public class Reference{
    private string gc_refernce;
    private string gc_verse;
    List<string> s_list = new List<string>(){
        " 1 Nephi 1: 2 - Yea, I make a record in the alanguage of my father, which consists of the "
    };

    public Reference(){
        Console.WriteLine("Please enter 0 - 1 in order to get your scripture:");
        int userinput = int.Parse(Console.ReadLine());
        string[] parts = s_list[userinput].Split("-");
        gc_refernce = parts [0];
        gc_verse = parts[1];

    }
    public string getReference(){
        return gc_refernce;
    }
    public string getVerse(){
        return gc_verse;
    }
}