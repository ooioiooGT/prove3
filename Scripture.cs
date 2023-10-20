using System; 

public class Scripture
{   
    private string _gcref ;
    private string _gcscr ; 
    private List<string> _gcScrList; 
    private static Random ran = new Random(); 
    private int _index  ;
    private string _gcLetter;
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
        int index = random.Next(_gcScrList.Count) - 1;
        Console.WriteLine ($"the random {index}");
        _index = index;
        _gcLetter = _gcScrList[_index];
    }
    public void gcHideWord(){
        int gcHide = _gcLetter.Count();
        _gcLetter = "";
        for (int i = 0; i < gcHide ; i++){
            _gcLetter = _gcLetter + "_";
        }

        Console.WriteLine($"how many letter : {gcHide}");
        Console.WriteLine($"the resule : {_gcLetter}");
        
    }
    
}
