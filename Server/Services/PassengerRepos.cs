using Server.Models;
using System.Data.SqlClient;
namespace Server.Services
{
    public class PassengerRepos
    {
        
        string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\BountyHunt\LearnCSharp\Clone\PBO_Project\ADONet_DataSet\travelDatabase.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection database = new SqlConnection(connection);

    }
}
