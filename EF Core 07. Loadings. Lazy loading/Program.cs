// Read relational data

// - Eager loading        (Jadnaya zaqruzka)  
// - Explicit loading     (Yavnaya zaqruzka)
// + Lazy loading         (Lenivaya zaqruzka)

// Chtobi rabotat s Lazy Loading:
// 1. Nado podklyuchit nuget Microsoft.EntityFramework.Proxies
// 2. V konfiquarisu dobavit .UseLazyLoadingProxies()
// 3. Property svyazanniye s otnosheniyami(navigation property i druqie) doljni bit virtualnimi
// 4. Vse class-i opisivayushiye model doljni bit public
using EF_Core_07._Loadings._Lazy_loading;

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

var groups =  db.Groups.ToList();
foreach (var group in groups)
{
    Console.WriteLine(group);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"        {student}");
    }
}

Console.ReadKey();

var groups1 = db.Groups.ToList();
foreach (var group in groups1)
{
    Console.WriteLine(group);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"        {student}");
    }
}