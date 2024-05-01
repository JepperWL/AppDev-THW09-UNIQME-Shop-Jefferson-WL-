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
    public partial class Form_Pants : Form
    {
        Form_Main form;
        private void button1_Click(object sender, EventArgs e)
        {
            form.Cart("Blue Pants", 85000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Cart("Tan Pants", 100000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.Cart("Pink Pants", 120000);
        }

        public Form_Pants(Form_Main form)
        {
            InitializeComponent();
            this.form = form;
        }
    }
}
