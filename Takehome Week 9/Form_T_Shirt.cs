using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form_T_Shirt : Form
    {
        Form_Main form;
        private void button1_Click(object sender, EventArgs e)
        {
            form.Cart("PLP T-Shirt", 95000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Cart("Logo T-Shirt", 105000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.Cart("Mount T-Shirt", 90000);
        }

        public Form_T_Shirt(Form_Main form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void Form_Top_Load(object sender, EventArgs e)
        {
        }
    }
}
