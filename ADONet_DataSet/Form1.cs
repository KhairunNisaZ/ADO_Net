using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;

namespace ADONet_DataSet
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Kuliah SMT 3\Pemrograman Berorientasi Objek\Final Project\ADO_Net\ADONet_DataSet\travelDatabase.mdf';Integrated Security=True;Connect Timeout=30");
            conn.Open();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Kuliah SMT 3\Pemrograman Berorientasi Objek\Final Project\ADO_Net\ADONet_DataSet\travelDatabase.mdf';Integrated Security=True;Connect Timeout=30";
            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO travelData (Nama, NIK, Tujuan, NomorKursi, Jenis) VALUES (@Nama, @NIK, @Tujuan, @NomorKursi, @Jenis)", dbConnection);
            command.Parameters.AddWithValue("@Nama", textNama.Text);
            command.Parameters.AddWithValue("@NIK", textNIK.Text);
            command.Parameters.AddWithValue("@Tujuan", boxTujuan.Text);
            command.Parameters.AddWithValue("@NomorKursi", boxKursi.Text);
            command.Parameters.AddWithValue("@Jenis", boxJenis.Text);
            command.ExecuteNonQuery();

            MessageBox.Show("Data Added to Box");
            textNama.Clear();
            textNIK.Clear();
            boxTujuan.ResetText();
            boxKursi.ResetText();
            boxJenis.ResetText();
        }
        public static void main(string[] args)
        {
           Application.Run(new Form1());
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            //string connectionString  @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Kuliah SMT 3\Pemrograman Berorientasi Objek\Final Project\ADO_Net\ADONet_DataSet\travelDatabase.mdf';Integrated Security=True;Connect Timeout=30";
            //SqlConnection dbConnection = new SqlConnection(connectionString);
            //dbConnection.Open();

            //SqlDataAdapter adapter = new SqlDataAdapter("select * from travelData", dbConnection);
            //DataTable table = new DataTable();
            //adapter.Fill(table);

            //dataGridView1.DataSource = table;


            //DataSet dataSet = new DataSet();
            //adapter.Fill(dataSet);
            //dataGridView1.DataSource = dataSet;


            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\Kuliah SMT 3\Pemrograman Berorientasi Objek\Final Project\ADO_Net\ADONet_DataSet\travelDatabase.mdf';Integrated Security=True;Connect Timeout=30";
            //SqlConnection dbConnection = new SqlConnection(connectionString);
            //SqlCommand command = new SqlCommand("select * from travelData", dbConnection);

            //SqlDataAdapter adapter = new SqlDataAdapter();
            //adapter.SelectCommand = command;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
