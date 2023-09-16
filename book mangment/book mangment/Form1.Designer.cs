namespace book_mangment
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            close = new Button();
            min = new Button();
            max = new Button();
            panel2 = new Panel();
            details = new Button();
            deleteBook = new Button();
            editCurrentBook = new Button();
            addNewBook = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(close);
            panel1.Controls.Add(min);
            panel1.Controls.Add(max);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 51);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSalmon;
            label1.Location = new Point(370, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 39);
            label1.TabIndex = 1;
            label1.Text = "BOOK SHOP";
            label1.Click += label1_Click;
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.BackgroundImage = (Image)resources.GetObject("close.BackgroundImage");
            close.BackgroundImageLayout = ImageLayout.Zoom;
            close.Location = new Point(908, -5);
            close.Name = "close";
            close.Size = new Size(60, 64);
            close.TabIndex = 0;
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // min
            // 
            min.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            min.BackgroundImage = (Image)resources.GetObject("min.BackgroundImage");
            min.BackgroundImageLayout = ImageLayout.Zoom;
            min.Location = new Point(793, -8);
            min.Name = "min";
            min.Size = new Size(63, 64);
            min.TabIndex = 0;
            min.UseVisualStyleBackColor = true;
            min.Click += min_Click;
            // 
            // max
            // 
            max.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            max.BackgroundImage = (Image)resources.GetObject("max.BackgroundImage");
            max.BackgroundImageLayout = ImageLayout.Zoom;
            max.Location = new Point(851, -10);
            max.Name = "max";
            max.Size = new Size(69, 69);
            max.TabIndex = 0;
            max.UseVisualStyleBackColor = true;
            max.Click += max_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(details);
            panel2.Controls.Add(deleteBook);
            panel2.Controls.Add(editCurrentBook);
            panel2.Controls.Add(addNewBook);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 508);
            panel2.Name = "panel2";
            panel2.Size = new Size(968, 91);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // details
            // 
            details.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            details.FlatAppearance.BorderSize = 10;
            details.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            details.ForeColor = Color.DeepSkyBlue;
            details.Location = new Point(3, 6);
            details.Name = "details";
            details.Size = new Size(214, 79);
            details.TabIndex = 0;
            details.Text = "Details";
            details.UseVisualStyleBackColor = true;
            details.Click += details_Click;
            // 
            // deleteBook
            // 
            deleteBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            deleteBook.FlatAppearance.BorderSize = 10;
            deleteBook.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            deleteBook.ForeColor = Color.Red;
            deleteBook.Location = new Point(223, 6);
            deleteBook.Name = "deleteBook";
            deleteBook.Size = new Size(222, 79);
            deleteBook.TabIndex = 0;
            deleteBook.Text = "Delete book";
            deleteBook.UseVisualStyleBackColor = true;
            deleteBook.Click += deleteBook_Click;
            // 
            // editCurrentBook
            // 
            editCurrentBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            editCurrentBook.FlatAppearance.BorderSize = 10;
            editCurrentBook.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            editCurrentBook.ForeColor = Color.Goldenrod;
            editCurrentBook.Location = new Point(451, 6);
            editCurrentBook.Name = "editCurrentBook";
            editCurrentBook.Size = new Size(259, 79);
            editCurrentBook.TabIndex = 0;
            editCurrentBook.Text = "Edit current book";
            editCurrentBook.UseVisualStyleBackColor = true;
            editCurrentBook.Click += editCurrentBook_Click;
            // 
            // addNewBook
            // 
            addNewBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addNewBook.FlatAppearance.BorderSize = 10;
            addNewBook.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addNewBook.ForeColor = Color.LimeGreen;
            addNewBook.Location = new Point(716, 6);
            addNewBook.Name = "addNewBook";
            addNewBook.Size = new Size(252, 79);
            addNewBook.TabIndex = 0;
            addNewBook.Text = "Add new book";
            addNewBook.UseVisualStyleBackColor = true;
            addNewBook.Click += addNewBook_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridView1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 51);
            panel3.Name = "panel3";
            panel3.Size = new Size(968, 457);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Wheat;
            dataGridViewCellStyle1.SelectionForeColor = Color.Maroon;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Size = new Size(968, 457);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(968, 599);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Activated += Form1_Activated;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button min;
        private Button max;
        private DataGridView dataGridView1;
        private Button addNewBook;
        private Button details;
        private Button deleteBook;
        private Button editCurrentBook;
        private Label label1;
        private Button close;
    }
}