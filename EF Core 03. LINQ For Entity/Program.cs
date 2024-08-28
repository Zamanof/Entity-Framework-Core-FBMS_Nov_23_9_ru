using EF_Core_03._LINQ_For_Entity;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;
// LINQ to Entities


using LibraryContext db = new();

//var authors = (from author in db.Authors
//               where author.Id > 3
//               select author).ToList();

//authors.ForEach(Console.WriteLine);

#region Where
//db.Authors
//    .Where(a => a.Id > 3 && a.Id < 7)
//    .ToList()
//    .ForEach(Console.WriteLine);
#endregion

#region EF.Functions.Like()
//db.Authors
//    .Where(a => a.LastName.EndsWith("ov"))
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Authors
//    .Where(a => EF.Functions.Like(a.LastName, "%ov"))
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Authors
//    .Where(a => EF.Functions.Like(a.LastName, "[^M]%ov"))
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Authors
//    .Where(a => EF.Functions.Like(a.FirstName, "[A-M]%"))
//    .ToList()
//    .ForEach(Console.WriteLine);

//db.Authors
//    .Where(a => EF.Functions.Like(a.FirstName, "%a%a%"))
//    .ToList()
//    .ForEach(Console.WriteLine);

#endregion

#region Find, First, FirstOrDefault, Single, SingleOrDefault
//var author = db.Authors.Find(3);
//Console.WriteLine(author);

//var author1 = db.Authors.FirstOrDefault(a => a.FirstName == "Olga");
//if (author1 is not null) Console.WriteLine(author1);
//else Console.WriteLine("Author not found!");


//var author2 = db.Authors.SingleOrDefault(a => a.FirstName == "Olga");
//if (author2 is not null) Console.WriteLine(author2);
//else Console.WriteLine("Author not found!");
#endregion

#region All, Any
//Console.WriteLine(db.Authors.All(a=> a.FirstName.Length > 3));
//Console.WriteLine(db.Authors.Any(a=> a.FirstName == "Nadir"));
#endregion

#region Select
//var authors = db.Authors.Select(a => new
//{
//    Id = a.Id,
//    FullName = a.FirstName + " " + a.LastName,
//    Books = a.Books
//}
//    );

//foreach ( var author in authors )
//{
//    Console.WriteLine($"{author.Id} {author.FullName}");
//    foreach (var book in author.Books)
//    {
//        Console.WriteLine($"\t{book}");
//    }
//}
#endregion

#region OrderBy, OrderByDescending, ThenBy, ThenByDescending
//var authors = db.Authors
//    .OrderBy(a=>a.FirstName)
//    .ThenByDescending(a => a.LastName)
//    .ToList();

///*

//    SELECT Id, FisrstName, LastName
//    FROM Authors
//    ORDER BY FirstName, LastName DESC
// */

//authors.ForEach(Console.WriteLine);

#endregion

#region Join
//var books = db.Books.Join(db.Authors, b => b.IdAuthor, a => a.Id,
//    (b, a)=> new
//    {
//        Name = b.Name,
//        Author = $"{a.LastName} {a.FirstName}",
//    }).ToList();

///*
//    SELECT B.[Name] AS [Name], A.LastName + ' ' + A.FirstName AS Author
//    FROM Books AS B
//    JOIN Authors AS A
//    ON B.Id_Author = A.Id

// */


//books.ForEach(b => Console.WriteLine($"Book Name: {b.Name}\nAuthor: {b.Author}\n"));


#endregion

#region Take, TakeWhile, TakeLast, Skip, SkipWhile
//var authors = db.Authors.OrderBy(a=>a.FirstName).Skip(4).Take(3).ToList();
//authors.ForEach(Console.WriteLine);

/*
SELECT *
FROM Authors
ORDER BY FirstName
OFFSET (4) ROWS
FETCH NEXT (3) ROWS ONLY 
*/

#endregion

/*
LINQ for Entities

All
Any
Average
Contains
Count
First
FirstOrDefault
Single
SingleOrDefault
Select
Where
OrderBy
OrderByDescending
ThenBy
ThenByDescending
Join
LeftJoin
GroupBy
Except
Union
Intersect
Sum
Max
Min
Take
TakeWhile
TakeLast
Skip
SkipWhile
ToList
*/