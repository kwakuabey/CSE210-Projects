using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");
        foreach (string word in words)
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

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + " ";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}