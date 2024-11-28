namespace Movies4UFree.Models
{
    public class Movie
    {
        public int Id { set; get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}