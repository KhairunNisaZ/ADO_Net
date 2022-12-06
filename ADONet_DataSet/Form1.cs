using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using DataPenumpang;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace ADONet_DataSet
{
    public partial class Form1 : Form
    {
        // //////////////////////////////////////////////////////////////////////////////////// //
        // Ganti Data Sourcenya disini aja yaaa biar ga ulang ulang terus gantinya --> ******   //
        // //////////////////////////////////////////////////////////////////////////////////// //

        //readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\Kuliah SMT 3\Pemrograman Berorientasi Objek\Final Project\ADO_Net\ADONet_DataSet\travelDatabase.mdf; Integrated Security = True; Connect Timeout = 30";
        readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BountyHunt\LearnCSharp\PBO_Project\ADONet_DataSet\travelDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        //readonly string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\kuliah\sem 3\pbo\nisa\ADO_Net\ADONet_DataSet\travelDatabase.mdf;Integrated Security = True; Connect Timeout = 30";

        string route = "https://localhost:7219/jendelatravel/Passengers";

        Penumpang penumpang = new Penumpang();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
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

            SqlCommand command = new SqlCommand("INSERT INTO travelData (Nama, NIK, Tujuan, NomorKursi, Jenis, Tanggal, Harga, KodeBooking) VALUES (@Nama, @NIK, @Tujuan, @NomorKursi, @Jenis, @Tanggal, @Harga, @KodeBooking)", dbConnection);

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

        private void BtnUpdate_Click(object sender, EventArgs e)
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

        private void  BtnRead_Click(object sender, EventArgs e)
        {
            var client = new RestClient();
            var req = new RestRequest(route);
            var res = client.Get<List<Penumpang>>(req);

            dataGridView1.DataSource = res;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelDatabaseDataSet2.travelData' table. You can move, or remove it, as needed.
            this.travelDataTableAdapter1.Fill(this.travelDatabaseDataSet2.travelData);
        }

        private void BtnFind_Click(object sender, EventArgs e)
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if(textKode.Text != "")
            {
                Penumpang penumpang = new Penumpang()
                {
                    KodeBooking = textKode.Text
                };
                var client = new RestClient();
                var req = new RestRequest(route + "/" + penumpang.KodeBooking);
                var res = client.Get<Penumpang>(req);
                if (res.Nama != null)
                {
                    var nama = res.Nama;
                    client.Delete(req);
                    MessageBox.Show($"Data Penumpang {nama} berhasil dihapus.");
                    req = new RestRequest(route);
                    var data = client.Get<List<Penumpang>>(req);

                    dataGridView1.DataSource = data;
                }
                else
                {
                    MessageBox.Show($"Data {penumpang.KodeBooking} tidak ditemukan.");
                }
                textKode.Clear();
            }
            else
            {
                MessageBox.Show("Harap Masukkan Kode Booking");
            }
        }
    }
}
