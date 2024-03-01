using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _word;
    private Boolean _hidden = false;

    public void AssignWord(string word)
    {
        _word = word;
    }

    public string FetchWord() ///returns string of underscores if word is hidden
    {
        if (_hidden == false)
        {
            return _word + " ";
        }
        else
        { 
            string underscores = new string('_', _word.Length);
            string underscoresWithSpace = underscores + " ";
            
            return underscoresWithSpace;
        }
    }
    public void HideWord()
    {
        _hidden = true;
    }

}