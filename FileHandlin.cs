using Newtonsoft.Json;
public class FileHandlin
{
    static public void ReadFromJSON()
    {
        try{
            string json = File.ReadAllText("songs.json");
            if (json == "")
            {
                json = null;
            }
            Song.allsongs = JsonConvert.DeserializeObject<List<Song>>(json);
        }catch(Exception e){
            System.Console.WriteLine("No songs found. Please create new song to continue.");
            Song.AddNew();
        }
        
    }
    static public void WriteOutJSON()
    {
            File.WriteAllText("songs.json", JsonConvert.SerializeObject(Song.allsongs));
    }
}
