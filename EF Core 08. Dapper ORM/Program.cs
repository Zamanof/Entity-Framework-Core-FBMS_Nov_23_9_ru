using EF_Core_08._Dapper_ORM;
using Microsoft.Data.SqlClient;
// Dapper ORM

IAuthorRepository repo = null;
repo = new AuthorRepository(new SqlConnection(),
   @"Server=(localdb)\MSSQLLocalDB; Database=Authors; Integrated Security=SSPI;");


//Add one record
//var author = repo.Add(new Author() { FirstName = "Paulo", LastName = "Koelho" });
//Console.WriteLine(author);

// Delete one record
//repo.Remove(1);

// Get all authors
//var authors = repo.GetAll().ToList();
//authors.ForEach(Console.WriteLine);

//var author = new Author() {Id=2, FirstName="Nizami", LastName="Gencevi" };

//var updateAuthor = repo.Update(author);


//repo.GetAll().ToList().ForEach(Console.WriteLine);




