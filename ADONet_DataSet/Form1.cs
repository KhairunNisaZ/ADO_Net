using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Contexts;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using DataPenumpang;
using RestSharp;

namespace ADONet_DataSet
{
    public partial class Form1 : Form
    {
        readonly string route = "https://localhost:7219/jendelatravel/Passengers";

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(textNama.Text != "" && textNIK.Text != "" && boxTujuan.Text != "" && boxKursi.Text != "" && boxJenis.Text != "")
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

                var client = new RestClient();
                var req = new RestRequest(route);
                req.AddHeader("Content-Type", "application/json");

            req.AddBody(penumpang, "application/json");
            client.Post(req);

            req = new RestRequest(route);
            var data = client.Get<List<Penumpang>>(req);

            dataGridView1.DataSource = data;
            MessageBox.Show("Data penumpang ditambahkan");
            textNama.Clear();
            textNIK.Clear();
            boxKursi.SelectedIndex = -1;
            boxJenis.SelectedIndex = -1;
            boxTujuan.SelectedIndex = -1;
            dateTanggal.ResetText();
            } else
            {
                MessageBox.Show("Harap lengkapi data");
            }
        }
        public static void main(string[] args) 
        {
            Application.Run(new Form1());
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (textNama.Text != "" && textNIK.Text != "" && boxTujuan.Text != "" && boxKursi.Text != "" && boxJenis.Text != "" && textKode.Text != ""){

            Penumpang penumpang = new Penumpang
            {
                Nama = textNama.Text,
                Nik = textNIK.Text,
                Tujuan = boxTujuan.Text,
                Kursi = boxKursi.Text,
                Jenis = boxJenis.Text,
                Tanggal = dateTanggal.Text,
                KodeBooking = textKode.Text,
            };
            penumpang.UpdatePenumpang();

            var client = new RestClient();
            var req = new RestRequest(route + "/" + penumpang.KodeBooking, Method.Put);
            req.AddBody(penumpang, "application/json");
            client.Execute(req);

            MessageBox.Show($"Data penumpang {penumpang.Nama} berhasil diganti.");
            req = new RestRequest(route);
            var data = client.Get<List<Penumpang>>(req);

            dataGridView1.DataSource = data;
            textNama.Clear();
            textNIK.Clear();
            boxKursi.SelectedIndex = -1;
            boxJenis.SelectedIndex = -1;
            boxTujuan.SelectedIndex = -1;
            dateTanggal.ResetText();
            textKode.Clear();
            }
            else
            {
                if(textKode.Text == "")
                {
                    MessageBox.Show("Data penumpang tidak ditemukan");
                }
                else
                {
                MessageBox.Show("Harap lengkapi data");
                }
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
                    if(MessageBox.Show("Apakah Anda Yakin Ingin Menghapus Data?", "Remove Row", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        var nama = res.Nama;
                        client.Delete(req);
                        MessageBox.Show($"Data Penumpang {nama} berhasil dihapus.");
                        req = new RestRequest(route);
                        var data = client.Get<List<Penumpang>>(req);

                        dataGridView1.DataSource = data;
                    }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textNama.Clear();
            textNIK.Clear();
            boxKursi.SelectedIndex = -1;
            boxJenis.SelectedIndex = -1;
            boxTujuan.SelectedIndex = -1;
            dateTanggal.ResetText();
            textKode.Clear();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximized_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }
    }
}
