namespace Server.Models
{
    public class Passenger
    {
        private int id;
        private string ?nama;
        private string ?nik;
        private string ?tujuan;
        private string ?nomorKursi;
        private string ?jenis;
        private string ?tanggal;
        private string ?harga;
        private string ?kodeBooking;

        public int Id { get { return id; } set { id = value; } }
        public string ?Nama { get { return nama;} set { nama = value; } }
        public string ?NIK { get { return nik; } set { nik = value; } }
        public string ?Tujuan { get { return tujuan; } set { tujuan = value; } }
        public string ?NomorKursi { get { return nomorKursi; } set { nomorKursi = value; } }
        public string ?Jenis { get { return jenis; } set { jenis = value; } }
        public string ?Tanggal{ get { return tanggal; } set { tanggal = value; } }
        public string ?Harga { get { return harga; } set { harga = value; } }
        public string ?KodeBooking { get { return kodeBooking; } set { kodeBooking = value; } }

        public Passenger()
        {

        }

    }
}
