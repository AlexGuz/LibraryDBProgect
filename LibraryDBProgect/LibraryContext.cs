using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDBProgect
{
    public class LibraryContext : DbContext
    {
        static LibraryContext()
        {
            Database.SetInitializer(new LibraryContextInitializer());
        }

        public LibraryContext() : base("DefaultConnection")
        { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Autor> Autors { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BorrowBook> Borrow { get; set; }
    }
}
