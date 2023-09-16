using System.Data;

using System.Data.SqlClient;
using static System.Windows.Forms.AxHost;
using System.Diagnostics;

namespace book_mangment
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            welcome welcome = new welcome();
            welcome.ShowDialog();
            this.Close();
        }

        private void max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

        private void Form1_Activated(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();


            connection.ConnectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\projects\\backend_projects\\first\\book mangment\\book mangment\\DBbook.mdf\";Integrated Security=True");
            var sq = "SELECT ID,TITLE,AUTHER,PRICE,CATIGORY FROM BOOKS";
            da = new SqlDataAdapter(sq, connection);
            connection.Open();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void editCurrentBook_Click(object sender, EventArgs e)
        {

            AddBook add = new AddBook();
            add.addNewBook.Text = "EDIT";

            add.state = (int)dataGridView1.CurrentRow.Cells[0].Value;

            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();


            connection.ConnectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\projects\\backend_projects\\first\\book mangment\\book mangment\\DBbook.mdf\";Integrated Security=True");
            connection.Open();
            cmd.Connection = connection;

            cmd.CommandText = "SELECT TITLE,AUTHER,PRICE,CATIGORY,DATE,RATE,COVER FROM BOOKS WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", (int)dataGridView1.CurrentRow.Cells[0].Value);
            List<String> it = new List<String>();
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                for (int i = 0; i <= 5; i++)
                {
                    it.Add(Convert.ToString(rd[i]));
                }
                add.rate.Value = Convert.ToDecimal(rd[5]);
            }
            add.bookName.Text = it[0];
            add.autherName.Text = it[1];
            add.price.Text = it[2];
            add.catigory.Text = it[3];
            add.date.Value = Convert.ToDateTime(it[4]);
            add.rate.Value = Convert.ToDecimal(it[5]);
            cmd.Parameters.Clear();
            connection.Close();


            connection.Open();
            cmd.Connection = connection;

            cmd.CommandText = "SELECT COVER FROM BOOKS WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", (int)dataGridView1.CurrentRow.Cells[0].Value);


            byte[] img = (byte[])cmd.ExecuteScalar();

            MemoryStream ma = new MemoryStream();
            ma.Write(img);
            add.cover.Image = Image.FromStream(ma);
            connection.Close();
            this.Hide();
            add.ShowDialog();
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void details_Click(object sender, EventArgs e)
        {
            this.Hide();
            Detailscs detailscs = new Detailscs();
            detailscs.id = (int)dataGridView1.CurrentRow.Cells[0].Value;

            detailscs.ShowDialog();
            this.Close();
        }

        private void deleteBook_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection();
            SqlCommand cmd = new SqlCommand();


            connection.ConnectionString = ("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\projects\\backend_projects\\first\\book mangment\\book mangment\\DBbook.mdf\";Integrated Security=True");
            connection.Open();
            cmd.Connection = connection;
            cmd.CommandText = "DELETE FROM BOOKS WHERE Id=@id";
            cmd.Parameters.AddWithValue("@id", (int)dataGridView1.CurrentRow.Cells[0].Value);
            cmd.ExecuteNonQuery();
            connection.Close();

            Addsuccess ad = new Addsuccess();
            ad.label1.Text = "DELETED";
            ad.label1.ForeColor = Color.Red;
            ad.ShowDialog();

        }

        private void addNewBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBook add = new AddBook();
            add.addNewBook.Text = "ADD";
            add.state = -1;
            add.ShowDialog();
            this.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}