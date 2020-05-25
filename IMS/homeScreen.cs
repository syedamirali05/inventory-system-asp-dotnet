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
    public partial class homeScreen : Sample
    {
        public homeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users u = new Users();
            MainClass.showWindow(u, this, MDi.ActiveForm);
        }

        private void catBTN_Click(object sender, EventArgs e)
        {
            categories c = new categories();
            MainClass.showWindow(c, this, MDi.ActiveForm);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            products p = new products();
            MainClass.showWindow(p, this, MDi.ActiveForm);
        }
    }
}
