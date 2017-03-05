using System.Collections.Generic;
using System.Data.Entity;

namespace LibraryDBProgect
{
    internal class LibraryContextInitializer : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext db)
        {
            Autor autor1 = new Autor { Name = "Leo", Surname = "Tolstoy" };
            Autor autor2 = new Autor { Name = "Gustave", Surname = "Flaubert" };
            Autor autor3 = new Autor { Name = "F.Scott", Surname = "Fitzgerald" };
            Autor autor4 = new Autor { Name = "Vladimir", Surname = "Nabokov" };
            Autor autor5 = new Autor { Name = "George", Surname = "Eliot" };
            Autor autor6 = new Autor { Name = "Mark", Surname = "Twain" };
            Autor autor7 = new Autor { Name = "Anton", Surname = "Chekhov" };
            Autor autor8 = new Autor { Name = "Marcel", Surname = "Proust" };
            Autor autor9 = new Autor { Name = "William", Surname = "Shakespeare" };

            db.Autors.Add(autor1);
            db.Autors.Add(autor2);
            db.Autors.Add(autor3);
            db.Autors.Add(autor4);
            db.Autors.Add(autor5);
            db.Autors.Add(autor6);
            db.Autors.Add(autor7);
            db.Autors.Add(autor8);
            db.Autors.Add(autor9);
            db.SaveChanges();

            Client c1 = new Client { Name = "Peter", Surname = "Seibel", Login = "CodersAtWork", Password = "12345" };
            Client c2 = new Client { Name = "GOF", Surname = "GOF", Login = "DesignPatterns", Password = "12345" };
            Client c3 = new Client { Name = " Robert", Surname = "Martin", Login = "CleanCode", Password = "12345" };
            Client c4 = new Client { Name = "1", Surname = "1", Login = "1", Password = "1" };

            db.Clients.Add(c1);
            db.Clients.Add(c2);
            db.Clients.Add(c3);
            db.Clients.Add(c4);
            db.SaveChanges();

            Book book1 = new Book { Title = "Anna Karenina", Genre = BookGenre.RealisticFiction, ReleaseDate = 2008, Autor = autor1 };
            Book book2 = new Book { Title = "Madame Bovary", Genre = BookGenre.RomanceNovel, ReleaseDate = 2005, Autor = autor2 };
            Book book3 = new Book { Title = "War and Peace", Genre = BookGenre.Novel, ReleaseDate = 1989, Autor = autor1 };
            Book book4 = new Book { Title = "The Great Gatsby ", Genre = BookGenre.Novel, ReleaseDate = 2011, Autor = autor3 };
            Book book5 = new Book { Title = "Lolita", Genre = BookGenre.Novel, ReleaseDate = 2001, Autor = autor4 };
            Book book6 = new Book { Title = "Middlemarch ", Genre = BookGenre.Novel, ReleaseDate = 1976, Autor = autor5 };
            Book book7 = new Book { Title = "The Adventures of Huckleberry", Genre = BookGenre.Satire, ReleaseDate = 1979, Autor = autor6 };
            Book book8 = new Book { Title = "The Stories of Anton Chekhov", Genre = BookGenre.Collections, ReleaseDate = 1985, Autor = autor7 };
            Book book9 = new Book { Title = "In Search of Lost Time", Genre = BookGenre.Modernist, ReleaseDate = 2004, Autor = autor8 };
            Book book10 = new Book { Title = "Hamlet ", Genre = BookGenre.Tragedy, ReleaseDate = 1988, Autor = autor9 };

            db.Books.AddRange(new List<Book>() { book1, book2, book3, book4, book5, book6, book7, book7, book8, book9, book10 });
            db.SaveChanges();
        }
    }
}