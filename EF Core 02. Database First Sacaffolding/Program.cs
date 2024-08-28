using EF_Core_02._Database_First_Sacaffolding;

using LibraryContext db = new();

db.Authors.ToList().ForEach(Console.WriteLine);
