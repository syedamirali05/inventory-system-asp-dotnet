using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class categories : Sample2
    {
        int edit = 0; // This 0 is an indication for save operation and 1 is an indication to update operation 
        int catID;
        short stat; // for assign value 1 or 0 on active and inactive user status
        retreival r = new retreival();
        public categories()
        {
            InitializeComponent();
        }

        private void categories_Load(object sender, EventArgs e)
        {
            MainClass.disable(leftPanel);
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
            if (catTXT.Text == "") { catErrorLabel.Visible = true; } else { catErrorLabel.Visible = false; }
            if (isativeDD.SelectedIndex == -1) { isactiveErrorLabel.Visible = true; } else { isactiveErrorLabel.Visible = false; }
            if (catErrorLabel.Visible || isactiveErrorLabel.Visible)
            {
                MainClass.ShowMsg("Fields with * are mandatory", "Error", "Error"); //Error is the type of msg 
            }
            else
            {
                if (isativeDD.SelectedIndex == 0)
                {
                    stat = 1;

                }
                else if (isativeDD.SelectedIndex == 1)
                {
                    stat = 0;
                }

                if (edit == 0) // Code for save operation 
                {
                    insertion i = new insertion();


                    i.CatInsertion(catTXT.Text,stat);
                    r.showCategories(dataGridView1, catIDGV, NameGV,statusGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // Code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        u.updateCat(catID, catTXT.Text, stat);
                        r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);
                        MainClass.disable_reset(leftPanel);
                    }

                }

            }
        }

        public override void deleteBTN_Click(object sender, EventArgs e)
        {
            if (edit == 1)
            {

                DialogResult dr = MessageBox.Show("Are you sure , you want to delete record", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    deletion d = new deletion();
                    d.delete(catID, "st_deleteCategory", "@id");
                    r.showCategories(dataGridView1, catIDGV, NameGV, statusGV);
                }
            }

        }

        public override void searchTXT_TextChanged(object sender, EventArgs e)
        {
            if (searchTXT.Text != "")
            {
                r.showCategories(dataGridView1, catIDGV, NameGV, statusGV, searchTXT.Text);
             
            }
            else
            {
                r.showCategories(dataGridView1, catIDGV, NameGV,statusGV);
            }

        }

        public override void viewBTN_Click(object sender, EventArgs e)
        {
            r.showCategories(dataGridView1, catIDGV, NameGV,statusGV);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                catID = Convert.ToInt32(row.Cells["catIDGV"].Value.ToString());
                catTXT.Text = row.Cells["NameGV"].Value.ToString();
                isativeDD.SelectedItem = row.Cells["statusGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            homeScreen home = new homeScreen();
            MainClass.showWindow(home, this, MDi.ActiveForm);
        }

    }
}
