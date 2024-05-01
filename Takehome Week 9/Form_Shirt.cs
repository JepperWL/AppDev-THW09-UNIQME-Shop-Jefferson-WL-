using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2;

namespace TH9
{
    public partial class Form_Shirt : Form
    {
        Form_Main form;
        private void button1_Click(object sender, EventArgs e)
        {
            form.Cart("Chocolate Shirt", 77000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Cart("Prison Shirt", 85000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.Cart("Stripe Shirt", 80000);
        }

        public Form_Shirt(Form_Main form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
