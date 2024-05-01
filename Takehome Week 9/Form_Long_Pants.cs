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
    public partial class Form_Long_Pants : Form
    {
        Form_Main form;
        private void button1_Click(object sender, EventArgs e)
        {
            form.Cart("Green Long Pants", 115000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Cart("White Long Pants", 110000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.Cart("Soft Long Pants", 160000);
        }
        public Form_Long_Pants(Form_Main form)
        {
            InitializeComponent();
            this.form = form;
        }
    }
}
