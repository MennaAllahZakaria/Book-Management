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
    public partial class Detailscs : Form
    {
        public int id;
        public Detailscs()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();

        }

        private void Detailscs_Load(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();


            connection.ConnectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\projects\\backend_projects\\first\\book mangment\\book mangment\\DBbook.mdf\";Integrated Security=True");
            connection.Open();
            cmd.Connection = connection;

            cmd.CommandText = "SELECT TITLE,AUTHER,PRICE,CATIGORY,DATE,RATE FROM BOOKS WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            List<String> it = new List<String>();
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                for (int i = 0; i <= 5; i++)
                {
                    it.Add(Convert.ToString(rd[i]));
                }

            }
            bookName.Text = it[0];
            autherName.Text = it[1];
            price.Text = it[2];
            catigory.Text = it[3];

            DateTime dateValue = Convert.ToDateTime(it[4]);
            labdate.Text = dateValue.Date.ToString("yyyy-MM-dd");
            rate.Text = it[5];
            cmd.Parameters.Clear();
            connection.Close();


            connection.Open();
            cmd.Connection = connection;

            cmd.CommandText = "SELECT COVER FROM BOOKS WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", id);


            byte[] img = (byte[])cmd.ExecuteScalar();

            MemoryStream ma = new MemoryStream();
            ma.Write(img);
            cover.Image = Image.FromStream(ma);
            connection.Close();

        }
        bool move;
        int movex, movey;



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            move = true;
            movex = e.X;
            movey = e.Y;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

            move = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - movex, MousePosition.Y - movey);

            }
        }
    }
}
