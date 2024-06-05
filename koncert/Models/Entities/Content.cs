namespace koncert.Models.Entities
{
    public class Content
    {
        public int ContentId { get; set; }
        public ICollection<Chapter> chapters { get; set; } = new List<Chapter>();   //kolekcja
        public int ConcertId { get; set; } //nawigacja

    }
}