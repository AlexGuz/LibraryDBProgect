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

namespace ClientSide
{
    public partial class LoginForm : Form
    {
        public LoginForm(LibraryContext db)
        {
            this.db = db;
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                MessageBox.Show("Enter login");
            }
            else if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                Client client = db.Clients.FirstOrDefault(c => c.Login == textBoxLogin.Text.Trim() && c.Password == textBoxPassword.Text.Trim());
                if (client != null)
                {
                    MainForm main = (MainForm)Owner;
                    main.Client = client;

                    main.ShowBooks();

                    main.btnLogin.Enabled = false;
                    main.btnRegister.Enabled = false;
                    main.btnShowAll.Enabled = true;
                    main.btnBorrowBook.Enabled = true;
                    main.btnFindBook.Enabled = true;
                    main.btnReturn.Enabled = true;
                    main.btnHistory.Enabled = true;

                    this.Close();
                }
                else
                    MessageBox.Show("User entered data does not exist! Sign up.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}