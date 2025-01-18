using System;

public class Entry
{
    public string Song { get; set; }
    public string Artist { get; set; }
    public string Genre { get; set; }
    public string Date { get; set; }

    public Entry(string song, string artist, string genre, string date)
    {
        Song = song;
        Artist = artist;
        Genre = genre;
        Date = date;
    }

    public override string ToString()
    {
        return $"Song: {Song}\nArtist: {Artist}\nGenre: {Genre}\nDate: {Date}";
    }
}
