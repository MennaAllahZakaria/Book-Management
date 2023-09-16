namespace book_mangment
{
    partial class Detailscs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detailscs));
            panel1 = new Panel();
            label2 = new Label();
            close = new Button();
            panel3 = new Panel();
            details = new Button();
            labdate = new Label();
            pictureBox1 = new PictureBox();
            cover = new PictureBox();
            label13 = new Label();
            label12 = new Label();
            rate = new Label();
            label10 = new Label();
            catigory = new Label();
            label8 = new Label();
            price = new Label();
            label6 = new Label();
            autherName = new Label();
            label4 = new Label();
            bookName = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cover).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MintCream;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(close);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1022, 61);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(455, 9);
            label2.Name = "label2";
            label2.Size = new Size(224, 46);
            label2.TabIndex = 15;
            label2.Text = "Book Details";
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.BackgroundImage = (Image)resources.GetObject("close.BackgroundImage");
            close.BackgroundImageLayout = ImageLayout.Zoom;
            close.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            close.ForeColor = Color.FromArgb(128, 64, 0);
            close.Location = new Point(946, -11);
            close.Name = "close";
            close.Size = new Size(76, 81);
            close.TabIndex = 5;
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MintCream;
            panel3.Controls.Add(details);
            panel3.Controls.Add(labdate);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(cover);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(rate);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(catigory);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(price);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(autherName);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(bookName);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 61);
            panel3.Name = "panel3";
            panel3.Size = new Size(1022, 553);
            panel3.TabIndex = 2;
            // 
            // details
            // 
            details.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            details.BackColor = Color.MediumAquamarine;
            details.FlatAppearance.BorderSize = 10;
            details.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            details.ForeColor = Color.DarkSlateGray;
            details.Location = new Point(528, 481);
            details.Name = "details";
            details.Size = new Size(150, 60);
            details.TabIndex = 1;
            details.Text = "OK";
            details.UseVisualStyleBackColor = false;
            details.Click += details_Click;
            // 
            // labdate
            // 
            labdate.AutoSize = true;
            labdate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labdate.ForeColor = Color.RosyBrown;
            labdate.Location = new Point(509, 395);
            labdate.Name = "labdate";
            labdate.Size = new Size(169, 38);
            labdate.TabIndex = 15;
            labdate.Text = "...................";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightYellow;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-20, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 550);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // cover
            // 
            cover.Location = new Point(705, 142);
            cover.Name = "cover";
            cover.Size = new Size(305, 291);
            cover.SizeMode = PictureBoxSizeMode.Zoom;
            cover.TabIndex = 13;
            cover.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.ForeColor = Color.RosyBrown;
            label13.Location = new Point(705, 61);
            label13.Name = "label13";
            label13.Size = new Size(92, 38);
            label13.TabIndex = 12;
            label13.Text = "Cover";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label12.ForeColor = Color.RosyBrown;
            label12.Location = new Point(378, 395);
            label12.Name = "label12";
            label12.Size = new Size(89, 38);
            label12.TabIndex = 10;
            label12.Text = " Date";
            // 
            // rate
            // 
            rate.AutoSize = true;
            rate.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            rate.ForeColor = Color.RosyBrown;
            rate.Location = new Point(510, 314);
            rate.Name = "rate";
            rate.Size = new Size(169, 38);
            rate.TabIndex = 9;
            rate.Text = "...................";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.RosyBrown;
            label10.Location = new Point(378, 314);
            label10.Name = "label10";
            label10.Size = new Size(78, 38);
            label10.TabIndex = 8;
            label10.Text = "Rate";
            // 
            // catigory
            // 
            catigory.AutoSize = true;
            catigory.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            catigory.ForeColor = Color.RosyBrown;
            catigory.Location = new Point(510, 237);
            catigory.Name = "catigory";
            catigory.Size = new Size(169, 38);
            catigory.TabIndex = 7;
            catigory.Text = "...................";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.RosyBrown;
            label8.Location = new Point(373, 237);
            label8.Name = "label8";
            label8.Size = new Size(131, 38);
            label8.TabIndex = 6;
            label8.Text = "Catigory";
            // 
            // price
            // 
            price.AutoSize = true;
            price.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            price.ForeColor = Color.RosyBrown;
            price.Location = new Point(509, 170);
            price.Name = "price";
            price.Size = new Size(169, 38);
            price.TabIndex = 5;
            price.Text = "...................";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.RosyBrown;
            label6.Location = new Point(373, 170);
            label6.Name = "label6";
            label6.Size = new Size(83, 38);
            label6.TabIndex = 4;
            label6.Text = "Price";
            // 
            // autherName
            // 
            autherName.AutoSize = true;
            autherName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            autherName.ForeColor = Color.RosyBrown;
            autherName.Location = new Point(509, 95);
            autherName.Name = "autherName";
            autherName.Size = new Size(169, 38);
            autherName.TabIndex = 3;
            autherName.Text = "...................";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.RosyBrown;
            label4.Location = new Point(373, 95);
            label4.Name = "label4";
            label4.Size = new Size(108, 38);
            label4.TabIndex = 2;
            label4.Text = "Auther";
            // 
            // bookName
            // 
            bookName.AutoSize = true;
            bookName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            bookName.ForeColor = Color.RosyBrown;
            bookName.Location = new Point(510, 35);
            bookName.Name = "bookName";
            bookName.Size = new Size(169, 38);
            bookName.TabIndex = 1;
            bookName.Text = "...................";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.RosyBrown;
            label1.Location = new Point(373, 35);
            label1.Name = "label1";
            label1.Size = new Size(77, 38);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // Detailscs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 614);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Detailscs";
            Load += Detailscs_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cover).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Button close;
        private Label label1;
        private DateTimePicker date;
        private PictureBox cover;
        private Label label13;
        private Label label12;
        private Label rate;
        private Label label10;
        private Label catigory;
        private Label label8;
        private Label price;
        private Label label6;
        private Label autherName;
        private Label label4;
        private Label bookName;
        private Label label2;
        private Label labdate;
        private PictureBox pictureBox1;
        private Button details;
    }
}