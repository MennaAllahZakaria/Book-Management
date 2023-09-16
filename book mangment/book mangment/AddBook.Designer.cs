namespace book_mangment
{
    partial class AddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            panel1 = new Panel();
            label8 = new Label();
            close = new Button();
            panel2 = new Panel();
            addNewBook = new Button();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            linkLabel1 = new LinkLabel();
            cover = new PictureBox();
            rate = new NumericUpDown();
            date = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            catigory = new ComboBox();
            autherName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            price = new TextBox();
            label2 = new Label();
            bookName = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cover).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rate).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 52);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.LimeGreen;
            label8.Location = new Point(349, 9);
            label8.Name = "label8";
            label8.Size = new Size(174, 31);
            label8.TabIndex = 9;
            label8.Text = "Add New Book";
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.BackgroundImage = (Image)resources.GetObject("close.BackgroundImage");
            close.BackgroundImageLayout = ImageLayout.Zoom;
            close.Location = new Point(961, -2);
            close.Name = "close";
            close.Size = new Size(60, 64);
            close.TabIndex = 4;
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(addNewBook);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 545);
            panel2.Name = "panel2";
            panel2.Size = new Size(1021, 89);
            panel2.TabIndex = 1;
            // 
            // addNewBook
            // 
            addNewBook.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            addNewBook.FlatAppearance.BorderSize = 10;
            addNewBook.Font = new Font("Segoe UI", 31.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            addNewBook.ForeColor = Color.LimeGreen;
            addNewBook.Location = new Point(442, 0);
            addNewBook.Name = "addNewBook";
            addNewBook.Size = new Size(165, 86);
            addNewBook.TabIndex = 1;
            addNewBook.Text = "ADD";
            addNewBook.UseVisualStyleBackColor = true;
            addNewBook.Click += addNewBook_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(groupBox2);
            panel3.Controls.Add(groupBox1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(1021, 493);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 454);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(linkLabel1);
            groupBox2.Controls.Add(cover);
            groupBox2.Controls.Add(rate);
            groupBox2.Controls.Add(date);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(664, 9);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(357, 464);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Additional Information";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(221, 219);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(118, 31);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Download";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // cover
            // 
            cover.Image = (Image)resources.GetObject("cover.Image");
            cover.Location = new Point(86, 261);
            cover.Name = "cover";
            cover.Size = new Size(262, 171);
            cover.SizeMode = PictureBoxSizeMode.StretchImage;
            cover.TabIndex = 6;
            cover.TabStop = false;
            // 
            // rate
            // 
            rate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            rate.Location = new Point(161, 149);
            rate.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            rate.Name = "rate";
            rate.Size = new Size(165, 38);
            rate.TabIndex = 5;
            // 
            // date
            // 
            date.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            date.Location = new Point(6, 82);
            date.Name = "date";
            date.Size = new Size(320, 27);
            date.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.LimeGreen;
            label7.Location = new Point(6, 34);
            label7.Name = "label7";
            label7.Size = new Size(150, 31);
            label7.TabIndex = 3;
            label7.Text = "Publish Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.LimeGreen;
            label6.Location = new Point(30, 151);
            label6.Name = "label6";
            label6.Size = new Size(62, 31);
            label6.TabIndex = 2;
            label6.Text = "Rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LimeGreen;
            label5.Location = new Point(17, 219);
            label5.Name = "label5";
            label5.Size = new Size(75, 31);
            label5.TabIndex = 1;
            label5.Text = "Cover";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(catigory);
            groupBox1.Controls.Add(autherName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(price);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(bookName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(322, 9);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(336, 478);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Necessary Information";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(27, 435);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 12;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(13, 328);
            label11.Name = "label11";
            label11.Size = new Size(0, 20);
            label11.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(27, 219);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(13, 102);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 9;
            // 
            // catigory
            // 
            catigory.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            catigory.FormattingEnabled = true;
            catigory.Location = new Point(13, 382);
            catigory.Name = "catigory";
            catigory.Size = new Size(286, 39);
            catigory.TabIndex = 8;
            // 
            // autherName
            // 
            autherName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            autherName.Location = new Point(6, 173);
            autherName.Name = "autherName";
            autherName.Size = new Size(279, 31);
            autherName.TabIndex = 7;
            autherName.TextChanged += autherName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.LimeGreen;
            label4.Location = new Point(13, 337);
            label4.Name = "label4";
            label4.Size = new Size(106, 31);
            label4.TabIndex = 6;
            label4.Text = "Catigory";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(6, 244);
            label3.Name = "label3";
            label3.Size = new Size(67, 31);
            label3.TabIndex = 4;
            label3.Text = "Price";
            // 
            // price
            // 
            price.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            price.Location = new Point(6, 278);
            price.Name = "price";
            price.Size = new Size(279, 31);
            price.TabIndex = 3;
            price.TextChanged += price_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(6, 139);
            label2.Name = "label2";
            label2.Size = new Size(157, 31);
            label2.TabIndex = 2;
            label2.Text = "Auther Name";
            // 
            // bookName
            // 
            bookName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            bookName.Location = new Point(13, 68);
            bookName.Name = "bookName";
            bookName.Size = new Size(279, 31);
            bookName.TabIndex = 1;
            bookName.TextChanged += bookName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(139, 31);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 634);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddBook";
            Load += AddBook_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cover).EndInit();
            ((System.ComponentModel.ISupportInitialize)rate).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button close;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private Label label5;
        public LinkLabel linkLabel1;
        public Button addNewBook;
        public TextBox autherName;
        public TextBox price;
        public TextBox bookName;
        public NumericUpDown rate;
        public DateTimePicker date;
        public PictureBox cover;
        public ComboBox catigory;
        public Label label8;
        private PictureBox pictureBox1;
        private Label label9;
        private Label label12;
        private Label label11;
        private Label label10;
    }
}