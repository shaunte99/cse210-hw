class Reference
{
    private string book;
    private int chapter;
    private string verses;

    // Constructor to set up the book, chapter, and verses
    public Reference(string book, int chapter, string verses)
    {
        this.book = book;
        this.chapter = chapter;
        this.verses = verses;
    }

    
    public string GetFormattedReference()
    {
        return $"{book} {chapter}:{verses}";
    }
}
