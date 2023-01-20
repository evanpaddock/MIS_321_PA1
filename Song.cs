namespace MIS_321_PA1
{
    public class Song //Title, Artist, Date Added, Favorited) 
    {
        public string title{get; set;}
        public string artist{get; set;}
        public DateOnly date_added{get; set;}
        public int num_favs{get; set;}
        public List<Song> allsongs{get; set;}
    }
}