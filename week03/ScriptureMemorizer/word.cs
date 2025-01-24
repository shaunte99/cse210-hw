class Word
{
    private string text;  
    private bool isHidden; 

    public Word(string text)
    {
        this.text = text;
        this.isHidden = false;
    }

    public void Hide()
    {
        isHidden = true;
    }
   
    public void Show()
    {
        isHidden = false;
    }
    
    public string GetDisplayText()
    {
        if (isHidden)
        {
            
            return new string('_', text.Length);
        }
        else
        {
            return text;
        }
    }
   
    public bool IsHidden
    {
        get { return isHidden; }
    }
}
