using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using DataPenumpang;

namespace Server.Services
{
    public class PassengerRepos
    {
        /// <summary>
        /// <c>connectionString</c> as parameter to <see cref="SqlConnection"/>
        /// </summary>
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BountyHunt\LearnCSharp\PBO_Project\Server\travelDatabase.mdf;Integrated Security=True";
        //readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kuliah SMT 3\Pemrograman Berorientasi Objek\Final Project\ADO_Net\Server\travelDatabase.mdf;Integrated Security=True";
        //readonly string connection = @"*";
        
        
        /// <summary>
        /// Get All Passenger Data
        /// </summary>
        /// <returns>
        /// <see cref="List{T}"/>
        /// 
        /// <para>
        /// <see cref="T"/> is <see cref="Penumpang"/>
        /// </para>
        /// </returns>
        public List<Penumpang> GetAllPassenger()
        {
            List<Penumpang> ListPenumpang = new();
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();

            SqlCommand command = new("SELECT * FROM dataTravel", dbConnection);
            SqlDataReader rows = command.ExecuteReader();

            while (rows.Read())
            {
                Penumpang penumpang = new()
                {

                    Id = (int)rows.GetValue(0),
                    Nama = (string)rows.GetValue(1),
                    Nik = (string)rows.GetValue(2),
                    Tujuan = (string)rows.GetValue(3),
                    Kursi = (string)rows.GetValue(4),
                    Jenis = (string)rows.GetValue(5),
                    Tanggal = (string)rows.GetValue(6),
                    Harga = (string)rows.GetValue(7),
                    KodeBooking = (string)rows.GetValue(8)
                };

                ListPenumpang.Add(penumpang);
            }
            dbConnection.Close();

            //ToDo -> Add Error Handler when database is null
            return ListPenumpang;
        }

        public Penumpang GetPassengerById(string index)
        {
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();

            SqlCommand command = new("SELECT * FROM dataTravel WHERE (KodeBooking='" + index +"')", dbConnection);
            SqlDataReader rows = command.ExecuteReader();

            Penumpang penumpang = new();
            while (rows.Read())
            {
                penumpang.Id = (int)rows.GetValue(0);
                penumpang.Nama = (string)rows.GetValue(1);
                penumpang.Nik = (string)rows.GetValue(2);
                penumpang.Tujuan = (string)rows.GetValue(3);
                penumpang.Kursi = (string)rows.GetValue(4);
                penumpang.Jenis = (string)rows.GetValue(5);
                penumpang.Tanggal = (string)rows.GetValue(6);
                penumpang.Harga = (string)rows.GetValue(7);
                penumpang.KodeBooking = (string)rows.GetValue(8);
            }
            dbConnection.Close();
            
            //ToDo -> Add Error Handler when data{id} is null
            return penumpang;
        }

        public void AddPassenger(Penumpang penumpang)
        {
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();

            
            SqlCommand command = new("INSERT INTO dataTravel (Nama, NIK, Tujuan, NomorKursi, Jenis, Tanggal, Harga, KodeBooking) VALUES (@Nama, @NIK, @Tujuan, @NomorKursi, @Jenis, @Tanggal, @Harga, @KodeBooking)", dbConnection);
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
        }

        public void DeletePassenger(string index)
        {
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();

            SqlCommand delete = new("DELETE FROM dataTravel WHERE (KodeBooking='" + index + "')", dbConnection);
            delete.ExecuteNonQuery();

            dbConnection.Close();
        }

        public void UpdatePassenger(Penumpang penumpang)
        {
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();

            SqlCommand adapter = new("UPDATE dataTravel SET Nama='" + penumpang.Nama +
                "', NIK='" + penumpang.Nik + 
                "', Tujuan='" + penumpang.Tujuan + 
                "', NomorKursi='" + penumpang.Kursi + 
                "', Jenis='" + penumpang.Jenis + 
                "', Tanggal='" + penumpang.Tanggal + 
                "', KodeBooking='" + penumpang.KodeBookingNew +
                "', Harga='" + penumpang.Harga +
                "' WHERE KodeBooking='" + penumpang.KodeBooking + "'",
                dbConnection);

            adapter.ExecuteNonQuery();
            dbConnection.Close();
        }
    }
}