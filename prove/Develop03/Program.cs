using System;
using System.Collections.Generic;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string _text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;

    }

    public string GetDisplayText()
    {
        if (_isHidden)
            return "_";
        else 
            return _text;

    }

}    
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference,string text)
    {
        _reference = reference;
        _words = new List<Word>();

    }


    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {

    }
  
    public void IsCompletelyHidden()
    {

    }
    public void Display()
    {


    }

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string _book, int _chapter, int _verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference( string _book, int chapter, int _startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;

    }

    public string GetDisplayText()
    {
        
    }
 

public class Program
{
    public static void Main(string[] args)
    {

    }
}
        