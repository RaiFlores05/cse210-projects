public class Scripture
{
    Reference _reference ;
    List<Word> _words;
    
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(" ");

        foreach(string singleWord in words)
        {
            _words.Add(new Word(singleWord));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsHiddenThisTurn = 0;

        while (wordsHiddenThisTurn < numberToHide && !IsCompletelyHidden())
        {
            int randomIndex = random.Next(_words.Count);

            if(!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
                wordsHiddenThisTurn++;

            }
        }
    }

    public string GetDisplayText()
    {
        List<string> wordsText = new List<string>();

        foreach(Word word in _words)
        {
            string currentText = word.GetDisplayText();

            wordsText.Add(currentText);
            
        }

        return $"{_reference.GetDisplayText()} {string.Join(" ", wordsText)}";
        
    }

    public bool IsCompletelyHidden()
    {   
        foreach(Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        
        return true;
    }

    
}