using System;
using System.CodeDom;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using DataPenumpang;

namespace ADONet_DataSet
{
    public partial class Form1 : Form
    {
        // //////////////////////////////////////////////////////////////////////////////////// //
        // Ganti Data Sourcenya disini aja yaaa biar ga ulang ulang terus gantinya --> ******   //
        // //////////////////////////////////////////////////////////////////////////////////// //

        //string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Kuliah SMT 3\Pemrograman Berorientasi Objek\Final Project\ADO_Net\ADONet_DataSet\travelDatabase.mdf; Integrated Security = True; Connect Timeout = 30";
        //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BountyHunt\LearnCSharp\PBO_Project\ADONet_DataSet\travelDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\kuliah\sem 3\pbo\nisa\ADO_Net\ADONet_DataSet\travelDatabase.mdf;Integrated Security = True; Connect Timeout = 30";

        Penumpang penumpang = new Penumpang();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            penumpang.Nama = textNama.Text;
            penumpang.Nik = textNIK.Text;
            penumpang.Tujuan = boxTujuan.Text;
            penumpang.Kursi = boxKursi.Text;
            penumpang.Jenis = boxJenis.Text;
            penumpang.Tanggal = dateTanggal.Text;
            penumpang.HitungKodeBooking();
            penumpang.HitungHarga();

            SqlConnection dbConnection = new SqlConnection(connectionString);
            dbConnection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO travelData (Nama, NIK, Tujuan, NomorKursi, Jenis, Tanggal) VALUES (@Nama, @NIK, @Tujuan, @NomorKursi, @Jenis, @Tanggal)", dbConnection);

            command.Parameters.AddWithValue("@Nama", penumpang.Nama);
            command.Parameters.AddWithValue("@NIK", penumpang.Nik);
            command.Parameters.AddWithValue("@Tujuan", penumpang.Tujuan);
            command.Parameters.AddWithValue("@NomorKursi", penumpang.Kursi);
            command.Parameters.AddWithValue("@Jenis", penumpang.Jenis);
            command.Parameters.AddWithValue("@Tanggal", penumpang.Tanggal);
            command.Parameters.AddWithValue("@Harga", penumpang.Harga);
            command.Parameters.AddWithValue("@KodeBooking", penumpang.KodeBooking);
            command.ExecuteNonQuery();

            dbConnection.Close();
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
            SqlConnection dbConnection = new SqlConnection(connectionString);

            try
            {
                dbConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("UPDATE travelData SET Nama='"+textNama.Text+"', NIK='"+textNIK.Text+"', Tujuan='"+boxTujuan.Text+"', NomorKursi='"+ boxKursi.Text+"', Jenis='"+ boxJenis.Text+"', Tanggal='"+ dateTanggal.Text+ "' WHERE KodeBooking='"+textKode.Text+"'", dbConnection);
                adapter.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Update Success");
                dbConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Update Error" + ex);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM travelData", dbConnection);
            DataSet datas = new DataSet();
            dbConnection.Open();
            adapter.Fill(datas, "travelData");
            dbConnection.Close();
            dataGridView1.DataSource = datas;
            dataGridView1.DataMember = "travelData";
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDatabaseDataSet2.travelData' table. You can move, or remove it, as needed.
            this.travelDataTableAdapter1.Fill(this.travelDatabaseDataSet2.travelData);
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
           
            try
            {
                dbConnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM travelData WHERE (KodeBooking='" + textKode.Text + "')", dbConnection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    textNama.Text = reader.GetValue(1).ToString();
                    textNIK.Text = reader.GetValue(2).ToString();
                    boxTujuan.Text = reader.GetValue(3).ToString();
                    boxKursi.Text = reader.GetValue(4).ToString();
                    boxJenis.Text = reader.GetValue(5).ToString();
                    dateTanggal.Text = reader.GetValue(6).ToString();
                }
                MessageBox.Show("Search Success");
                dbConnection.Close();
            }

            catch (Exception ex) {
                MessageBox.Show("Search Error" + ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(connectionString);
            try
            {
                dbConnection.Open();
                SqlCommand delete = new SqlCommand("DELETE FROM travelData WHERE (KodeBooking='"+ textKode.Text+"')", dbConnection);
                delete.ExecuteNonQuery();
                MessageBox.Show("Delete Success");
                dbConnection.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Delete Error" + ex);
            }

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM travelData", dbConnection);
            DataSet datas = new DataSet();
            dbConnection.Open();
            adapter.Fill(datas, "travelData");
            dbConnection.Close();
            dataGridView1.DataSource = datas;
            dataGridView1.DataMember = "travelData";
        }
    }
}
