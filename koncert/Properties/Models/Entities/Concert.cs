namespace koncert.Properties.Models.Entities
{
    public class Concert
    {
        public int ConcertId { get; set; } //id
        public string Name { get; set; } = string.Empty; //nazwa
        public string Artist { get; set; } = string.Empty; //artysta
        public decimal Price { get; set; } // cena bitletu
        public string? ImageUrl { get; set; } //adres obrazka
        public string? ImageThumbnailUrl { get; set; } //adres miniatury
        public bool IsConcertOfTheMonth { get; set; } //czy to koncert miesiaca
        public bool IsRecommended { get; set; } //czy to koncert polecany
        public Description Description { get; set; } = default; // opis
        public ICollection<Content> ConcertContent { get; set; } = new List<Content>(); //kolekcja kontentu
        public ICollection<Faq>? Faq { get; set; }
        public ICollection<Announcement>? Announcements { get; set; } //zapowiedzi
        //public ICollection<Opinion>? Opinions { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default;



    }
}
