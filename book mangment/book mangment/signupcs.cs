using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_mangment
{
    public partial class signupcs : Form
    {
        public signupcs()
        {
            InitializeComponent();
        }


        private void name_TextChanged(object sender, EventArgs e)
        {
            req1.Text = string.Empty;

        }
        private void userName_TextChanged(object sender, EventArgs e)
        {
            req2.Text = string.Empty;

        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            req3.Text = string.Empty;
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            req4.Text = string.Empty;
        }





        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }





        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome welcome = new welcome();
            welcome.ShowDialog();
            this.Close();

        }
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || userName.Text == "" || email.Text == "" || password.Text == "" || IsValidEmail(email.Text) == false)
            {
                if (name.Text == "")
                {
                    req1.Text = "This field is required";
                }
                if (userName.Text == "")
                {
                    req2.Text = "This field is required";
                }
                if (email.Text == "")
                {
                    req3.Text = "This field is required";
                }
                if (IsValidEmail(email.Text) == false)
                {
                    req3.Text = "email format is not correct";
                }
                if (password.Text == "")
                {
                    req4.Text = "This field is required";
                }
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                SqlCommand cmd = new SqlCommand();
                connection.ConnectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\projects\\backend_projects\\first\\book mangment\\book mangment\\DBbook.mdf\";Integrated Security=True");
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT NAME FROM TUSER WHERE USERNAME=@USER";
                cmd.Parameters.AddWithValue("@USER", userName.Text);
                cmd.ExecuteNonQuery();
                var rd = cmd.ExecuteReader();


                if (rd.Read())
                {
                    MessageBox.Show("This user name is allredy exist",
               "Warning",
               MessageBoxButtons.OKCancel,
               MessageBoxIcon.Warning,
               MessageBoxDefaultButton.Button1);
                   

                }
               
                else
                {
                    cmd.Parameters.Clear();
                    connection.Close();
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO TUSER (USERNAME,NAME,PASSWORD,EMAIL) VALUES (@USER,@NAME,@PASSWORD,@EMAIL)";
                    cmd.Parameters.AddWithValue("@USER", userName.Text);
                    cmd.Parameters.AddWithValue("@NAME", name.Text);
                    cmd.Parameters.AddWithValue("@PASSWORD", password.Text);
                    cmd.Parameters.AddWithValue("@EMAIL", email.Text);


                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Form1 form = new Form1();
                    this.Hide();
                    form.ShowDialog();
                    this.Close();
                }

                ////////////////////////////////////////////////


            }

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = checkBox1.Checked ? false : true;
        }
        bool move;
        int movex, movey;
        private void signupcs_MouseDown(object sender, MouseEventArgs e)
        {

            move = true;
            movex = e.X;
            movey = e.Y;
        }

        private void signupcs_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void signupcs_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);

            }
        }
    }
}
