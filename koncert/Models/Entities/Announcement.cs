namespace koncert.Models.Entities
{
    public class Announcement
    {
        public int AnnouncementId { get; set; }
        public string Content { get; set; } = string.Empty;

        public int ConcertId { get; set; }
    }
}