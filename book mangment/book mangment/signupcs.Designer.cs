namespace book_mangment
{
    partial class signupcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupcs));
            pictureBox1 = new PictureBox();
            close = new Button();
            checkBox1 = new CheckBox();
            password = new TextBox();
            name = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            userName = new TextBox();
            label4 = new Label();
            email = new TextBox();
            label5 = new Label();
            signUp = new Button();
            req1 = new Label();
            req2 = new Label();
            req3 = new Label();
            req4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-4, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(352, 652);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // close
            // 
            close.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            close.BackgroundImage = (Image)resources.GetObject("close.BackgroundImage");
            close.BackgroundImageLayout = ImageLayout.Zoom;
            close.Location = new Point(911, 3);
            close.Name = "close";
            close.Size = new Size(60, 64);
            close.TabIndex = 14;
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Image = (Image)resources.GetObject("checkBox1.Image");
            checkBox1.Location = new Point(921, 380);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 32);
            checkBox1.TabIndex = 13;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            checkBox1.CheckStateChanged += checkBox1_CheckStateChanged;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(525, 374);
            password.Name = "password";
            password.Size = new Size(383, 47);
            password.TabIndex = 11;
            password.UseSystemPasswordChar = true;
            password.TextChanged += password_TextChanged;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(525, 79);
            name.Name = "name";
            name.Size = new Size(410, 47);
            name.TabIndex = 12;
            name.TextChanged += name_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(358, 380);
            label3.Name = "label3";
            label3.Size = new Size(139, 38);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(358, 79);
            label2.Name = "label2";
            label2.Size = new Size(103, 38);
            label2.TabIndex = 9;
            label2.Text = " Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(358, 3);
            label1.Name = "label1";
            label1.Size = new Size(146, 46);
            label1.TabIndex = 10;
            label1.Text = "Sign Up";
            // 
            // userName
            // 
            userName.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userName.Location = new Point(525, 181);
            userName.Name = "userName";
            userName.Size = new Size(410, 47);
            userName.TabIndex = 16;
            userName.TextChanged += userName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(358, 187);
            label4.Name = "label4";
            label4.Size = new Size(161, 38);
            label4.TabIndex = 15;
            label4.Text = "User Name";
            // 
            // email
            // 
            email.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            email.Location = new Point(525, 278);
            email.Name = "email";
            email.Size = new Size(410, 47);
            email.TabIndex = 18;
            email.TextChanged += email_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(372, 287);
            label5.Name = "label5";
            label5.Size = new Size(89, 38);
            label5.TabIndex = 17;
            label5.Text = "Email";
            // 
            // signUp
            // 
            signUp.BackColor = Color.MediumSeaGreen;
            signUp.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            signUp.Location = new Point(562, 493);
            signUp.Name = "signUp";
            signUp.Size = new Size(179, 64);
            signUp.TabIndex = 19;
            signUp.Text = "Sign Up";
            signUp.UseVisualStyleBackColor = false;
            signUp.Click += signUp_Click;
            // 
            // req1
            // 
            req1.AutoSize = true;
            req1.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            req1.ForeColor = Color.Red;
            req1.Location = new Point(525, 129);
            req1.Name = "req1";
            req1.Size = new Size(0, 17);
            req1.TabIndex = 20;
            // 
            // req2
            // 
            req2.AutoSize = true;
            req2.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            req2.ForeColor = Color.Red;
            req2.Location = new Point(525, 231);
            req2.Name = "req2";
            req2.Size = new Size(0, 17);
            req2.TabIndex = 20;
            // 
            // req3
            // 
            req3.AutoSize = true;
            req3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            req3.ForeColor = Color.Red;
            req3.Location = new Point(525, 328);
            req3.Name = "req3";
            req3.Size = new Size(0, 17);
            req3.TabIndex = 20;
            // 
            // req4
            // 
            req4.AutoSize = true;
            req4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            req4.ForeColor = Color.Red;
            req4.Location = new Point(525, 424);
            req4.Name = "req4";
            req4.Size = new Size(0, 17);
            req4.TabIndex = 20;
            // 
            // signupcs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(972, 644);
            Controls.Add(req4);
            Controls.Add(req3);
            Controls.Add(req2);
            Controls.Add(req1);
            Controls.Add(signUp);
            Controls.Add(email);
            Controls.Add(label5);
            Controls.Add(userName);
            Controls.Add(label4);
            Controls.Add(close);
            Controls.Add(checkBox1);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "signupcs";
            Text = "signupcs";
            MouseDown += signupcs_MouseDown;
            MouseMove += signupcs_MouseMove;
            MouseUp += signupcs_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button close;
        private CheckBox checkBox1;
        private TextBox password;
        private TextBox name;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox userName;
        private Label label4;
        private TextBox email;
        private Label label5;
        private Button signUp;
        private Label req1;
        private Label req2;
        private Label req3;
        private Label req4;
    }
}