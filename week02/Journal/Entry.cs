using system ;

public class Entry

{  public string song {get;set;}
   public string Artist {get;set;}
   public string Genre {get;set;}
   public string Date  {get;set;}

   public Entry (string song , string artist,string genre,string date) 
   { 
    song = song;
    Artist = artist;
    Genre = genre;
    Date = DateTime.Now.ToString("YYYY-MM-DD HH:MM:SS");
    
   } 
   public override string ToString()
   {
     return $"Date: {Date}\nsong: {Song}\nArtist: {Artist}\nGenre: {Genre}\nDate: {Date}";
   
   }  
   
}