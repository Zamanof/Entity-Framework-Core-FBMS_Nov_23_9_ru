using EF_Core_07._Explicit_Loading;
using Microsoft.EntityFrameworkCore;
// Read relational data

// - Eager loading        (Jadnaya zaqruzka)
// + Explicit loading     (Yavnaya zaqruzka)
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

// Load()
var group = db.Groups.FirstOrDefault(g => g.Id == 2);
db.Students.Where(s => s.GroupId == group.Id).Load();

if (group is not null)
{
    Console.WriteLine(group);
    group.Students.ForEach(Console.WriteLine);
}
else
{
    Console.WriteLine("Group not found!!!");
}

