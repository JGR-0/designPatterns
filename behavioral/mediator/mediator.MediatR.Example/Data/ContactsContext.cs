using System;
using Microsoft.EntityFrameworkCore;

namespace mediator.MediatR.Example.Data
{
    public class ContactsContext : DbContext
	{
        public ContactsContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, FirstName = "Bob", LastName = "Smith"},
                new Contact { Id = 2, FirstName = "Mary", LastName = "Walker" },
                new Contact { Id = 3, FirstName = "Pete", LastName = "Ackerman" }
            );
        }
    }
}

