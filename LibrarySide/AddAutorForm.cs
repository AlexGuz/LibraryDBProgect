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

namespace LibrarySide
{
    public partial class AddAutorForm : Form
    {
        private LibraryContext db;
        
        public AddAutorForm(LibraryContext _db)
        {
            db = _db;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {           
            Autor author = new Autor();

            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrWhiteSpace(tbSurname.Text))
            {
                MessageBox.Show("Enter autors name and surname");
            }
           
            else
            {
                author.Name = tbName.Text;
                author.Surname = tbSurname.Text;

                db.Autors.Add(author);
                db.SaveChanges();                

                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
