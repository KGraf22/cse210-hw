using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        public class Scripture
        {
            private Reference _reference;
            private List<Word> _words;

            public ScriptureReference(string Reference,string text)
            {

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
        }

        public class Reference
        {
            private string _book;
            private int _chapter;
            private int _verse;
            private int _endVerse;

            public Reference(string _book,int _chapter, int _verse)
            {

            }

            public Reference( string _book, int chapter, int _startVerse, int endVerse)
            {

            }

            public string GetDisplayText()
            {
        
            }
        }


        public class Word
        {
            private string _text;
            private bool _isHidden;

            public Word(string _text)
            {

            }

            public void Hide()
            {

            }

            public void Show()
            {

            }

            public bool IsHidden()
            {

            }

            public string GetDisplayText()
            {

            }

        }




    }
}