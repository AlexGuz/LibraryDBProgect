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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbSurname.Text)
                || string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text)
                || string.IsNullOrEmpty(tbComfirmPassword.Text))
                MessageBox.Show("Not all the data entered in the form.");

            else if (tbPassword.Text != tbComfirmPassword.Text)
                MessageBox.Show("Password and confirmation do not match");

            else if (db.Clients.FirstOrDefault(c => c.Login == tbLogin.Text) != null)
                MessageBox.Show("Such user is existed allready. Choose another login, please");

            else
            {
                Client client = new Client();
                client.Name = tbName.Text;
                client.Surname = tbSurname.Text;
                client.Login = tbLogin.Text;
                client.Password = tbPassword.Text;

                db.Clients.Add(client);
                db.SaveChanges();

                Close();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}