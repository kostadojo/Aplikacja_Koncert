namespace koncert.Properties.Models.Entities
{
    public class Place
    {
        public int PlaceId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Duration { get; set; } = string.Empty;
        public int ChapterId { get; set; }

    }
}