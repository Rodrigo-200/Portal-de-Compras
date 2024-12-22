namespace Portal_Compras
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_openRegistrationForm = new System.Windows.Forms.Button();
            this.chb_showPassword = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(194, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(194, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Username";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.ForeColor = System.Drawing.Color.Red;
            this.lbl_login.Location = new System.Drawing.Point(202, 213);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(0, 13);
            this.lbl_login.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 46);
            this.label1.TabIndex = 27;
            this.label1.Text = "Login";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(194, 155);
            this.txt_password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_password.MaxLength = 50;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(94, 20);
            this.txt_password.TabIndex = 25;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(194, 114);
            this.txt_username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_username.MaxLength = 50;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(130, 20);
            this.txt_username.TabIndex = 24;
            // 
            // btn_openRegistrationForm
            // 
            this.btn_openRegistrationForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_openRegistrationForm.FlatAppearance.BorderSize = 0;
            this.btn_openRegistrationForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_openRegistrationForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_openRegistrationForm.Location = new System.Drawing.Point(191, 215);
            this.btn_openRegistrationForm.Margin = new System.Windows.Forms.Padding(2);
            this.btn_openRegistrationForm.Name = "btn_openRegistrationForm";
            this.btn_openRegistrationForm.Size = new System.Drawing.Size(144, 24);
            this.btn_openRegistrationForm.TabIndex = 32;
            this.btn_openRegistrationForm.Text = "Ainda não tem uma conta?";
            this.btn_openRegistrationForm.UseVisualStyleBackColor = true;
            this.btn_openRegistrationForm.Click += new System.EventHandler(this.btn_openRegistrationForm_Click);
            // 
            // chb_showPassword
            // 
            this.chb_showPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_showPassword.AutoSize = true;
            this.chb_showPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_showPassword.BackgroundImage")));
            this.chb_showPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chb_showPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_showPassword.Location = new System.Drawing.Point(293, 155);
            this.chb_showPassword.Name = "chb_showPassword";
            this.chb_showPassword.Size = new System.Drawing.Size(31, 19);
            this.chb_showPassword.TabIndex = 29;
            this.chb_showPassword.Text = "        ";
            this.chb_showPassword.UseVisualStyleBackColor = true;
            this.chb_showPassword.CheckedChanged += new System.EventHandler(this.chb_showPassword_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(194, 187);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(130, 23);
            this.btn_login.TabIndex = 33;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 336);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_openRegistrationForm);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chb_showPassword);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chb_showPassword;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_openRegistrationForm;
        private System.Windows.Forms.Button btn_login;
    }
}

