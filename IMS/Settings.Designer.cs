namespace IMS
{
    partial class Settings
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
            this.serverTXT = new System.Windows.Forms.TextBox();
            this.databaseTXT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userTXT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passTXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.saveBTN = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.saveBTN);
            this.leftPanel.Controls.Add(this.isCB);
            this.leftPanel.Controls.Add(this.passTXT);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.userTXT);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.databaseTXT);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.serverTXT);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Size = new System.Drawing.Size(250, 640);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.userTXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.passTXT, 0);
            this.leftPanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.saveBTN, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Server";
            // 
            // serverTXT
            // 
            this.serverTXT.Location = new System.Drawing.Point(6, 245);
            this.serverTXT.MaxLength = 50;
            this.serverTXT.Name = "serverTXT";
            this.serverTXT.Size = new System.Drawing.Size(241, 27);
            this.serverTXT.TabIndex = 3;
            // 
            // databaseTXT
            // 
            this.databaseTXT.Location = new System.Drawing.Point(6, 302);
            this.databaseTXT.MaxLength = 50;
            this.databaseTXT.Name = "databaseTXT";
            this.databaseTXT.Size = new System.Drawing.Size(241, 27);
            this.databaseTXT.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Database";
            // 
            // userTXT
            // 
            this.userTXT.Location = new System.Drawing.Point(6, 357);
            this.userTXT.MaxLength = 50;
            this.userTXT.Name = "userTXT";
            this.userTXT.Size = new System.Drawing.Size(241, 27);
            this.userTXT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "User ID";
            // 
            // passTXT
            // 
            this.passTXT.Location = new System.Drawing.Point(6, 410);
            this.passTXT.MaxLength = 50;
            this.passTXT.Name = "passTXT";
            this.passTXT.Size = new System.Drawing.Size(241, 27);
            this.passTXT.TabIndex = 9;
            this.passTXT.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Password";
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(6, 451);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(156, 24);
            this.isCB.TabIndex = 10;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // saveBTN
            // 
            this.saveBTN.FlatAppearance.BorderSize = 2;
            this.saveBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBTN.Location = new System.Drawing.Point(6, 481);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(238, 45);
            this.saveBTN.TabIndex = 11;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 640);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.TextBox passTXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox userTXT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox databaseTXT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serverTXT;
    }
}