namespace book_mangment
{
    partial class welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcome));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            userName = new TextBox();
            password = new TextBox();
            logIn = new Button();
            label4 = new Label();
            signUp = new LinkLabel();
            checkBox1 = new CheckBox();
            close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 628);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(410, 19);
            label1.Name = "label1";
            label1.Size = new Size(120, 46);
            label1.TabIndex = 1;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(410, 123);
            label2.Name = "label2";
            label2.Size = new Size(161, 38);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(410, 286);
            label3.Name = "label3";
            label3.Size = new Size(139, 38);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // userName
            // 
            userName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userName.Location = new Point(410, 185);
            userName.Name = "userName";
            userName.Size = new Size(410, 47);
            userName.TabIndex = 2;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(410, 360);
            password.Name = "password";
            password.Size = new Size(410, 47);
            password.TabIndex = 2;
            password.UseSystemPasswordChar = true;
            // 
            // logIn
            // 
            logIn.BackColor = Color.MediumSeaGreen;
            logIn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            logIn.Location = new Point(420, 459);
            logIn.Name = "logIn";
            logIn.Size = new Size(117, 42);
            logIn.TabIndex = 3;
            logIn.Text = "log in";
            logIn.UseVisualStyleBackColor = false;
            logIn.Click += logIn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(588, 465);
            label4.Name = "label4";
            label4.Size = new Size(126, 31);
            label4.TabIndex = 4;
            label4.Text = "New User?";
            // 
            // signUp
            // 
            signUp.AutoSize = true;
            signUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            signUp.LinkColor = Color.FromArgb(0, 192, 0);
            signUp.Location = new Point(710, 465);
            signUp.Name = "signUp";
            signUp.Size = new Size(99, 31);
            signUp.TabIndex = 5;
            signUp.TabStop = true;
            signUp.Text = "Sign Up";
            signUp.LinkClicked += signUp_LinkClicked;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Image = (Image)resources.GetObject("checkBox1.Image");
            checkBox1.Location = new Point(826, 369);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 32);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.BackgroundImage = (Image)resources.GetObject("close.BackgroundImage");
            close.BackgroundImageLayout = ImageLayout.Zoom;
            close.Location = new Point(979, -3);
            close.Name = "close";
            close.Size = new Size(60, 64);
            close.TabIndex = 7;
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1042, 621);
            Controls.Add(close);
            Controls.Add(checkBox1);
            Controls.Add(signUp);
            Controls.Add(label4);
            Controls.Add(logIn);
            Controls.Add(password);
            Controls.Add(userName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "welcome";
            Text = "welcome";
            MouseDown += welcome_MouseDown;
            MouseMove += welcome_MouseMove;
            MouseUp += welcome_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox userName;
        private TextBox password;
        private Button logIn;
        private Label label4;
        private LinkLabel signUp;
        private CheckBox checkBox1;
        private Button close;
    }
}