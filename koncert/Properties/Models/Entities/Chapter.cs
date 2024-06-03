namespace koncert.Properties.Models.Entities
{
    public class Chapter
    {
        public int ChapterId { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Place> Places { get; set; } = new List<Place>();
        public int ConcertId { get; set; }

    }
}