using koncert.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace koncert.Models
{
    public class koncertDbContext : DbContext
    {
        public koncertDbContext(DbContextOptions<koncertDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<NoteOneDescription> NoteOneDescription { get; set; }
        public DbSet<NoteTwoSell> NoteTwoSell { get; set; }
        public DbSet<NoteThreeOther> NoteThreeOther { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    }

}


