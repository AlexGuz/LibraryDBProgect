using LibraryDBProgect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySide
{
    public partial class AddBookForm : Form
    {
        private LibraryContext db;
        public AddBookForm(LibraryContext _db)
        {
            db = _db;
            InitializeComponent();
            
            cbGenre.DataSource = Enum.GetNames(typeof(BookGenre));

            List<Autor> authors = db.Autors.ToList();
            cbAutor.DataSource = authors;
            cbAutor.ValueMember = "Id";
            cbAutor.DisplayMember = "AutorName";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Book book = new Book();
           
            if (string.IsNullOrEmpty(tbTitle.Text)|| string.IsNullOrEmpty(tbReleaseDate.Text))
            {
                MessageBox.Show("Not all data entered");
            }
            
            else
            {
                book.Title = tbTitle.Text;
                book.Autor = (Autor)cbAutor.SelectedItem;
                book.Genre = (BookGenre)Enum.Parse(typeof(BookGenre), cbGenre.SelectedValue.ToString());
                book.ReleaseDate = int.Parse(tbReleaseDate.Text);

                db.Books.Add(book);
                db.SaveChanges();

                MainForm main = (MainForm)Owner;
                main.foundBook.Add(book);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}