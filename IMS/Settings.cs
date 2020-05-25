using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMS
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            string s;
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (isCB.Checked)
            {
                if (serverTXT.Text != "" && databaseTXT.Text != "")
                {
                    s = "Data Source=" + serverTXT.Text + ";Initial Catalog=" + databaseTXT.Text + ";Integrated Security=true;";
                    File.WriteAllText(path+"\\connect", s);
                    DialogResult dr = MessageBox.Show("Settings Successfully Saved !!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dr == DialogResult.OK)
                    {
                        login log = new login();
                        MainClass.showWindow(log , this , MDi.ActiveForm);
                    }

                   
                }

                else
                {
                    MessageBox.Show("Please give complete data for continue");
                }
            }
            else
            {
                if (serverTXT.Text != "" && databaseTXT.Text != "" && userTXT.Text != "" && passTXT.Text != "")
                {
                    s = "Data Source=" + serverTXT.Text + ";Initial Catalog=" + databaseTXT.Text + ";User Id="+userTXT.Text+";Password="+passTXT.Text+";";
                    File.WriteAllText(path + "\\connect", s);
                
                }
                else
                {
                    MessageBox.Show("Please give complete data for continue");
                }
            }

        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if (isCB.Checked)
            {
                userTXT.Enabled = false;
                userTXT.Text = "";
            
                passTXT.Enabled = false;
                passTXT.Text = "";
            }
            else
            {
                userTXT.Enabled = true;
                passTXT.Enabled = true;
            }
        }
    }
}
