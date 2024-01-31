using OneToOneTask1.models;
using Microsoft.EntityFrameworkCore;


namespace OneToOneTask1.context
{

    public class MyAppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=HAFIZ; database=dotNet; Integrated Security=true; Encrypt=False") ;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .HasOne(a => a.Biography)
                .WithOne(b => b.Author)
                .HasForeignKey<Biography>(c => c.AuthorID);
        }

        public DbSet<Author>? Authors { get; set; }
        public DbSet<Biography>? Biographies { get; set; }
    }
}
