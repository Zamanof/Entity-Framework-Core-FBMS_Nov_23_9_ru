// Dapper methods

using Dapper;
using EF_Core_09._Dapper_methods._Relationships;
using Microsoft.Data.SqlClient;
using System.Data;

SqlConnection db = new(@"Server=(localdb)\MSSQLLocalDB;Database=Library;Integrated Security=SSPI;");
#region ExecuteScalar
//var result = db.ExecuteScalar<int>("SELECT COUNT(*) FROM Books");
//Console.WriteLine(result);
//Console.WriteLine(db.ExecuteScalar<float>("SELECT AVG(Pages) FROM Books"));

#endregion

#region Single Row Query QueryFirst, QueryFirstOrDefault, QuerySingle, QuerySingleOrDefault
//var book = db.QueryFirstOrDefault<Book>(@"SELECT * FROM Books WHERE Name LIKE @Name",
//new
//{
//    @Name = "%Visual%"
//});

//Console.WriteLine(book);

//var book1 = db.QuerySingleOrDefault<Book>(@"SELECT * FROM Books WHERE Name LIKE @Name",
//new
//{
//    @Name = "%Data%"
//});
//Console.WriteLine(book1);
#endregion

#region Query
//var books = db.Query<Book>("SELECT * FROM Books").ToList();

//books.ForEach(Console.WriteLine);
#endregion

#region QueryMultiply, Read, ReadFirstOrDefault, ReadSingle, ReadSingleOrDefault
//var sql = @"SELECT * FROM Authors WHERE FirstName=@FirstName;
//SELECT * FROM Books WHERE Id<@Id;";
//var results = db.QueryMultiple(sql, new { @Firstname = "Mark", @Id = 3 });
//var authors = results.Read<Author>().ToList();
//var books = results.Read<Book>().ToList();
//foreach (var author in authors)
//{
//    Console.WriteLine(author);
//}
//Console.WriteLine();

//foreach (var book in books)
//{
//    Console.WriteLine(book);
//}

//Console.WriteLine(results.ReadFirstOrDefault());
//Console.WriteLine(results.ReadFirstOrDefault());


#endregion

#region SpecificColumns
//var sql1 = "SELECT Id, FirstName FROM Authors";
//var authors = db.Query<Author>(sql1).ToList();
//authors.ForEach(Console.WriteLine);
#endregion

#region OneToMany
//var sql2 = @"SELECT *
//FROM Students AS S
//JOIN Groups AS G ON S.Id_Group = G.Id;";
//var results = db.Query<Student, Group, Student>(sql2, 
//(s, g)=>
//{
//    s.Group = g;
//    return s;
//}).ToList();
//results.ForEach(Console.WriteLine);

//var results2 = db.Query<Student, Group, Group>(sql2,
//(s, g) =>
//{
//    g.Students.Add(s);
//    return g;
//}).ToList();

//foreach(var group  in results2)
//{
//    Console.WriteLine(group.Name);
//    foreach(var student in group.Students.ToList())
//    {
//        Console.WriteLine($"    {student.FirstName} {student.LastName}"); 
//    }
//}
#endregion

#region Many To Many
//SqlConnection connection = new(@"Server=(localdb)\MSSQLLocalDB;Database=ManyToMany;Integrated Security=SSPI;");
//var sql = @"SELECT *
//FROM SocialNetworks AS SN
//JOIN SocialNetworkUser AS SNU
//ON SN.Id = SNU.SocialNetworksId
//JOIN Users AS U
//ON U.Id = SNU.UsersId";

//var results = connection.Query<SocialNetwork, User, SocialNetwork>(sql,
//    (sn, u) =>
//    {
//        sn.Users.Add(u);
//        return sn;
//    });

//foreach (var sn in results)
//{
//    Console.WriteLine(sn.Name);
//    foreach (var u in sn.Users)
//    {
//        Console.WriteLine($"    {u}");
//    }
//}
#endregion

