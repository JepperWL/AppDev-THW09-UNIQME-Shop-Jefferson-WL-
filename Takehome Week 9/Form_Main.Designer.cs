namespace WinFormsApp2
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            menuStrip1 = new MenuStrip();
            topWearToolStripMenuItem = new ToolStripMenuItem();
            tShirtToolStripMenuItem = new ToolStripMenuItem();
            shirtToolStripMenuItem = new ToolStripMenuItem();
            bottomWearToolStripMenuItem = new ToolStripMenuItem();
            pantsToolStripMenuItem = new ToolStripMenuItem();
            longPantsToolStripMenuItem = new ToolStripMenuItem();
            accessoriesToolStripMenuItem = new ToolStripMenuItem();
            shoesToolStripMenuItem = new ToolStripMenuItem();
            jewellriesToolStripMenuItem = new ToolStripMenuItem();
            otherToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_del = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 36);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 392);
            panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { topWearToolStripMenuItem, bottomWearToolStripMenuItem, accessoriesToolStripMenuItem, otherToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(1150, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // topWearToolStripMenuItem
            // 
            topWearToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tShirtToolStripMenuItem, shirtToolStripMenuItem });
            topWearToolStripMenuItem.Name = "topWearToolStripMenuItem";
            topWearToolStripMenuItem.Size = new Size(86, 24);
            topWearToolStripMenuItem.Text = "Top Wear";
            topWearToolStripMenuItem.Click += topWearToolStripMenuItem_Click;
            // 
            // tShirtToolStripMenuItem
            // 
            tShirtToolStripMenuItem.Name = "tShirtToolStripMenuItem";
            tShirtToolStripMenuItem.Size = new Size(224, 26);
            tShirtToolStripMenuItem.Text = "T-Shirt";
            tShirtToolStripMenuItem.Click += tShirtToolStripMenuItem_Click;
            // 
            // shirtToolStripMenuItem
            // 
            shirtToolStripMenuItem.Name = "shirtToolStripMenuItem";
            shirtToolStripMenuItem.Size = new Size(224, 26);
            shirtToolStripMenuItem.Text = "Shirt";
            shirtToolStripMenuItem.Click += shirtToolStripMenuItem_Click;
            // 
            // bottomWearToolStripMenuItem
            // 
            bottomWearToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pantsToolStripMenuItem, longPantsToolStripMenuItem });
            bottomWearToolStripMenuItem.Name = "bottomWearToolStripMenuItem";
            bottomWearToolStripMenuItem.Size = new Size(111, 24);
            bottomWearToolStripMenuItem.Text = "Bottom Wear";
            bottomWearToolStripMenuItem.Click += bottomWearToolStripMenuItem_Click;
            // 
            // pantsToolStripMenuItem
            // 
            pantsToolStripMenuItem.Name = "pantsToolStripMenuItem";
            pantsToolStripMenuItem.Size = new Size(163, 26);
            pantsToolStripMenuItem.Text = "Pants";
            pantsToolStripMenuItem.Click += pantsToolStripMenuItem_Click;
            // 
            // longPantsToolStripMenuItem
            // 
            longPantsToolStripMenuItem.Name = "longPantsToolStripMenuItem";
            longPantsToolStripMenuItem.Size = new Size(163, 26);
            longPantsToolStripMenuItem.Text = "Long Pants";
            longPantsToolStripMenuItem.Click += longPantsToolStripMenuItem_Click;
            // 
            // accessoriesToolStripMenuItem
            // 
            accessoriesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { shoesToolStripMenuItem, jewellriesToolStripMenuItem });
            accessoriesToolStripMenuItem.Name = "accessoriesToolStripMenuItem";
            accessoriesToolStripMenuItem.Size = new Size(99, 24);
            accessoriesToolStripMenuItem.Text = "Accessories";
            accessoriesToolStripMenuItem.Click += accessoriesToolStripMenuItem_Click;
            // 
            // shoesToolStripMenuItem
            // 
            shoesToolStripMenuItem.Name = "shoesToolStripMenuItem";
            shoesToolStripMenuItem.Size = new Size(155, 26);
            shoesToolStripMenuItem.Text = "Shoes";
            shoesToolStripMenuItem.Click += shoesToolStripMenuItem_Click;
            // 
            // jewellriesToolStripMenuItem
            // 
            jewellriesToolStripMenuItem.Name = "jewellriesToolStripMenuItem";
            jewellriesToolStripMenuItem.Size = new Size(155, 26);
            jewellriesToolStripMenuItem.Text = "Jewellries";
            jewellriesToolStripMenuItem.Click += jewellriesToolStripMenuItem_Click;
            // 
            // otherToolStripMenuItem
            // 
            otherToolStripMenuItem.Name = "otherToolStripMenuItem";
            otherToolStripMenuItem.Size = new Size(60, 24);
            otherToolStripMenuItem.Text = "Other";
            otherToolStripMenuItem.Click += otherToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(643, 36);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(495, 292);
            dataGridView1.TabIndex = 2;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(643, 357);
            label1.Name = "label1";
            label1.Size = new Size(126, 27);
            label1.TabIndex = 3;
            label1.Text = "Sub-Total:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(695, 398);
            label2.Name = "label2";
            label2.Size = new Size(74, 27);
            label2.TabIndex = 4;
            label2.Text = "Total:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(775, 357);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(775, 398);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(177, 27);
            textBox2.TabIndex = 6;
            // 
            // btn_del
            // 
            btn_del.Location = new Point(1053, 351);
            btn_del.Margin = new Padding(3, 4, 3, 4);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(85, 39);
            btn_del.TabIndex = 7;
            btn_del.Text = "Delete";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1150, 532);
            Controls.Add(btn_del);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Main";
            Text = "UNIQME";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem topWearToolStripMenuItem;
        private ToolStripMenuItem bottomWearToolStripMenuItem;
        private ToolStripMenuItem accessoriesToolStripMenuItem;
        private ToolStripMenuItem otherToolStripMenuItem;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btn_del;
        private ToolStripMenuItem tShirtToolStripMenuItem;
        private ToolStripMenuItem shirtToolStripMenuItem;
        private ToolStripMenuItem pantsToolStripMenuItem;
        private ToolStripMenuItem longPantsToolStripMenuItem;
        private ToolStripMenuItem shoesToolStripMenuItem;
        private ToolStripMenuItem jewellriesToolStripMenuItem;
    }
}