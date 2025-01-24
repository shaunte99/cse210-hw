class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(reference.GetFormattedReference());
        Console.WriteLine(string.Join(" ", words.Select(word => word.GetDisplayText())));
    }

    public bool AreAllWordsHidden()
    {
        return words.All(word => word.IsHidden);
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        List<Word> visibleWords = words.Where(word => !word.IsHidden).ToList();
        int wordsToHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < wordsToHide; i++)
        {
            Word word = visibleWords[random.Next(visibleWords.Count)];
            word.Hide();
            visibleWords.Remove(word);
        }
    }
}
