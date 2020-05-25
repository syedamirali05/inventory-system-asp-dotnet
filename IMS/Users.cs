using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Users : Sample2
    {
        int edit = 0; // This 0 is an indication for save operation and 1 is an indication to update operation 
        int userID;
        short stat; // for assign value 1 or 0 on active and inactive user status
        retreival r = new retreival();
        public Users()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            homeScreen home = new homeScreen();
            MainClass.showWindow(home, this, MDi.ActiveForm);
        }

        private void Users_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
           
        }

        public override void addBTN_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
        }

        public override void editBTN_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBTN_Click(object sender, EventArgs e)
        {
            if (nameTXT.Text == "") { nameErrorLabel.Visible = true; } else { nameErrorLabel.Visible = false; }
            if (usernameTXT.Text == "") { usernameErrorLabel.Visible = true; } else { usernameErrorLabel.Visible = false; }
            if (passwordTXT.Text == "") { passwordErrorLabel.Visible = true; } else { passwordErrorLabel.Visible = false; }
            if (phoneTXT.Text == "") { phoneErrorLabel.Visible = true; } else { phoneErrorLabel.Visible = false; }
            if (emailTXT.Text == "") { emailErrorLabel.Visible = true; } else { emailErrorLabel.Visible = false; }
            if (statusCB.SelectedIndex == -1) { statusErrorLabel.Visible = true; } else { statusErrorLabel.Visible = false; }
            if (nameErrorLabel.Visible || usernameErrorLabel.Visible || passwordErrorLabel.Visible || phoneErrorLabel.Visible || emailErrorLabel.Visible || statusErrorLabel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory", "Error", "Error"); //Error is the type of msg 
            }
            else
            {
                if (statusCB.SelectedIndex == 0)
                {
                    stat = 1;

                }
                else if (statusCB.SelectedIndex == 1)
                {
                    stat = 0;
                }

                if (edit == 0) // Code for save operation 
                {
                    insertion i = new insertion();
                  
                   
                    i.userInsertion(nameTXT.Text, usernameTXT.Text, passwordTXT.Text, phoneTXT.Text, emailTXT.Text,stat);
                    r.showUser(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if(edit == 1) // Code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record","Question...",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        u.updateUser(userID, nameTXT.Text, usernameTXT.Text, passwordTXT.Text, phoneTXT.Text, emailTXT.Text, stat);
                        r.showUser(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
                        MainClass.disable_reset(leftPanel);
                    }
                   
                }
               
            }
        }

        public override void deleteBTN_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {
                
                    DialogResult dr = MessageBox.Show("Are you sure , you want to delete record","Question...",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        deletion d = new deletion();
                        d.delete(userID, "st_deleteUser", "@id");
                        r.showUser(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
                    }
            }
        }

        public override void searchTXT_TextChanged(object sender, EventArgs e)
        {
            if (searchTXT.Text != "")
            {
                r.showUser(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV,searchTXT.Text);
            }
            else
            {
                r.showUser(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);
            }

        }

        public override void viewBTN_Click(object sender, EventArgs e)
        {
            r.showUser(dataGridView1, userIDGV, NameGV, usernameGV, passwordGV, phoneGV, emailGV, statusGV);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                userID = Convert.ToInt32(row.Cells["userIDGV"].Value.ToString());
                nameTXT.Text = row.Cells["NameGV"].Value.ToString();
                usernameTXT.Text = row.Cells["usernameGV"].Value.ToString();
                passwordTXT.Text = row.Cells["passwordGV"].Value.ToString();
                phoneTXT.Text = row.Cells["phoneGV"].Value.ToString();
                emailTXT.Text = row.Cells["emailGV"].Value.ToString();
                statusCB.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
       

       
    }
}
