using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibraryWebAPI.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> BooksT { get; set; }
        public DbSet<Member> MembersT { get; set; }

        public DbSet<Transaction> borrowAndReturnT { get; set; }
        public DbSet<OverdueAndFines> OverdueAndFinesT { get; set; }
        public DbSet<Notification> NotificationsT { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LibDB;Encrypt=False");
        }
    }
}
