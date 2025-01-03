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
    public partial class Checkout : Form
    {
        public Checkout()
        {
            InitializeComponent();
        }

       

        private void btn_finalizeBuy_Click(object sender, EventArgs e)
        {
            // Simulate purchase process
            progressBar1.Value = 0;
            progressBar1.Maximum = 100;

            for (int i = 0; i <= 100; i++)
            {
                // Simulate some work being done
                System.Threading.Thread.Sleep(10);
                progressBar1.Value = i;
            }

            MessageBox.Show("Purchase completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
