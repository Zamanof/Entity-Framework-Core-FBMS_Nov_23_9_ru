using Microsoft.Data.SqlClient;

string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;";

#region Read Data
//SqlConnection connection = new SqlConnection(connectionString);
//SqlDataReader reader = null;
//SqlCommand cmd = null;

//try
//{
//	connection.Open();
//	cmd = new(@"SELECT * FROM Authors");
//	cmd.Connection = connection;
//	reader = cmd.ExecuteReader();
//	while (reader.Read())
//	{
//		Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
//    }
//}
//finally
//{
//	if (reader != null) reader.Close();
//	if(connection != null) connection.Close();	
//}

//using(SqlConnection conn = new SqlConnection(connectionString))
//{
//    conn.Open();
//    SqlCommand cmd = new(@"SELECT * FROM Authors", conn);
//    SqlDataReader reader = cmd.ExecuteReader();
//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader[0]}. {reader[1]} {reader[2]}");
//    }
//}

//using (SqlConnection conn = new SqlConnection(connectionString))
//{
//    conn.Open();
//    SqlCommand cmd = new(@"SELECT * FROM Authors", conn);
//    SqlDataReader reader = cmd.ExecuteReader();
//    while (reader.Read())
//    {
//        Console.WriteLine($"{reader["Id"]}. {reader["FirstName"]} {reader["LastName"]}");
//    }
//}

using (SqlConnection conn = new SqlConnection(connectionString))
{
    conn.Open();
    SqlCommand cmd = new(@"SELECT * FROM Authors", conn);
    SqlDataReader reader = cmd.ExecuteReader();


    for (int i = 0; i < reader.FieldCount; i++)
    {
        Console.Write($"{reader.GetName(i)}     \t\t");
    }
    Console.WriteLine();
    while (reader.Read())
    {
        Console.WriteLine(new string('_', 50));
        for (int i = 0;i < reader.FieldCount;i++)
        {
            Console.Write($"{reader[i]}     \t\t");
        }
        Console.WriteLine();
    }
}

#endregion
