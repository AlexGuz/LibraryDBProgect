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

namespace LibrarySide
{
    public partial class MainForm : Form
    {
        private LibraryContext db = new LibraryContext();
        public List<Book> foundBook;
        public List<Autor> foundAutor;
        public MainForm()
        {
            InitializeComponent();
            foundBook = new List<Book>();
            foundAutor = new List<Autor>();
            db.Books.Load();
            db.Autors.Load();         
        }

        private void btnShowAllBooks_Click(object sender, EventArgs e)
        {
            dgvBooks.DataSource = db.Books.Local.ToBindingList();
        }
        
        private void btnBookAdd_Click(object sender, EventArgs e)
        {

            AddBookForm addForm = new AddBookForm(db);
            addForm.Owner = this;
            addForm.Show();            
        }

        private void btnBookChange_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvBooks[0, dgvBooks.SelectedRows[0].Index].Value.ToString());

                Book book = db.Books.Find(id);
                ChangeBookForm changeBook = new ChangeBookForm(db, book);

                changeBook.tbTitle.Text = book.Title;
                changeBook.tbReleaseDate.Text = book.ReleaseDate.ToString();
                changeBook.cbGenre.SelectedIndex = (int)book.Genre;
                changeBook.cbAutor.SelectedValue = book.Autor.Id;

                changeBook.Owner = this;
                changeBook.Show();
            }
        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvBooks[0, dgvBooks.SelectedRows[0].Index].Value.ToString());

                Book book = db.Books.Find(id);
                db.Books.Remove(book);
                db.SaveChanges();
            }
        }

        private void btnFindBook_Click(object sender, EventArgs e)
        {
            BookSearchForm searchForm = new BookSearchForm();

            DialogResult result = searchForm.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            foundBook.Clear();

            foundBook = BookService.FindBooks(searchForm, db);

            dgvBooks.DataSource = foundBook;
        }

        private void btnShowAllAutors_Click(object sender, EventArgs e)
        {
            dgvAutors.DataSource = db.Autors.Local.ToList();
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            AddAutorForm authorForm = new AddAutorForm(db);
            authorForm.Owner = this;
            authorForm.Show();
        }

        private void btnAuthorChange_Click(object sender, EventArgs e)
        {
            if (dgvAutors.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvBooks[0, dgvAutors.SelectedRows[0].Index].Value.ToString());

                Autor autor = db.Autors.Find(id);

                ChangeAutorForm changeAutor = new ChangeAutorForm(db, autor);
                changeAutor.tbName.Text = autor.Name;
                changeAutor.tbSurname.Text = autor.Surname;
            }
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            if (dgvAutors.SelectedRows.Count > 0)
            {
                int id = int.Parse(dgvBooks[0, dgvAutors.SelectedRows[0].Index].Value.ToString());

                Autor autor = db.Autors.Find(id);
                db.Autors.Remove(autor);
                db.SaveChanges();
            }
        }

        private void btnAuthorSearch_Click(object sender, EventArgs e)
        {
            FindAutorForm findAutor = new FindAutorForm();
            DialogResult result = findAutor.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            foundAutor.Clear();

            foundAutor = FindAuthor(findAutor);

            dgvAutors.DataSource = foundAutor;
        }

        private List<Autor> FindAuthor(FindAutorForm authorSearchForm)
        {
            IQueryable<Autor> autor = db.Autors;

            List<Autor> result = new List<Autor>();
            if (!string.IsNullOrEmpty(authorSearchForm.tbName.Text))
                autor = autor.Where(p => p.Name.Contains(authorSearchForm.tbName.Text));

            if (!string.IsNullOrEmpty(authorSearchForm.tbSurname.Text))
                autor = autor.Where(p => p.Surname.Contains(authorSearchForm.tbSurname.Text));

            result.AddRange(autor.ToList());

            return result;
        }
    }
}