using Newtonsoft.Json;
public class FileHandlin
{
    static public void ReadFromJSON()
    {
        if (!File.Exists("songs.json")) {
        File.Create("songs.json");
        }

        string json = File.ReadAllText("songs.json");
        Song.allsongs = JsonConvert.DeserializeObject<List<Song>>(json);
        
        try{
            System.Console.WriteLine(Song.allsongs.Count);
        }catch{
            Song.allsongs = new List<Song>{};
        }
    }
    static public void WriteOutJSON()
    {
            File.WriteAllText("songs.json", JsonConvert.SerializeObject(Song.allsongs));
    }
}
