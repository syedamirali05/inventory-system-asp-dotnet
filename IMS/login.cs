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
    public partial class login : Sample
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnUserlogin_Click(object sender, EventArgs e)
        {
            homeScreen h = new homeScreen();
            MainClass.showWindow(h, this, MDi.ActiveForm);
        }
    }
}
