using System.Data;
using System.Diagnostics;
using TH9;

namespace WinFormsApp2
{
    public partial class Form_Main : Form
    {
        DataTable datatable = new DataTable();
        public void Cart(string item, int cost)
        {
            bool newitem = true;
            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                if (datatable.Rows[i][0].ToString() == item)
                {
                    int count = Convert.ToInt32(datatable.Rows[i][1].ToString());
                    count++;
                    datatable.Rows[i][1] = count;
                    datatable.Rows[i][3] = count * cost;
                    newitem = false;
                    break;
                }
            }
            if (newitem)
            {
                datatable.Rows.Add(item, 1, cost, cost);
            }

            int sub_total = 0;

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                sub_total += Convert.ToInt32(datatable.Rows[i][3].ToString());
            }
            textBox1.Text = sub_total.ToString();
            textBox2.Text = (sub_total + (sub_total / 10)).ToString();
        }

        private void CreateDataTable()
        {
            datatable.Columns.Add("Item Name");
            datatable.Columns.Add("Quantity");
            datatable.Columns.Add("Price");
            datatable.Columns.Add("Total");
        }
        private void SetData()
        {
            dataGridView1.DataSource = datatable;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
        }

        private void otherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            FormOX form = new FormOX(this);
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void topWearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bottomWearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void accessoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && datatable.Rows.Count > 0)
            {
                datatable.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }

            int stl = 0;

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                stl += Convert.ToInt32(datatable.Rows[i][3].ToString());
            }
            textBox1.Text = stl.ToString();
            textBox2.Text = (stl + (stl / 10)).ToString();
        }
        public Form_Main()
        {
            InitializeComponent();
            CreateDataTable();
            SetData();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (datatable.Rows.Count > 0)
            {
                datatable.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }

            int stl = 0;

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                stl += Convert.ToInt32(datatable.Rows[i][3].ToString());
            }
            textBox1.Text = stl.ToString();
            textBox2.Text = (stl + (stl / 10)).ToString();
        }

        private void tShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_T_Shirt form = new Form_T_Shirt(this);
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_Shirt form = new Form_Shirt(this);
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void pantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_Pants form = new Form_Pants(this);
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void longPantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_Long_Pants form = new Form_Long_Pants(this);
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void shoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_Shoes form = new Form_Shoes(this);
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void jewellriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            Form_Jewel form = new Form_Jewel(this);
            form.Dock = DockStyle.Top;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}