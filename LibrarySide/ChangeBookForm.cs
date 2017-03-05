using LibraryDBProgect;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySide
{
    public partial class ChangeBookForm : Form
    {
        private LibraryContext db;
        public ChangeBookForm(LibraryContext _db, Book book)
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
            book.Title = tbTitle.Text;
            book.Autor = (Autor)cbAutor.SelectedItem;
            book.Genre = (BookGenre)Enum.Parse(typeof(BookGenre), cbGenre.SelectedValue.ToString());

            int releaseDate = 0;
            if (int.TryParse(tbReleaseDate.Text, out releaseDate))
            {
                book.ReleaseDate = releaseDate;
                db.Entry(book).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}