using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace book_mangment
{
    public partial class AddBook : Form
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        public int state;
        public AddBook()
        {
            InitializeComponent();
        }



        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addNewBook_Click(object sender, EventArgs e)
        {
            if (state == -1)
            {
                /////////
                // ADD // 
                /////////
                if (bookName.Text == "" || autherName.Text == "" || price.Text == "" || catigory.Text == "")
                {
                    if (bookName.Text == "") label9.Text = "This field is required";
                    if (autherName.Text == "") label10.Text = "This field is required";
                    if (price.Text == "") label11.Text = "This field is required";
                    if (catigory.Text == "") label12.Text = "This field is required";
                }
                else
                {
                    //image
                    MemoryStream memoryStream = new MemoryStream();
                    cover.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = memoryStream.ToArray();
                    //--------------------------


                    connection.ConnectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\projects\\backend_projects\\first\\book mangment\\book mangment\\DBbook.mdf\";Integrated Security=True");
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.CommandText = "INSERT INTO BOOKS (TITLE,AUTHER,PRICE,CATIGORY,DATE,RATE,COVER) VALUES (@TITLE,@AUTHER,@PRICE,@CATIGORY,@DATE,@RATE,@COVER)";
                    cmd.Parameters.AddWithValue("@TITLE", bookName.Text);
                    cmd.Parameters.AddWithValue("@AUTHER", autherName.Text);
                    cmd.Parameters.AddWithValue("@PRICE", price.Text);
                    cmd.Parameters.AddWithValue("@CATIGORY", catigory.Text);
                    cmd.Parameters.AddWithValue("@DATE", date.Value);
                    cmd.Parameters.AddWithValue("@RATE", rate.Value);
                    cmd.Parameters.AddWithValue("@COVER", _cover);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    this.Hide();
                    Addsuccess form = new Addsuccess();
                    form.label1.Text = "BOOK ADD SUCCESSFULLY";
                    form.label1.ForeColor = Color.Green;
                    form.ShowDialog();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                ////////
                //EDIT// 
                ////////
                if (bookName.Text == "" || autherName.Text == "" || price.Text == "" || catigory.Text == "")
                {
                    if (bookName.Text == "") MessageBox.Show("Book Name Is Necessary");
                    if (autherName.Text == "") MessageBox.Show("Auther Name Is Necessary");
                    if (price.Text == "") MessageBox.Show("Price Is Necessary");
                   
                }
                else

                {


                    // image 
                    MemoryStream memoryStream = new MemoryStream();
                    cover.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    var _cover = memoryStream.ToArray();
                    //--------------------------

                    connection.ConnectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\projects\\backend_projects\\first\\book mangment\\book mangment\\DBbook.mdf\";Integrated Security=True");
                    connection.Open();
                    cmd.Connection = connection;

                    cmd.CommandText = "UPDATE BOOKS SET TITLE=@TITLE,AUTHER=@AUTHER,PRICE=@PRICE,CATIGORY=@CATIGORY,DATE=@DATE,RATE=@RATE,COVER=@COVER WHERE Id =@id";
                    cmd.Parameters.AddWithValue("@TITLE", bookName.Text);
                    cmd.Parameters.AddWithValue("@AUTHER", autherName.Text);
                    cmd.Parameters.AddWithValue("@PRICE", price.Text);
                    cmd.Parameters.AddWithValue("@CATIGORY", catigory.Text);
                    cmd.Parameters.AddWithValue("@DATE", date.Value);
                    cmd.Parameters.AddWithValue("@RATE", rate.Value);
                    cmd.Parameters.AddWithValue("@COVER", _cover);
                    cmd.Parameters.AddWithValue("@id", state);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    Addsuccess form = new Addsuccess();
                    form.label1.Text = "BOOK EDIT SUCCESSFULLY";
                    form.label1.ForeColor = Color.Yellow;
                    form.ShowDialog();
                    this.Close();
                    Form1 form1 = new Form1();
                    form1.ShowDialog();
                }
            }

        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            if (state != -1)
            {

                label1.ForeColor = Color.Goldenrod;
                label2.ForeColor = Color.Goldenrod;
                label3.ForeColor = Color.Goldenrod;
                label4.ForeColor = Color.Goldenrod;
                label5.ForeColor = Color.Goldenrod;
                label6.ForeColor = Color.Goldenrod;
                label7.ForeColor = Color.Goldenrod;
                label8.ForeColor = Color.Goldenrod;
                addNewBook.ForeColor = Color.Goldenrod;
                label8.Text = "Edit This Book";
            }
            try
            {
                // to get the catigory

                connection.ConnectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\projects\\backend_projects\\first\\book mangment\\book mangment\\DBbook.mdf\";Integrated Security=True");
                cmd.Connection = connection;
                connection.Open();
                cmd.CommandText = "SELECT CATIGORY FROM TCATIGORY";
                List<String> cat = new List<String>();
                var rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    cat.Add(rd.GetString(0));
                }
                int i = 0;
                while (i < cat.Count)
                {
                    catigory.Items.Add(cat[i++]);
                }
                catigory.Text = cat[0];
            }
            catch (Exception ex)
            {

                MessageBox.Show("There is something wrong");
            }
            finally
            {
                connection.Close();
            }


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var di = new OpenFileDialog();
            var res = di.ShowDialog();
            if (res == DialogResult.OK)
            {
                cover.Image = Image.FromFile(di.FileName);

            }
        }
        bool move;
        int movex, movey;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            movex = e.X;
            movey = e.Y;


        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);

            }
        }

        private void bookName_TextChanged(object sender, EventArgs e)
        {
            label9.Text = string.Empty;
        }

        private void autherName_TextChanged(object sender, EventArgs e)
        {
            label10.Text = string.Empty;
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            label11.Text = string.Empty;
        }
    }
}
