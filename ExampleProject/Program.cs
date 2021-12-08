using System.Data.SqlClient;

using var connection = new SqlConnection("Data Source=database; User ID=SA;Password=MyVerySecurePassword$123");
connection.Open();