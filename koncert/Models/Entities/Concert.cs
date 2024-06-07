namespace koncert.Models.Entities
{
    public class Concert
    {
        public int ConcertId { get; set; } //id
        public string Name { get; set; } = string.Empty; //nazwa
        public string Artist { get; set; } = string.Empty; //artysta
        public decimal Price { get; set; } // cena bitletu
        public string? ImageUrl { get; set; } //adres obrazka
        public string? ImageThumbnailUrl { get; set; } //adres miniatury
        public Description Description { get; set; } = default; // opis
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default;



    }
}
