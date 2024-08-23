// SQL Injection
using Microsoft.Data.SqlClient;
using System.Configuration;


string connectionString = ConfigurationManager
    .ConnectionStrings["DefaultConnectionString"]
    .ConnectionString;

//using(SqlConnection connection = new SqlConnection(connectionString))
//{
//    connection.Open();
//    string id = Console.ReadLine();
//    SqlCommand cmd = new(@$"SELECT * FROM Authors WHERE Id = {id}", connection);
//    SqlDataReader reader = cmd.ExecuteReader();
//    do
//    {
//        for (int i = 0; i < reader.FieldCount; i++)
//        {
//            Console.Write($"{reader.GetName(i)}     \t\t");
//        }
//        Console.WriteLine();
//        while (reader.Read())
//        {
//            Console.WriteLine(new string('_', 50));
//            for (int i = 0; i < reader.FieldCount; i++)
//            {
//                Console.Write($"{reader[i]}     \t\t");
//            }
//            Console.WriteLine();
//        }
//    }while(reader.NextResult());
//}


using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();
    //string id = Console.ReadLine();
    //SqlParameter parameter = new();
    //parameter.ParameterName = "@id";
    //parameter.SqlDbType = System.Data.SqlDbType.Int;
    //parameter.Value = id;

    SqlCommand cmd = new(@$"SELECT * FROM Authors WHERE Id = @id", connection);
    //cmd.Parameters.Add(parameter);
    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = Console.ReadLine();
    SqlDataReader reader = cmd.ExecuteReader();
    do
    {
        for (int i = 0; i < reader.FieldCount; i++)
        {
            Console.Write($"{reader.GetName(i)}     \t\t");
        }
        Console.WriteLine();
        while (reader.Read())
        {
            Console.WriteLine(new string('_', 50));
            for (int i = 0; i < reader.FieldCount; i++)
            {
                Console.Write($"{reader[i]}     \t\t");
            }
            Console.WriteLine();
        }
    } while (reader.NextResult());
}