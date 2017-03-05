using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryDBProgect;

namespace LibrarySide
{
    class BookService
    {        
        public static List<Book> FindBooks(BookSearchForm searchForm, LibraryContext db)
        {
            List<Book> result = new List<Book>();

            IQueryable<Book> bookInLibrary = db.Books.Where(p => p.Client == null);

            if (!string.IsNullOrEmpty(searchForm.tbTitle.Text))
                bookInLibrary = bookInLibrary.Where(p => p.Title.Contains(searchForm.tbTitle.Text));

            if (!string.IsNullOrEmpty(searchForm.tbAuthor.Text))
                bookInLibrary = bookInLibrary.Where(p => p.Autor.Name.Contains(searchForm.tbAuthor.Text) || p.Autor.Surname.Contains(searchForm.tbSurname.Text));

            int year = 0;
            if (!string.IsNullOrEmpty(searchForm.tbPublishing.Text) && int.TryParse(searchForm.tbPublishing.Text, out year))
                bookInLibrary = bookInLibrary.Where(p => p.ReleaseDate == year);

            if (searchForm.clbGenre.CheckedItems.Count > 0)
            {
                foreach (var genre in searchForm.clbGenre.CheckedItems)
                {
                    BookGenre selectedGenre = (BookGenre)Enum.Parse(typeof(BookGenre), genre.ToString());

                    result.AddRange(bookInLibrary.Where(p => p.Genre == selectedGenre).ToList());
                }
            }
            else
                result.AddRange(bookInLibrary.ToList());

            return result;
        }
    }
}
