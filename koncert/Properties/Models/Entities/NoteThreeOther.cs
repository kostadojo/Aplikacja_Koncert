namespace koncert.Properties.Models.Entities
{
    public class NoteThreeOther
    {
        public int NoteThreeOtherId { get; set; } //id
        public string Content { get; set; } = string.Empty; //nie może być puste
        public int DescriptionId { get; set; } //nawigacja

    }
}