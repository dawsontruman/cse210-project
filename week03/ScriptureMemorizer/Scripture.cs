using System;
using System.Formats.Asn1;

/*
Something troubled me when designing this project.
Scriptures should be stored verse by verse, one verse to
one block of text. Can I feed a reference into 
this class if that reference has a range of verses? How do
I split up the text verse-by-verse?

I think I need a new class, not a reference class that
"accomodates scriptures with multiple verses"
*/
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private bool _completelyHidden;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _completelyHidden = false;
        //convert input text to list of words (_words)
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        int i = 0;
        while (i < numberToHide)
        {
            // has to run a CompletelyHidden check or it can get stuck
            _completelyHidden = true;
            foreach (Word word in _words)
            {
                if (word.IsHidden())
                {
                    continue;
                }
                else
                {
                    _completelyHidden = false;
                }
            }
            if (_completelyHidden)
            {
                break;
            }
            else
            {
            /* 
            Get a random word from _words.
            If it is already hidden find a new random word,
            otherwise hide the word and increment the counter.
            */
                int randomIndex = random.Next(0, _words.Count() - 1);
                if (_words[randomIndex].IsHidden())
                {
                    continue;
                }
                else
                {

                    _words[randomIndex].Hide();
                    i += 1;
                }
            }
        }
    }
    public string GetDisplayText()
    {
        string textString = "";
        foreach (Word word in _words)
        {
            textString += $"{word.GetDisplayText()} ";
        }
        return $"{_reference.GetDisplayText()}\n{textString}";
    }
    public bool IsCompletelyHidden()
    {
        _completelyHidden = true;
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                continue;
            }
            else
            {
                _completelyHidden = false;
            }
        }
        return _completelyHidden;
    }
}