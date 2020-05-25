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
    public partial class products : Sample2
    {
        int edit = 0; // This 0 is an indication for save operation and 1 is an indication to update operation 
        int prodID;
      
        retreival r = new retreival();
        public products()
        {
            InitializeComponent();
        }

        private void products_Load(object sender, EventArgs e)
        {
            MainClass.disable_reset(leftPanel);
        }
        public override void addBTN_Click(object sender, EventArgs e)
        {
            MainClass.enable_reset(leftPanel);
            edit = 0;
            r.getCategoriesList("st_getCategoriesList", categoryCB,"Category","ID");
           
        }

        public override void editBTN_Click(object sender, EventArgs e)
        {
            edit = 1;
            MainClass.enable(leftPanel);
        }

        public override void saveBTN_Click(object sender, EventArgs e)
        {
            if (proTXT.Text == "") { proNameErrorLabel.Visible = true; } else { proNameErrorLabel.Visible = false; }
            if (barcodeTXT.Text == "") { barcodeErrorLabel.Visible = true; } else { barcodeErrorLabel.Visible = false; }
            if (expiryPicker.Value < DateTime.Now) { proExpiryErrorLabel.Visible = true; invalidDateErrorLabel.Visible = true; } else { proExpiryErrorLabel.Visible = false; }
            if (expiryPicker.Value.Date == DateTime.Now.Date) { proExpiryErrorLabel.Visible = false; }
            if (priceTXT.Text == "") { proPriceErrorLabel.Visible = true; } else { proPriceErrorLabel.Visible = false; }
            if (categoryCB.SelectedIndex == -1 || categoryCB.SelectedIndex == 0) { cateErrorLabel.Visible = true; } else { cateErrorLabel.Visible = false; }
         
            if (proNameErrorLabel.Visible || cateErrorLabel.Visible || barcodeErrorLabel.Visible || proPriceErrorLabel.Visible || proExpiryErrorLabel.Visible )
            {
                MainClass.ShowMsg("Fields with * are mandatory", "Error", "Error"); //Error is the type of msg 
            }
            else
            {
                if (edit == 0) // Code for save operation 
                {
                    insertion i = new insertion();

                    if (expiryPicker.Value == DateTime.Now) {
                        i.productInsertion(proTXT.Text, barcodeTXT.Text, Convert.ToSingle(priceTXT.Text), null, Convert.ToInt32(categoryCB.SelectedValue));
                    }
                    else
                    {
                        i.productInsertion(proTXT.Text, barcodeTXT.Text, Convert.ToSingle(priceTXT.Text), expiryPicker.Value, Convert.ToInt32(categoryCB.SelectedValue));

                    }
                r.showProducts(dataGridView1, proIDGV, proGV, expiryGV, priceGV, barcodeGV, catGV, catIDGV);
                    MainClass.disable_reset(leftPanel);
                }
                else if (edit == 1) // Code for update operation
                {
                    DialogResult dr = MessageBox.Show("Are you sure , you want to update record", "Question...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        updation u = new updation();
                        if (expiryPicker.Value == DateTime.Now)
                        {
                            u.updateProduct(prodID, proTXT.Text, barcodeTXT.Text, Convert.ToSingle(priceTXT.Text), null, Convert.ToInt32(categoryCB.SelectedValue));

                        }

                        else {
                            u.updateProduct(prodID, proTXT.Text, barcodeTXT.Text, Convert.ToSingle(priceTXT.Text), expiryPicker.Value, Convert.ToInt32(categoryCB.SelectedValue));

                        }
                       r.showProducts(dataGridView1, proIDGV, proGV, barcodeGV, expiryGV, priceGV, catGV, catIDGV);
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
                    d.delete(prodID, "st_productsDelete", "@proID");               
                    r.showProducts(dataGridView1, proIDGV, proGV, barcodeGV, expiryGV, priceGV, catGV, catIDGV);
                }
            }
        }

        public override void searchTXT_TextChanged(object sender, EventArgs e)
        {

        }

        public override void viewBTN_Click(object sender, EventArgs e)
        {
           r.showProducts(dataGridView1,proIDGV, proGV, barcodeGV, expiryGV, priceGV, catGV, catIDGV);
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            homeScreen home = new homeScreen();
            MainClass.showWindow(home, this, MDi.ActiveForm);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                prodID = Convert.ToInt32(row.Cells["proIDGV"].Value.ToString());
                proTXT.Text = row.Cells["proGV"].Value.ToString();
                barcodeTXT.Text = row.Cells["barcodeGV"].Value.ToString();
                expiryPicker.Value = Convert.ToDateTime(row.Cells["expiryGV"].Value.ToString());
                priceTXT.Text = row.Cells["priceGV"].Value.ToString();
                categoryCB.SelectedValue = row.Cells["catGV"].Value.ToString();
                MainClass.disable(leftPanel);
            }
        }
    }
}
