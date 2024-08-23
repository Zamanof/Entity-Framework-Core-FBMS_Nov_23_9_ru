using EF_Core_01._Configuration_file;
using Microsoft.Data.SqlClient;
using System.Configuration;


string connectionString = ConfigurationManager
    .ConnectionStrings["DefaultConnectionString"]
    .ConnectionString;

List<Author> authorList = new List<Author>();

using (SqlConnection conn = new SqlConnection(connectionString))
{
    conn.Open();
    SqlCommand cmd = new(@"SELECT * FROM Authors", conn);
    SqlDataReader reader = cmd.ExecuteReader();


    while (reader.Read())
    {
        authorList.Add(new Author
        {
            Id = int.Parse(reader["Id"].ToString()!),
            FirstName = reader["FirstName"].ToString()!,
            LastName = reader["LastName"].ToString()!
        });
    }
}

authorList.ForEach(Console.WriteLine);