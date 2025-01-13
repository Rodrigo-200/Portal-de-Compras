namespace Portal_Compras
{
    partial class RegistrationForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnGoBackToLoginPage = new System.Windows.Forms.Button();
            this.txtNIF = new System.Windows.Forms.TextBox();
            this.labelNIF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.labelTitle.Location = new System.Drawing.Point(245, 44);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(344, 54);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Registe-se Agora";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelName.Location = new System.Drawing.Point(173, 137);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(66, 28);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Nome";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelUsername.Location = new System.Drawing.Point(164, 193);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(99, 28);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPassword.Location = new System.Drawing.Point(164, 249);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(93, 28);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(286, 249);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(265, 30);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(287, 137);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(265, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(286, 193);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(265, 30);
            this.txtUsername.TabIndex = 5;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnRegisterUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegisterUser.ForeColor = System.Drawing.Color.White;
            this.btnRegisterUser.Location = new System.Drawing.Point(284, 364);
            this.btnRegisterUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(267, 37);
            this.btnRegisterUser.TabIndex = 7;
            this.btnRegisterUser.Text = "Registar";
            this.btnRegisterUser.UseVisualStyleBackColor = false;
            this.btnRegisterUser.Click += new System.EventHandler(this.btn_registerUser_Click);
            // 
            // btnGoBackToLoginPage
            // 
            this.btnGoBackToLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBackToLoginPage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGoBackToLoginPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btnGoBackToLoginPage.Location = new System.Drawing.Point(284, 409);
            this.btnGoBackToLoginPage.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoBackToLoginPage.Name = "btnGoBackToLoginPage";
            this.btnGoBackToLoginPage.Size = new System.Drawing.Size(267, 37);
            this.btnGoBackToLoginPage.TabIndex = 8;
            this.btnGoBackToLoginPage.Text = "Já está registado? Log in";
            this.btnGoBackToLoginPage.UseVisualStyleBackColor = true;
            this.btnGoBackToLoginPage.Click += new System.EventHandler(this.btn_GobackToLoginPage_Click);
            // 
            // txtNIF
            // 
            this.txtNIF.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIF.Location = new System.Drawing.Point(286, 305);
            this.txtNIF.Margin = new System.Windows.Forms.Padding(4);
            this.txtNIF.MaxLength = 50;
            this.txtNIF.Name = "txtNIF";
            this.txtNIF.Size = new System.Drawing.Size(265, 30);
            this.txtNIF.TabIndex = 10;
            this.txtNIF.UseSystemPasswordChar = true;
            // 
            // labelNIF
            // 
            this.labelNIF.AutoSize = true;
            this.labelNIF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelNIF.Location = new System.Drawing.Point(215, 303);
            this.labelNIF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNIF.Name = "labelNIF";
            this.labelNIF.Size = new System.Drawing.Size(42, 28);
            this.labelNIF.TabIndex = 9;
            this.labelNIF.Text = "NIF";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.txtNIF);
            this.Controls.Add(this.labelNIF);
            this.Controls.Add(this.btnGoBackToLoginPage);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Button btnGoBackToLoginPage;
        private System.Windows.Forms.TextBox txtNIF;
        private System.Windows.Forms.Label labelNIF;
    }
}