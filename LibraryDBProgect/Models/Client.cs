using System.Collections.Generic;

namespace LibraryDBProgect
{
    public class Client
    {
        public int Id { get; set; }        
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public ICollection<Book> BorrowedBooks { get; set; }

        public Client()
        {
            BorrowedBooks = new List<Book>();
        }        
    }
}