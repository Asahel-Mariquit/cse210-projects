public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string word in text.Split(" "))
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        int totalWords = _words.Count;
        int hiddenCount = 0;

        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                hiddenCount++;
            }
        }
        int canbeHidden = totalWords - hiddenCount;
        if (numberToHide > canbeHidden)
        {
            numberToHide = canbeHidden;
        }
        List<Word> wordsNotHidden = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                wordsNotHidden.Add(word);
            }
        }
        Random randomGenerator = new Random();
        for (int i = 0; i < numberToHide && wordsNotHidden.Count > 0; i++)
        {
            int index = randomGenerator.Next(wordsNotHidden.Count);
            Word currentWord = wordsNotHidden[index];
            currentWord.Hide();
            wordsNotHidden.RemoveAt(index);
        }
    }  

    public string GetDisplayText()
    {
        string words = "";
        for (int i = 0; i < _words.Count; i++)
        {
            words += _words[i].GetDisplayText();
            if (i < _words.Count - 1)
            {
                words += " ";
            }
        }
        return $"{_reference.GetDisplayText()} {words}";
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