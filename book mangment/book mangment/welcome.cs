using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_mangment
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                password.UseSystemPasswordChar = true;
            }
            else
            {

            }
            password.UseSystemPasswordChar = false;

        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            if (userName.Text == "" || password.Text == "")
            {
                if (userName.Text == "")
                {
                    MessageBox.Show("User Name is required");
                }
                if (password.Text == "")
                {
                    MessageBox.Show("Password is required");
                }
            }
            else
            {
                SqlConnection connection = new SqlConnection();
                SqlCommand cmd = new SqlCommand();


                connection.ConnectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\projects\\backend_projects\\first\\book mangment\\book mangment\\DBbook.mdf\";Integrated Security=True");
                connection.Open();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT PASSWORD FROM TUSER WHERE USERNAME=@user";

                cmd.Parameters.AddWithValue("@user", userName.Text);
                var rd = cmd.ExecuteReader();
                if (rd.Read())
                {

                    if (password.Text == Convert.ToString(rd[0]))
                    {
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("User Name or Password is WRONG Please try again");

                    }
                }
                else
                {
                    MessageBox.Show("User Name or Password is WRONG Please try again");

                }


            }
        }

        private void signUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signupcs signupcs = new signupcs();
            this.Hide();
            signupcs.ShowDialog();
            this.Close();
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = checkBox1.Checked ? false : true;


        }
        bool move;
        int movex, movey;

        private void welcome_MouseDown(object sender, MouseEventArgs e)
        {

            move = true;
            movex = e.X;
            movey = e.Y;

        }

        private void welcome_MouseUp(object sender, MouseEventArgs e)
        {

            move = false;
        }

        private void welcome_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);

            }
        }
    }
}
