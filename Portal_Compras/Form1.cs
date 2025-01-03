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
    public partial class Form1 : Form
    {
        Portal portal = new Portal();
        EntitiesBarEscola EntitiesBarEscola = new EntitiesBarEscola();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;

            if (Convert.ToBoolean(EntitiesBarEscola.Login_Validation(username, password).FirstOrDefault().UserExists == true))
            {
                if (Convert.ToBoolean(EntitiesBarEscola.Login_Validation(username, password).FirstOrDefault().PasswordCorrect) == true)
                {
                    Generic.current_Logged_Client = EntitiesBarEscola.CLIENT.Where(p => p.USERNAME == username).FirstOrDefault();
                    this.Visible = false;
                    portal = new Portal();
                    portal.FormClosed += onForm2Close;
                    portal.ShowDialog();
                    clearInputs();
                }
                else
                {
                    MessageBox.Show("Password incorreta");
                }
            }
            else
            {
                MessageBox.Show("Este utilizador não existe");
            }
        }

        private void onForm2Close(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void btn_openRegistrationForm_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
            this.Visible = true;
        }

        private void chb_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_showPassword.Checked)
            {
                chb_showPassword.ImageIndex = 0;
                txt_password.PasswordChar = '\0';
            }
            else
            {
                chb_showPassword.ImageIndex = 1;
                txt_password.PasswordChar = '*';
            }
        }

        private void clearInputs()
        {
            txt_username.Text = "";
            txt_password.Text = "";
        }
    }
}
