using koncert.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace koncert.Models
{
    public class koncertDbContext : DbContext
    {
        public koncertDbContext(DbContextOptions<koncertDbContext> options) : base(options)
        {
        }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<NoteOneDescription> NoteOneDescription { get; set; }
        public DbSet<NoteTwoSell> NoteTwoSell { get; set; }
        public DbSet<NoteThreeOther> NoteThreeOther { get; set; }

    }

}


