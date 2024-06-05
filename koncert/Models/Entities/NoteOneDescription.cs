namespace koncert.Models.Entities
{
    public class NoteOneDescription
    {
        public int NoteOneDescriptionId { get; set; } //id
        public string Content { get; set; } = string.Empty; // nie jest puste
        public int DescriptionId { get; set; } //nawigacja

    }
}