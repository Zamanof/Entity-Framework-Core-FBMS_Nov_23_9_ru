using Microsoft.Data.SqlClient;
#region ADO
// ADO .NET - ActiveX Data Object

// MS SQL Server, Oracle, ODBC, OLE DB

// class-i dlya raboti s BD
// DbConnection
// DbCommand
// DbDataReader
// DbDataAdapter

// tipi dannix dlya raboti s BD
// DataTable
// DataSet
// ...

// Prisoyedenneniy rejim
// Otsoyedenneniy rejim
#endregion

#region ConnectionString
// Data Source=STHQ0122-01;Initial Catalog=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False
// Server=STHQ0122-01;Database=Library;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False

// Server=STHQ0122-01;Database=Library;Integrated Security=SSPI;
#endregion

#region InsertData
string connectionString = @"Server=STHQ0122-01;Database=TestAdo;User ID=admin;Password=admin;Trust Server Certificate=True;";

SqlConnection sqlConnection = null;
sqlConnection = new SqlConnection(connectionString);
string insert = @"INSERT INTO Authors(FirstName, LastName)
                  VALUES('Nadir', 'Zamanov')";
SqlCommand cmd = new();
cmd.CommandText = insert;
cmd.Connection = sqlConnection;

try
{
    sqlConnection.Open();
    cmd.ExecuteNonQuery();
}
finally
{
    if (sqlConnection != null) sqlConnection.Close();
}
#endregion
