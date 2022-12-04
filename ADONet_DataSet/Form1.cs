using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ADONet_DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lenovo\OneDrive\Documents\travelDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BountyHunt\LearnCSharp\Clone\PBO_Project\ADONet_DataSet\travelDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO travelData (Nama, NIK, Tujuan, NomorKursi, Jenis, Tanggal) VALUES (@Nama, @NIK, @Tujuan, @NomorKursi, @Jenis, @Tanggal)", dbConnection);
            command.Parameters.AddWithValue("@Nama", textNama.Text);
            command.Parameters.AddWithValue("@NIK", textNIK.Text);
            command.Parameters.AddWithValue("@Tujuan", boxTujuan.Text);
            command.Parameters.AddWithValue("@NomorKursi", boxKursi.Text);
            command.Parameters.AddWithValue("@Jenis", boxJenis.Text);
            command.Parameters.AddWithValue("@Tanggal", dateTanggal.Text);
            //command.Parameters.AddWithValue("@Harga", .Text);
            //command.Parameters.AddWithValue("@KodeBooking", .Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Data Added to Box");
            textNama.Clear();
            textNIK.Clear();
            boxTujuan.ResetText();
            boxKursi.ResetText();
            boxJenis.ResetText();
            dateTanggal.ResetText();
        }
        public static void main(string[] args)
        {
            Application.Run(new Form1());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string connectionString = @"string connectionString = @""Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BountyHunt\LearnCSharp\Clone\PBO_Project\ADONet_DataSet\travelDatabase.mdf;Integrated Security=True;Connect Timeout=30"";";
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BountyHunt\LearnCSharp\Clone\PBO_Project\ADONet_DataSet\travelDatabase.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter("SELECT * FROM travelData", connection);
            DataSet datas = new DataSet();
            connection.Open();
            dataadapter.Fill(datas, "travelData");
            connection.Close();
            dataGridView1.DataSource = datas;
            dataGridView1.DataMember = "travelData";

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDatabaseDataSet2.travelData' table. You can move, or remove it, as needed.
            this.travelDataTableAdapter1.Fill(this.travelDatabaseDataSet2.travelData);
        }
    }
}
