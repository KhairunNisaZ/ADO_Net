using Server.Models;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Server.Services
{
    public class PassengerRepos
    {
        /// <summary>
        /// this is <c>connectionString</c> as parameter to <see cref="SqlConnection"/>
        /// </summary>
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BountyHunt\LearnCSharp\PBO_Project\Server\TravelData.mdf;Integrated Security=True";

        /// <summary>
        /// Get All Passenger Data
        /// </summary>
        /// <returns>
        /// <see cref="List{T}"/>
        /// 
        /// <para>
        /// <see cref="T"/> is <see cref="Passenger"/>
        /// </para>
        /// </returns>
        public List<Passenger> GetAllPassenger()
        {
            List<Passenger> passengers = new();
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();

            SqlCommand command = new("SELECT * FROM PassengersData", dbConnection);
            SqlDataReader rows = command.ExecuteReader();

            while (rows.Read())
            {
                Passenger passenger = new()
                {

                    Id = (int)rows.GetValue(0),
                    Nama = (string)rows.GetValue(1),
                    NIK = (string)rows.GetValue(2),
                    Tujuan = (string)rows.GetValue(3),
                    NomorKursi = (string)rows.GetValue(4),
                    Jenis = (string)rows.GetValue(5),
                    Tanggal = (string)rows.GetValue(6),
                    Harga = (string)rows.GetValue(7),
                    KodeBooking = (string)rows.GetValue(8)
                };

                passengers.Add(passenger);
            }
            dbConnection.Close();

            //ToDo -> Add Error Handler when database is null
            return passengers;
        }

        public Passenger GetPassengerById(int index)
        {
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();

            SqlCommand command = new("SELECT * FROM PassengersData WHERE (Id=" + index +")", dbConnection);
            SqlDataReader rows = command.ExecuteReader();

            Passenger passenger = new();
            while (rows.Read())
            {
                passenger.Id = (int)rows.GetValue(0);
                passenger.Nama = (string)rows.GetValue(1);
                passenger.NIK = (string)rows.GetValue(2);
                passenger.Tujuan = (string)rows.GetValue(3);
                passenger.NomorKursi = (string)rows.GetValue(4);
                passenger.Jenis = (string)rows.GetValue(5);
                passenger.Tanggal = (string)rows.GetValue(6);
                passenger.Harga = (string)rows.GetValue(7);
                passenger.KodeBooking = (string)rows.GetValue(8);
            }
            dbConnection.Close();
            
            //ToDo -> Add Error Handler when data{id} is null
            return passenger;
        }

        public void AddPassenger()
        {
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();

            SqlCommand command = new("INSERT INTO PassengersData (Nama, NIK, Tujuan, NomorKursi, Jenis, Tanggal, Harga, KodeBooking) VALUES (@Nama, @NIK, @Tujuan, @NomorKursi, @Jenis, @Tanggal, @Harga, @KodeBooking)", dbConnection);
            command.Parameters.AddWithValue("@Nama", "Agustioleo");
            command.Parameters.AddWithValue("@NIK", "567112310091");
            command.Parameters.AddWithValue("@Tujuan", "Papua Barat");
            command.Parameters.AddWithValue("@NomorKursi", "23");
            command.Parameters.AddWithValue("@Jenis", "Eksekutif");
            command.Parameters.AddWithValue("@Tanggal", "20 November 2022");
            command.Parameters.AddWithValue("@Harga", "Rp80.000");
            command.Parameters.AddWithValue("@KodeBooking", "SMG112312311123");
            command.ExecuteNonQuery();

            dbConnection.Close();
        }

        public void DeletePassenger(int index)
        {
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();

            SqlCommand delete = new("DELETE FROM PassengersData WHERE (Id=" + index + ")", dbConnection);
            delete.ExecuteNonQuery();

            dbConnection.Close();
        }

        /*public void UpdatePassenger(int index)
        {
            SqlConnection dbConnection = new(connection);
            dbConnection.Open();
            SqlDataAdapter adapter = new("UPDATE travelData SET Nama='Mardigu', NIK='" + textNIK.Text + "', Tujuan='" + boxTujuan.Text + "', NomorKursi='" + boxKursi.Text + "', Jenis='" + boxJenis.Text + "', Tanggal='" + dateTanggal.Text + "' WHERE KodeBooking='" + textKode.Text + "'", dbConnection);
            adapter.SelectCommand.ExecuteNonQuery();
            dbConnection.Close();
        }*/
    }
}