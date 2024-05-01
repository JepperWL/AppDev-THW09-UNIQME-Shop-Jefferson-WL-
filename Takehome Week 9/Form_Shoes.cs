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
    public partial class Form_Shoes : Form
    {
        Form_Main form;
        private void button1_Click(object sender, EventArgs e)
        {
            form.Cart("White Shoe", 215000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Cart("Black White Shoe", 200000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.Cart("Black Shoe", 150000);
        }
        public Form_Shoes(Form_Main form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
