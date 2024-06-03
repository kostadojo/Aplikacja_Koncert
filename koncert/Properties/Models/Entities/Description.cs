namespace koncert.Properties.Models.Entities
{
    public class Description
    {
        public int DescriptionId { get; set; } //id
        public string Name { get; set; } = string.Empty; //nazwa
        public ICollection<NoteOneDescription>? NoteOneDescription { get; set; } //opis opisu
        public ICollection<NoteTwoSell>? NoteTwoSell { get; set; } //informacja o sprzedzy
        public ICollection<NoteThreeOther>? NoteThreeOther { get; set; } // inne informacje
        public string Content { get; set; } = string.Empty;

        public int ConcertId { get; set; } //nawigacja

    }
}