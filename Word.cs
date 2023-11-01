using System;

public class Word{
    private string gc_word;
    public Word(string word){
        gc_word = word;
    }
    public void hide_word(){
        int letternum = gc_word.Count();
        gc_word = "";
        for (int i=0; i < letternum; i++){
            gc_word=gc_word + "_";
        }
    }
    public void show_word(){
        Console.WriteLine(gc_word + " ");
    }
}