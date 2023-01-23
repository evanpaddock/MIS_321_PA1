public class Song //Title, Artist, Date Added, Favorited) 
{
    public int SongID{get; set;}
    public string Title{get; set;}
    public string Artist{get; set;}
    public DateOnly Date_Added{get; set;}
    public bool Favorited{get; set;}
    public bool Deleted{get; set;}
    static public List<Song> allsongs;

    static public void AddNew()
    {

    }
    static public void WriteAllSongs()
    {
        foreach (Song song in allsongs)
        {
            System.Console.WriteLine(song.ToString());
        }
        Console.ReadKey();
    }
    public override string ToString()
    {
        return($"{Title}\t{Artist}\t{Date_Added}\t{Favorited}");
    }
}