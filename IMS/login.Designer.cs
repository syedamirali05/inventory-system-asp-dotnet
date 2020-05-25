namespace IMS
{
    partial class login
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
            this.lbluser = new System.Windows.Forms.Label();
            this.usernameTXT = new System.Windows.Forms.TextBox();
            this.passwordTXT = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.btnUserlogin = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.btnUserlogin);
            this.leftPanel.Controls.Add(this.passwordTXT);
            this.leftPanel.Controls.Add(this.lblpassword);
            this.leftPanel.Controls.Add(this.usernameTXT);
            this.leftPanel.Controls.Add(this.lbluser);
            this.leftPanel.Controls.SetChildIndex(this.panel1, 0);
            this.leftPanel.Controls.SetChildIndex(this.lbluser, 0);
            this.leftPanel.Controls.SetChildIndex(this.usernameTXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.lblpassword, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.btnUserlogin, 0);
            // 
            // rightPanel
            // 
            this.rightPanel.Size = new System.Drawing.Size(951, 611);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(3, 258);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(75, 20);
            this.lbluser.TabIndex = 1;
            this.lbluser.Text = "Username";
            // 
            // usernameTXT
            // 
            this.usernameTXT.Location = new System.Drawing.Point(3, 281);
            this.usernameTXT.MaxLength = 30;
            this.usernameTXT.Name = "usernameTXT";
            this.usernameTXT.Size = new System.Drawing.Size(241, 27);
            this.usernameTXT.TabIndex = 2;
            // 
            // passwordTXT
            // 
            this.passwordTXT.Location = new System.Drawing.Point(3, 338);
            this.passwordTXT.MaxLength = 30;
            this.passwordTXT.Name = "passwordTXT";
            this.passwordTXT.Size = new System.Drawing.Size(241, 27);
            this.passwordTXT.TabIndex = 4;
            this.passwordTXT.UseSystemPasswordChar = true;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(3, 315);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(70, 20);
            this.lblpassword.TabIndex = 3;
            this.lblpassword.Text = "Password";
            // 
            // btnUserlogin
            // 
            this.btnUserlogin.FlatAppearance.BorderSize = 2;
            this.btnUserlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserlogin.Location = new System.Drawing.Point(3, 383);
            this.btnUserlogin.Name = "btnUserlogin";
            this.btnUserlogin.Size = new System.Drawing.Size(241, 43);
            this.btnUserlogin.TabIndex = 5;
            this.btnUserlogin.Text = "Login";
            this.btnUserlogin.UseVisualStyleBackColor = true;
            this.btnUserlogin.Click += new System.EventHandler(this.btnUserlogin_Click);
            // 
            // login
            // 
            this.AcceptButton = this.btnUserlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 611);
            this.Name = "login";
            this.Text = "login";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Button btnUserlogin;
        private System.Windows.Forms.TextBox passwordTXT;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox usernameTXT;
    }
}