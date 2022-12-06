using Server.Models;
using System.Data.SqlClient;

namespace Server.Services
{
    public class PassengerRepos
    {
        /// <summary>
        /// this is <c>connectionString</c> as parameter to <see cref="SqlConnection"/>
        /// </summary>
        //readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BountyHunt\LearnCSharp\PBO_Project\Server\TravelData.mdf;Integrated Security=True;Connect Timeout=30";
        readonly string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\kuliah\sem 3\pbo\nisa\ADO_Net\Server\TravelData.mdf;Integrated Security = True";
        public List<Passenger> GetAllPassenger()
        {
            List<Passenger> passengers = new List<Passenger>();
            SqlConnection database = new SqlConnection(connection);
            database.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM PassengersData", database);
            SqlDataReader rows = command.ExecuteReader();

            while (rows.Read())
            {
                Passenger passenger = new Passenger();
                passenger.Id = (int)rows.GetValue(0);
                passenger.Nama = (string)rows.GetValue(1);
                passenger.NIK = (string)rows.GetValue(2);
                passenger.Tujuan = (string)rows.GetValue(3);
                passenger.NomorKursi = (string)rows.GetValue(4);
                passenger.Jenis = (string)rows.GetValue(5);
                passenger.Tanggal = (string)rows.GetValue(6);
                passenger.Harga = (string)rows.GetValue(7);

                passengers.Add(passenger);
            }
            database.Close();

            //ToDo -> Add Error Handler when database is null
            return passengers;
        }

        public Passenger GetPassengerById(int index)
        {
            Passenger passenger = new Passenger();
            SqlConnection database = new SqlConnection(connection);
            database.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM PassengersData WHERE (Id=" + index +")", database);
            SqlDataReader rows = command.ExecuteReader();

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
            }
            database.Close();
            
            //ToDo -> Add Error Handler when data{id} is null
            return passenger;
        }
    }
}
