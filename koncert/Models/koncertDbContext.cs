using koncert.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace koncert.Models
{
    public class koncertDbContext : IdentityDbContext
    {
        public koncertDbContext(DbContextOptions<koncertDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; } = default!;
        public DbSet<Concert> Concerts { get; set; } = default!;
        public DbSet<Description> Descriptions { get; set; } = default!;
        public DbSet<NoteOneDescription> NoteOneDescription { get; set; } = default!;
        public DbSet<NoteTwoSell> NoteTwoSell { get; set; } = default!;
        public DbSet<NoteThreeOther> NoteThreeOther { get; set; } = default!;
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; } = default!;
        public DbSet<Order> Orders { get; set; } = default!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = default!;

    }

}


