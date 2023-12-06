using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System;

namespace FluentAPIDemo.Models
{
    public class StudentDbContextClass : DbContext
    {
        public StudentDbContextClass(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Person>()
            //.HasOne(p => p.Passport) //Person has one Passport
            //.WithOne(p => p.Person) //Passport is associated with one Person
            //.HasForeignKey<Passport>(p => p.PersonId); //Foreign key in Passport table

            //modelBuilder.Entity<Author>()
            //    .HasMany(a => a.Books) //Author has many books
            //    .WithOne(b => b.Author) // Book is associated with one Author
            //    .HasForeignKey(b => b.AuthorId);

            modelBuilder.Entity<Book>()
                .Property(b => b.Title)
                .HasColumnName("Book Name")
                .IsRequired(true);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        public DbSet<Book> Books{ get; set; }

        public DbSet<Author> Authors { get; set; }

    }
}
