using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    class retreival
    {
        public void showUser(DataGridView gv, DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passwordGV, DataGridViewColumn phoneGV, DataGridViewColumn emailGV, DataGridViewColumn statusGV, string data = null)
        {
            SqlCommand cmd;
            try
            {
                if (data == null)
                {
                    cmd = new SqlCommand("st_getUserData", MainClass.con);
                }
                else
                {
                    cmd = new SqlCommand("st_getUserDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);
                }


                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passwordGV.DataPropertyName = dt.Columns["Password"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;


            }
            catch (Exception ex)
            {

                MainClass.ShowMsg(ex.Message, "Error in fetching...", "Error");
            }
        }

        public void showCategories(DataGridView gv, DataGridViewColumn catIDGV, DataGridViewColumn catnameGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getCategoriesDate", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                catIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                catnameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();

                gv.DataSource = dt;
            }

            catch (Exception ex)
            {

                MainClass.ShowMsg(ex.Message, "Error in loading category data...", "Error");
            }
        }


        public void getCategoriesList(string proc,ComboBox cb , string displayMember , string valueMember)
        {
            try
            {
                cb.Items.Clear();
                cb.DataSource = null;
                cb.Items.Insert(0, "Select...");
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] {0,"Select..." };
                dt.Rows.InsertAt(dr,0);
                cb.DataSource = dt;
                cb.DisplayMember = displayMember;
                cb.ValueMember = valueMember;
               

            }
            catch (Exception)
            {

            }
        }

        public void showProducts(DataGridView gv, DataGridViewColumn proIDGV, DataGridViewColumn pronameGV, DataGridViewColumn expiryGV, DataGridViewColumn priceGV, DataGridViewColumn barGV, DataGridViewColumn catGV, DataGridViewColumn catIDGV, string data = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsData", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                proIDGV.DataPropertyName = dt.Columns["Product ID"].ToString();
                pronameGV.DataPropertyName = dt.Columns["Product Name"].ToString();
                barGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                expiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                priceGV.DataPropertyName = dt.Columns["Price"].ToString();
                catGV.DataPropertyName = dt.Columns["Category"].ToString();
                catIDGV.DataPropertyName = dt.Columns["Category ID"].ToString();

                gv.DataSource = dt;
            }

            catch (Exception ex)
            {

                MainClass.ShowMsg(ex.Message, "Error in loading category data...", "Error");
            }
        }


    
    }
}
