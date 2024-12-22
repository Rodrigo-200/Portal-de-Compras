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
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            if(true) // replace with storage procedure user exist
            {
                this.Visible = false;
                Portal portal = new Portal();
                portal.ShowDialog();
                this.Visible = true;
            }
        }
        private void btn_openRegistrationForm_Click(object sender, EventArgs e)
        {
            this.Visible=false; 
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
            this.Visible = true;
        }
    }
}
