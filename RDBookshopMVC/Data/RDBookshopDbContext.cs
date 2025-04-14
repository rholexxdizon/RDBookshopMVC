using Microsoft.EntityFrameworkCore;
using RDBookshopMVC.Models;

namespace RDBookshopMVC.Data
{
    public class RDBookshopDbContext : DbContext
    {
        public RDBookshopDbContext(DbContextOptions<RDBookshopDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        //Relationships using Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Book to Author
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Author)
                .WithMany(a => a.Books)
                .HasForeignKey(b => b.AuthorId);

            //Book to Category
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId);

            //Configure Price column precision
            modelBuilder.Entity<Book>()
                .Property(b => b.Price)
                .HasColumnType("decimal(18,2)"); // Set precision to 18 digits, with 2 decimal places


        }
    }
}

