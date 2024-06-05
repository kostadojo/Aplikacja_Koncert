namespace koncert.Models.Entities
{
    public class NoteTwoSell
    {
        public int NoteTwoSellId { get; set; } //id
        public string Content { get; set; } = string.Empty; //nie może być puste
        public int DescriptionId { get; set; } //nawigacja

    }
}