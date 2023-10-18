using System; 

public class Scripture
{   
    private string _gcref ;
    private string _gcscr ; 
    private List<string> _gcScrList; 
    private static Random ran = new Random(); 
    private int _index  ;
    public void gcReference(){
        Console.WriteLine("what are the reference");
        _gcref = Console.ReadLine();
        
        
    }
    public void gcScripture(){
        Console.WriteLine("what is the scripture? ");
        _gcscr = Console.ReadLine();
        List <string>  gcScrList = _gcscr.Split(" ").ToList();
        _gcScrList = gcScrList;

    }
    public void gcTostring(){
        
        Console.WriteLine ($"this is your reference {_gcref}");
        Console.WriteLine ($"this is scripture: {_gcScrList[_index]}");

    }
    public void gcRandom(){
        Random random = new Random();
        int index = random.Next(_gcScrList.Count);
        Console.WriteLine ($"the random {index}");
        _index = index;
        
    }
    
}