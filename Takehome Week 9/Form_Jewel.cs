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
    public partial class Form_Jewel : Form
    {
        Form_Main form;
        private void button1_Click(object sender, EventArgs e)
        {
            form.Cart("Charming Necklace",549000);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form.Cart("Double Necklace", 500000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form.Cart("Jewel Necklace", 599000);
        }
        public Form_Jewel(Form_Main form)
        {
            InitializeComponent();
            this.form = form;
        }
    }
}
