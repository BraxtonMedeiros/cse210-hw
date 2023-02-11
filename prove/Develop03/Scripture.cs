class Scripture
{
    private Reference reference;
    private List<List<Word>> verses;

    public Scripture(Reference reference, string scriptureText)
    {
        this.reference = reference;
        verses = new List<List<Word>>();
        string[] verseStrings = scriptureText.Split('.');

        foreach (string verseString in verseStrings)
        {
            string[] words = verseString.Split(' ');
            List<Word> verse = new List<Word>();

            foreach (string word in words)
            {
                verse.Add(new Word(word, true));
            }

            verses.Add(verse);
        }
    }

    public Reference Reference
    {
        get { return reference; }
        set { reference = value; }
    }

    public List<List<Word>> Verses
    {
        get { return verses; }
        set { verses = value; }
    }

    public void HideRandomWords()
    {
        Random rnd = new Random();
        int verseIndex = rnd.Next(verses.Count);
        int wordIndex = rnd.Next(verses[verseIndex].Count);
        verses[verseIndex][wordIndex].IsShown = false;
    }

    public string GetRenderedText()
    {
        string displayString = reference.ToString() + "\n";
        for (int i = 0; i < verses.Count; i++)
        {
            for (int j = 0; j < verses[i].Count; j++)
            {
                displayString += verses[i][j].IsShown ? verses[i][j].Text + " " : "__ ";
            }
            displayString += "\n";
        }
        return displayString;
    }

    public bool IsFullyHidden()
    {
        foreach (List<Word> verse in verses)
        {
            foreach (Word word in verse)
            {
                if (word.IsShown)
                {
                    return false;
                }
            }
        }
        return true;
    }
}