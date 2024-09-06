using EF_Core_07.__Loadings._Eager_loading;
using Microsoft.EntityFrameworkCore;
// Read relational data

// + Eager loading        (Jadnaya zaqruzka)  
// - Explicit loading     (Yavnaya zaqruzka)
// - Lazy loading         (Lenivaya zaqruzka)


using ApplicationContext db = new ApplicationContext();

#region Add Data
//db.Database.EnsureDeleted();
//db.Database.EnsureCreated();
//List<Student> students = [
//    new (){
//        FirstName="Salam",
//        LastName = "Salamzade",
//        Age = 23
//    },
//    new (){
//        FirstName="Chuck",
//        LastName = "Norris",
//        Age = 76
//    },
//    new (){
//        FirstName="Lourens",
//        LastName = "Araviyskiy",
//        Age = 123
//    },
//    new (){
//        FirstName="Bill",
//        LastName = "Gates",
//        Age = 71
//    },
//    new (){
//        FirstName="Pavel",
//        LastName = "Durov",
//        Age = 42
//    }
//    ];
//db.Groups.Add(new()
//{
//    Name = "FBMS_Nov_23_9_ru",
//    Students = students
//});

//List<Student> obshestvoMertvixPoetov = [
//     new (){
//        FirstName="Aleksandr",
//        LastName = "Pushkin",
//        Age = 215
//    },
//    new (){
//        FirstName="Sergei",
//        LastName = "Yesenin",
//        Age = 148
//    },
//    new (){
//        FirstName="Jason",
//        LastName = "Statham",
//        Age = 57
//    },
//    new (){
//        FirstName="Nizami",
//        LastName = "Ganjavi",
//        Age = 850
//    }
//    ];

//db.Groups.Add(new() { Name = "Poeti po prenujdeniyu", Students = obshestvoMertvixPoetov });

//db.SaveChanges();
#endregion

// Include(), ThenInclude()

//var groups = db.Groups.Include(g=>g.Students).ToList();
//foreach (var group in groups)
//{
//    Console.WriteLine(group);
//    foreach (var student in group.Students)
//    {
//        Console.WriteLine($"    {student}");
//    }
//}

var students = db.Students.Include(s => s.Group).ToList();

foreach (var student in students)
{
    Console.WriteLine($"{student} - {student.Group}");
}

//db.Students.Add(new()
//{
//    FirstName = "Kakoy to",
//    LastName = "Chto to",
//    Age = 4890216,
//    GroupId = 2
//});
//db.SaveChanges();



