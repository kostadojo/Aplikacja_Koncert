namespace koncert.Properties.Models.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; } = string.Empty; // nazwa
        public ICollection<Concert>? Concerts { get; set; } //kolekcja koncertów


    }
}