using System;

public class Scripture 
{
    private string _reference;
    private List<Word> _words = new List<Word>();
    
    public Scripture(string reference, string scripture)
    {
        _reference = reference;
        string[] scriptureWords = scripture.Split();

        foreach (string _word in scriptureWords)
        {
            Word w = new Word(_word);
            _words.Add(w);
            // Console.Write(_word + " ");
        }



    }

    public void DisplayScripture()
    {
        foreach (Word _word in _words)
        {
            _word.DisplayWord();
        }
    }

    public void HideWords()
    {
        Random rnd = new Random();
        var shuffledList = _words.OrderBy(a => rnd.Next()).ToList();
        // var res = shuffledList.Take(3);
        int counter = 0;

        foreach (Word _word in shuffledList)
        {
            if (counter == 3)
            {
                break;
            }
            else if (_word.IsHidden() == true)
            {
                continue;
            }
            else
            {
                _word.Hide();
                counter++;
            }
        }
    }

    public void ShowWords()
    {
        Random rnd = new Random();
        var shuffledList = _words.OrderBy(a => rnd.Next()).ToList();
        // var res = shuffledList.Take(3);
        int counter = 0;

        foreach (Word _word in shuffledList)
        {
            if (counter == 3)
            {
                break;
            }
            else if (_word.IsHidden() == false)
            {
                continue;
            }
            else
            {
                _word.Show();
                counter++;
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        bool option = false;
        foreach (Word _word in _words)
        {
            if (_word.IsHidden() == false)
            {
                option = false;
                break;
            }
            else
            {
                option = true;
            }
        }
        return option;
    }

}