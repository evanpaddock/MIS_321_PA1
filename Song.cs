public class Song //Title, Artist, Date Added, Favorited) 
{
    public int SongID{get; set;}
    public string Title{get; set;}
    public string Artist{get; set;}
    public DateOnly Date_Added{get; set;}
    public bool Favorited{get; set;}
    public bool Deleted{get; set;}
    static public List<Song?> allsongs;

    static public void AddNew()
    {
        Song newSong = new Song();
        newSong.Date_Added = DateOnly.FromDateTime(DateTime.Now);
        newSong.Deleted = false;
        newSong.Deleted= false;
        newSong.SongID = (allsongs.Count + 1);

        Console.Clear();
        System.Console.WriteLine("What is the name of the song?");
        newSong.Title = Console.ReadLine();

        Console.Clear();
        System.Console.WriteLine($"Who is the artist for the {newSong.Title}?");
        newSong.Artist = Console.ReadLine();

        allsongs.Add(newSong);
        FileHandlin.WriteOutJSON();

        Console.Clear();
        System.Console.WriteLine($"{newSong.Title} has successfully been added to your songs!");
        Console.ReadKey();
        
    }
    static public void WriteAllSongs()
    {
        Console.Clear();
        int line = 0;
        Console.SetCursorPosition(0, line);
        System.Console.WriteLine("Title");
        Console.SetCursorPosition(30, line);
        System.Console.WriteLine("Artist");
        Console.SetCursorPosition(60, line);
        System.Console.WriteLine("Date Added");
        Console.SetCursorPosition(90, line);
        System.Console.WriteLine("Favorited");

        foreach (Song song in allsongs)
        {
            if(song.Deleted == false)
            {
                line++;
                Console.SetCursorPosition(0, line);
                System.Console.WriteLine(song.Title);
                Console.SetCursorPosition(30, line);
                System.Console.WriteLine(song.Artist);
                Console.SetCursorPosition(60, line);
                System.Console.WriteLine(song.Date_Added);
                Console.SetCursorPosition(90, line);
                if(song.Favorited == true)
                {
                    System.Console.WriteLine("Yes");
                }else
                {
                    System.Console.WriteLine("No");
                }
            }
        }

        Console.SetCursorPosition(0,line + 2);
        System.Console.WriteLine("Please press enter to continue...");
        Console.ReadKey();
    }
    static public void Favorite()
    {
        WriteAllSongs();
        System.Console.WriteLine("What song would you like to favorite?");
        string searchVal = Console.ReadLine();

        Song returnedSong = allsongs.Find(x => x.Title.ToLower() == searchVal.ToLower());

        if(returnedSong != null)
        {
            if (returnedSong.Favorited == false)
            {
                returnedSong.Favorited = true;
            }
            else if(returnedSong.Favorited == true)
            {
                returnedSong.Favorited = false;
            } 
        }else{
            System.Console.WriteLine($"Song {searchVal} could not be found. Reverting back to the main menu.");
        }
    }
    static public void Delete()
    {
        WriteAllSongs();
        System.Console.WriteLine("\n");
        System.Console.WriteLine("Which song would you like to delete?");

        string titleDelete = Console.ReadLine();

        Song returnedSong = allsongs.Find(x => x.Title.ToLower() == titleDelete.ToLower());

        if(returnedSong != null)
        {
            if (returnedSong.Deleted == false)
            {
                returnedSong.Deleted= true;
            }
            else if(returnedSong.Deleted== true)
            {
                returnedSong.Deleted= false;
            } 
        }else{
            System.Console.WriteLine($"Song {titleDelete} could not be found. Reverting back to the main menu.");
        }

    }
    
    public override string ToString()
    {
        return($"{Title}\t{Artist}\t{Date_Added}\t{Favorited}");
    }
}