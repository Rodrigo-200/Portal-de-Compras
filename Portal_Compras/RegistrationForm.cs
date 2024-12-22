using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string username = txt_name.Text;
            string password = txt_password.Text;
            string name = txt_username.Text;

            if (db.CLIENT.FirstOrDefault(c => c.USERNAME == username) != null) // replace with storage procedure user exist
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
    }
}