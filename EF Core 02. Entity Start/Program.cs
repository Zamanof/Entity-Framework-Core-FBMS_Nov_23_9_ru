using EF_Core_02._Entity_Start;
// Entity Framework Core

// Database First
// Code First
// Model First
Console.WriteLine();
#region Add Data

//using (StudentContext db = new StudentContext())
//{
//    Student student = new()
//    {
//        FirstName = "John",
//        LastName = "Doe",
//        BirthDate = new DateTime(1900, 1, 1)
//    };
//    Student student2 = new()
//    {
//        FirstName = "Ali",
//        LastName = "Aliyev",
//        BirthDate = new DateTime(2011, 11, 11)
//    };
//    Student student3 = new()
//    {
//        FirstName = "Ivan",
//        LastName = "Ivanov",
//        BirthDate = new DateTime(1999, 9, 9)
//    };

//    db.Students.Add(student);
//    db.Students.Add(student2);
//    db.Students.Add(student3);
//    db.SaveChanges();
//}
#endregion

#region Read Data
//using (var db = new StudentContext())
//{ 

//    var student = db.Students.FirstOrDefault(bubu=> bubu.Id == 4);
//    if (student is not null) Console.WriteLine(student);
//    else Console.WriteLine("Student Not Found");
//}
#endregion

#region Add datas
//using (StudentContext db = new())
//{
//    List<Student> students = [
//        new Student(){
//            FirstName = "Salam",
//            LastName = "Salamzade",
//            BirthDate = new DateTime(1980, 2, 4)
//        },
//        new Student(){
//            FirstName = "Hello",
//            LastName = "Helladze",
//            BirthDate = new DateTime(1981, 3, 5)
//        },
//        new Student(){
//            FirstName = "Hi",
//            LastName = "Wifi",
//            BirthDate = new DateTime(1982, 4, 6)
//        },
//        new Student(){
//            FirstName = "Bombastic",
//            LastName = "Telefantastic",
//            BirthDate = new DateTime(1983, 5, 7)
//        },
//        new Student(){
//            FirstName = "mr.Loba",
//            LastName = "Loba",
//            BirthDate = new DateTime(1980, 2, 4)
//        }
//        ];

//    db.Students.AddRange(students);

//    db.SaveChanges();
//}

#endregion

#region Read Datas
//using StudentContext db = new StudentContext();
//var students = db.Students.ToList();

//students.ForEach(Console.WriteLine);
#endregion

#region Delete Data
//using StudentContext db = new StudentContext();

//db.Remove(db.Students.First());
//db.SaveChanges();

//var students = db.Students.Where(s => s.Id < 5);
//db.Students.RemoveRange(students);
//db.SaveChanges();

#endregion

//using StudentContext db = new StudentContext();
//db.Database.EnsureDeleted();