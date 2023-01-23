using Newtonsoft.Json;


public class FileHandlin
{
    static public void ReadFromJSON()
    {
        string json = File.ReadAllText("songs.json");
        Song.allsongs = JsonConvert.DeserializeObject<List<Song>>(json);
    }
    static public void WriteOutJSON()
    {
            File.WriteAllText("songs.json", JsonConvert.SerializeObject(Song.allsongs));
    }
}
