using EF_Core_02._DatabaseFirst;

// Database

using LibraryContext db = new LibraryContext();

var authors = db.Authors.ToList();

var libs = db.Libs.ToList();

authors.ForEach(Console.WriteLine);
Console.WriteLine();
libs.ForEach(Console.WriteLine);
