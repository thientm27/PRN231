
using BookStore.ODataApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.ODataApi.DAOs
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Press> Presses { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Book>().OwnsOne(c => c.Location);
        }
    }
}