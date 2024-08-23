using Microsoft.Data.SqlClient;

string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;";

using SqlConnection conn = new SqlConnection(connectionString);
conn.Open();
SqlCommand cmd = new(@"SELECT * 
                       FROM Authors;

                       SELECT Id, Pages, Name
                       FROM Books;", conn);
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
    Console.WriteLine("\t\t");
} while (reader.NextResult());


