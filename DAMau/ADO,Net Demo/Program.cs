using System.Data;
using System.Data.SqlClient;
using System.Configuration;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! 22");
string connectionString = "Server=DESKTOP-DQTVDBB\\SQLSERVERLOCAL;Database=DAMau;Trusted_Connection=true";
string querystring = "select TenHang from SanPhams";

using(SqlConnection connection = new SqlConnection(connectionString))
{
    SqlCommand cmd = new SqlCommand(querystring, connection);
	try
	{
		connection.Open();
		SqlDataReader reader = cmd.ExecuteReader();
		while (reader.Read())
		{
			Console.WriteLine("\t{0}", reader[0]);
		}
		connection.Close();
	}
	catch (Exception ex)
	{
		Console.WriteLine(ex.Message);
		throw;
	}
}
 
