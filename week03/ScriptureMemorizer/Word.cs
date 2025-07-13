using System;

public class Word
{
    private string _text;
    private bool _isHidden;
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
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetDisplayText() // returns text or hidden version based on private bool _isHidden
    {
        if (_isHidden)
        {
            string _hiddenText = "";
            string[] splitText = _text.Split();
            for (int i = 0; i < splitText.Length; i++)
            {
                _hiddenText += "_";
            }
            return _hiddenText;
        }
        else
        {
            return _text;
        }
    }
}