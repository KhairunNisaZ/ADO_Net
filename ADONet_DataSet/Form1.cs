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

        readonly string route = "https://localhost:7219/jendelatravel/Passengers";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            Penumpang penumpang = new Penumpang
            {
                Nama = textNama.Text,
                Nik = textNIK.Text,
                Tujuan = boxTujuan.Text,
                Kursi = boxKursi.Text,
                Jenis = boxJenis.Text,
                Tanggal = dateTanggal.Text
            };
            penumpang.HitungKodeBooking();
            penumpang.HitungHarga();

            MessageBox.Show(penumpang.Nama.ToString());
            var client = new RestClient();
            var req = new RestRequest(route);
            
            req.AddHeader("Content-Type", "application/json");
            req.AddBody(penumpang, "application/json");
            client.Post(req);

            req = new RestRequest(route);
            var data = client.Get<List<Penumpang>>(req);

            dataGridView1.DataSource = data;
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
            Penumpang penumpang = new Penumpang()
            {
                Nama = textNama.Text,
                Nik = textNIK.Text,
                Tujuan = boxTujuan.Text,
                Kursi = boxKursi.Text,
                Jenis = boxJenis.Text,
                Tanggal = dateTanggal.Text,
                KodeBooking = textKode.Text
            };
            var client = new RestClient();
            var req = new RestRequest(route + "/" + penumpang.KodeBooking);
            req.AddHeader("Content-Type", "application/json");
            req.AddBody(penumpang, "application/json");
            client.Put(req);

            MessageBox.Show($"Data penumpang {penumpang.Nama} berhasil diganti.");
            textNama.Clear();
            textNIK.Clear();
            boxTujuan.ResetText();
            boxKursi.ResetText();
            boxJenis.ResetText();
            dateTanggal.ResetText();
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
            textNama.Clear();
            textNIK.Clear();
            boxTujuan.ResetText();
            boxKursi.ResetText();
            boxJenis.ResetText();
            dateTanggal.ResetText();
            // TODO: This line of code loads data into the 'travelDatabaseDataSet2.travelData' table. You can move, or remove it, as needed.
            //this.travelDataTableAdapter1.Fill(this.travelDatabaseDataSet2.travelData);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (textKode.Text != "")
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
                    textNama.Text = res.Nama;
                    textNIK.Text = res.Nik;
                    boxTujuan.Text = res.Tujuan;
                    boxKursi.Text = res.Kursi;
                    boxJenis.Text = res.Jenis;
                    dateTanggal.Text = res.Tanggal;
                }
                else
                {
                    MessageBox.Show($"Data penumpang {penumpang.KodeBooking} tidak ditemukan.");
                }
            }
            else
            {
                MessageBox.Show("Harap Masukkan Kode Booking");
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
