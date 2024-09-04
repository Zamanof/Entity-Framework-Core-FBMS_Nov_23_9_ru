// SQL Server datatypes VS C# datatypes
// https://learn.microsoft.com/en-us/dotnet/framework/data/adonet/sql-server-data-type-mappings
/*
    SQL                     C#

    int                     int  (Int32)
    bigint                  long (Int64)
    smallint                short(Int16)
    tinyint                 byte (Byte)

    bit                     bool (Boolean)

    decimal                 decimal (Decimal) 
    numeric                 decimal (Decimal)

    money                   decimal (Decimal)
    smallmoney              decimal (Decimal)

    float                   double  (Double)                 
    real                    float   (Single)

    date                    DateTime
    datetime                DateTime
    datetime2               DateTime
    smalldatetime           DateTime
    time                    TimeSpan
    datetimeoffset          DateTimeOffset

    char                    string (String)
    varchar                 string (String)
    text                    string (String)
    nchar                   string (String)
    nvarchar                string (String)
    ntext                   string (String)

    binary                  Byte[]
    varbinary               Byte[]
    image                   Byte[]

    uniqueidentifier        Guid 
*/

Console.WriteLine();