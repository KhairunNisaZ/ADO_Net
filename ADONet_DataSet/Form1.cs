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

public class Passanger{
    public string Nama { get { return this.Nama; } set { this.Nama = value; } }
    public string Nik { get { return this.Nik; } set { this.Nik = value; } }
    public string Tujuan { get { return this.Tujuan; } set { this.Tujuan = value; } }
    public string Kursi { get { return this.Kursi; } set { this.Kursi = value; } }
    public string Jenis { get { return this.Jenis; } set { this.Jenis = value; } }
    public string Tanggal { get { return this.Tanggal; } set { this.Tanggal = value; } }
    public string KodeBooking { get { return this.KodeBooking; } set { this.KodeBooking = value; } }
    public string Updater { get { return this.Updater; } set { this.Updater = value; } }
    public string Harga { get { return this.Harga; } set { this.Harga = value; } }

    public Passanger()
    {

    }
}

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
            Passanger passanger = new Passanger
            {
                Nama = textNama.Text,
                Nik = textNIK.Text,
                Tujuan = boxTujuan.Text,
                Kursi = boxKursi.Text,
                Jenis = boxJenis.Text,
                Tanggal = dateTanggal.Text,
                KodeBooking = textKode.Text,
                Updater = "000000",
                Harga = "Rp1000000000000"
            };
            
            var client = new RestClient();
            var req = new RestRequest(route + "/" + passanger.KodeBooking);
            req.AddHeader("Content-Type", "application/json");
            req.AddBody(passanger, "application/json");
            client.Put(req);

            MessageBox.Show($"Data penumpang {passanger.Nama} berhasil diganti.");
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

        //lengakapin biar ada message box confirm delete yaa
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
