namespace Portal_Compras
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_registerUser = new System.Windows.Forms.Button();
            this.btn_GobackToLoginPage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(187, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(190, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 34;
            this.label1.Text = "Registrar";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(189, 214);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(130, 20);
            this.txt_password.TabIndex = 33;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(189, 119);
            this.txt_name.Margin = new System.Windows.Forms.Padding(2);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(130, 20);
            this.txt_name.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(188, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(190, 165);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.MaxLength = 50;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(130, 20);
            this.txt_username.TabIndex = 37;
            // 
            // btn_registerUser
            // 
            this.btn_registerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btn_registerUser.Location = new System.Drawing.Point(189, 253);
            this.btn_registerUser.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registerUser.Name = "btn_registerUser";
            this.btn_registerUser.Size = new System.Drawing.Size(129, 24);
            this.btn_registerUser.TabIndex = 39;
            this.btn_registerUser.Text = "Registrar";
            this.btn_registerUser.UseVisualStyleBackColor = true;
            this.btn_registerUser.Click += new System.EventHandler(this.btn_registerUser_Click);
            // 
            // btn_GobackToLoginPage
            // 
            this.btn_GobackToLoginPage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_GobackToLoginPage.FlatAppearance.BorderSize = 0;
            this.btn_GobackToLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GobackToLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.btn_GobackToLoginPage.Location = new System.Drawing.Point(189, 282);
            this.btn_GobackToLoginPage.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GobackToLoginPage.Name = "btn_GobackToLoginPage";
            this.btn_GobackToLoginPage.Size = new System.Drawing.Size(129, 24);
            this.btn_GobackToLoginPage.TabIndex = 40;
            this.btn_GobackToLoginPage.Text = "Já registrado?";
            this.btn_GobackToLoginPage.UseVisualStyleBackColor = true;
            this.btn_GobackToLoginPage.Click += new System.EventHandler(this.btn_GobackToLoginPage_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 336);
            this.Controls.Add(this.btn_GobackToLoginPage);
            this.Controls.Add(this.btn_registerUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_registerUser;
        private System.Windows.Forms.Button btn_GobackToLoginPage;
    }
}