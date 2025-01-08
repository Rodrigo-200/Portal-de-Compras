using System;
using System.Linq;
using System.Windows.Forms;

namespace Portal_Compras
{
    public partial class RegistrationForm : Form
    {
        private EntitiesBarEscola db = new EntitiesBarEscola();

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btn_registerUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;

            if (db.CLIENT.FirstOrDefault(c => c.USERNAME == username) != null)
            {
                MessageBox.Show("Erro");
            }
            else
            {
                if (!(string.IsNullOrEmpty(password) && string.IsNullOrEmpty(name)))
                {
                    CLIENT user = new CLIENT();

                    user.NAME = name;
                    user.PASSWORD = password;
                    user.USERNAME = username;

                    db.CLIENT.Add(user);
                    db.SaveChanges();

                    clearInputs();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro");
                }
            }
        }

        private void btn_GobackToLoginPage_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clearInputs()
        {
            txtName.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";
        }
    }
}