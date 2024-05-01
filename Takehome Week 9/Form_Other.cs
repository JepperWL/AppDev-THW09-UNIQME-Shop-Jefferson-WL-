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
    public partial class FormOX : Form
    {
        Form_Main form;
        public FormOX(Form_Main form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string directory = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                directory = dialog.FileName;
                pictureBox3.ImageLocation = directory;

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                button3.Enabled = true;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                form.Cart(textBox1.Text, Convert.ToInt32(textBox2.Text.ToString()));
            }
            else
            {
                MessageBox.Show("Please fill all the data");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button3.Enabled = false;
            pictureBox3.Image = null;
        }

        private void FormOX_Load(object sender, EventArgs e)
        {

        }
    }
}
