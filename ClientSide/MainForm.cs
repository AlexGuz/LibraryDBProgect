using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDBProgect;
using System.Data.Entity;

namespace ClientSide
{
    public partial class MainForm : Form
    {
        private LibraryContext db;

        List<Book> foundBook = new List<Book>();

        public Client Client { get; set; }

        public MainForm()
        {
            InitializeComponent();
            db = new LibraryContext();
            db.Clients.Load();
            db.Books.Load();
        }

        private void showAllBtn_Click(object sender, EventArgs e)
        {
            ShowBooks();
        }

        internal void ShowBooks()
        {
            IQueryable<Book> bookInLibrary = db.Books.Where(p => p.Client == null);
            dgvLibraryBooks.DataSource = bookInLibrary.ToList();

            IQueryable<Book> clientBook = db.Books.Where(p => p.ClientId == Client.Id);
            dgvClientBooks.DataSource = clientBook.ToList();
        }

        private void findBookBtn_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm();

            DialogResult result = searchForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            foundBook.Clear();

            foundBook = BookService.FindBooks(searchForm, db);

            dgvLibraryBooks.DataSource = foundBook;
        }

        private void borrowBookBtn_Click(object sender, EventArgs e)
        {
            if (dgvLibraryBooks.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvLibraryBooks[0, dgvLibraryBooks.SelectedRows[0].Index].Value.ToString());

                Book book = db.Books.Find(id);
                book.Client = Client;

                db.SaveChanges();

                BorrowBook borrow = new BorrowBook();
                borrow.Book = book;
                borrow.AutorName = book.Autor.AutorName;
                borrow.Client = Client;
                borrow.BorrowedTime = DateTime.Now;

                db.Borrow.Add(borrow);

                db.SaveChanges();

                ShowBooks();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(db);
            loginForm.Owner = this;
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(db);
            registerForm.Owner = this;
            registerForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (dgvClientBooks.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvClientBooks[0, dgvClientBooks.SelectedRows[0].Index].Value.ToString());

                Book book = db.Books.Find(id);
                book.Client = null;

                BorrowBook borrow = db.Borrow.First(b => b.BookId == id);
                borrow.IsReturned = true;

                db.SaveChanges();
                ShowBooks();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryOfBorrowsForm borrowHistoryForm = new HistoryOfBorrowsForm();

            IQueryable<BorrowBook> borrowIQuer = db.Borrow.Where(b => b.Client.Id == Client.Id);

            List<BorrowBook> borrowList = borrowIQuer.ToList();

            borrowHistoryForm.dgvBorrowsBooks.DataSource = borrowList;
            borrowHistoryForm.Show();
        }
    }
}