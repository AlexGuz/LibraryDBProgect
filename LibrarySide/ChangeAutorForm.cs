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
    public partial class ChangeAutorForm : Form
    {
        private Autor autor;
        private LibraryContext db;

        public ChangeAutorForm()
        {
            InitializeComponent();
        }

        public ChangeAutorForm(LibraryContext db)
        {
            this.db = db;
        }

        public ChangeAutorForm(LibraryContext db, Autor autor) : this(db)
        {
            this.autor = autor;        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            autor.Name = tbName.Text;
            autor.Surname = tbSurname.Text;
            
            db.Entry(autor).State = EntityState.Modified;
            db.SaveChanges();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
