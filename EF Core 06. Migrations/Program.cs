// https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli
using EF_Core_06._Migrations;
Console.WriteLine();
using StudentContext db = new StudentContext();
//Student student = new Student()
//{
//    FirstName = "Salam",
//    LastName = "Salamzade"
//};
//db.Students.AddRange(student, new Student()
//{
//    FirstName = "Ali",
//    LastName = "Alizade"
//});
//db.SaveChanges();


//Student student2 = new Student()
//{
//    FirstName = "Vali",
//    LastName = "Valizade",
//    Age = 25
//};
//db.Students.Add(student2);

//Student student3 = new Student()
//{
//    FirstName = "Mahmud",
//    LastName = "Kashgari",
//    Age = 25
//};
//db.Students.Add(student3);
//db.SaveChanges();

//var students = db.Students.ToList();

//students.ForEach(Console.WriteLine);