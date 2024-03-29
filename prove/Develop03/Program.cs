using System;
using System.Collections.Generic;

public class Word
{
    private string _text;
    private bool _isHidden;
    //private string _text;

    public Word(string text)
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
            return new string('_', _text.Length);
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

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }

    }


    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }

    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";
        foreach(Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }
  
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
    public void Display()
    {   
        Console.WriteLine(GetDisplayText());
    }
}
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _start;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

    }

    public Reference( string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _start = startVerse;
        _endVerse = endVerse;

    }

    public string GetDisplayText()
    {
        if (_endVerse == 0)
        {
            return $"{_book} {_chapter}: {_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_start}-{_endVerse}";
        }
         
        
    }
 
}
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to see the scripture.");
        Reference reference = new Reference("John", 3, 16, 17);
        string scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. For God sent not his Son into the world to condemn the world; but that the world through him might be saved.";
        Scripture scripture = new Scripture(reference, scriptureText);

        Random random = new Random();
        while (!scripture.IsCompletelyHidden())
        {
            Console.ReadLine();
            Console.Clear();
            scripture.Display();
            Console.WriteLine("Press  enter to hide a random word.");
            
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(1);
        }
        Console.WriteLine("You have successfully memorized the scripture.");
    }
}
        