// Relationships
// One To One
// One To Many
// Many To Many

using EF_Core_04._Code_First._One_To_Many;
using Microsoft.EntityFrameworkCore;

using GroupContext db = new();

//Group group = new Group()
//{
//    Name = "FBMS_Nov_23_9_ru",
//    Students = new List<Student>()
//    {
//        new Student(){FirstName="Joice",LastName= "Revie"},
//        new Student() { FirstName="Jeffie", LastName="Broadbere" },
//        new Student() { FirstName="Angeline", LastName="Hammerton" },
//        new Student() { FirstName="Dolores", LastName="Aspinal" },
//        new Student() { FirstName="Sharron", LastName="Newberry" },
//        new Student() { FirstName="Imogene", LastName="Brampton" },
//        new Student() { FirstName="Beltran", LastName="Fendley" },
//        new Student() { FirstName="Hubey", LastName="Ashelford" },
//        new Student() { FirstName="Aylmer", LastName="Lehrmann" },
//        new Student() { FirstName="Lynett", LastName="Thirkettle" },
//        new Student() { FirstName="Marlene", LastName="O'Shaughnessy" },
//        new Student() { FirstName="Abbe", LastName="Mountfort" },
//        new Student() { FirstName="Maxine", LastName="Cudmore" },
//        new Student() { FirstName="Sam", LastName="Montgomery" },
//        new Student() { FirstName="Vincents", LastName="Whyman" }

//    }
//};

//db.Groups.Add(group);

//db.Groups.Add(new Group()
//{
//    Name = "FBMS_Oct_23_9_ru",
//    Students = new List<Student>()
//    {
//        new Student(){FirstName="Murad",LastName= "Masimov"},
//        new Student() { FirstName="Karim", LastName="Baliyev" },
//        new Student() { FirstName="Salam", LastName="Salamzade" },
//        new Student() { FirstName="Baxtiyar", LastName="Aspinalzade" },
//        new Student() { FirstName="Sharronxanim", LastName="Newberrybeyli" }


//    }
//});

//db.Groups.Add(new Group()
//{
//    Name = "Teenage Mutant Ninja Turtles",
//    Students = [
//        new Student(){FirstName = "Leonardo", LastName="Splinteroqlu"},
//        new Student(){FirstName = "Michelangelo", LastName="Splinteroqlu"},
//        new Student(){FirstName = "Raphael", LastName="Splinteroqlu"},
//        new Student(){FirstName = "Donatello", LastName="Splinteroqlu"}
//        ]
//});

//db.SaveChanges();


var groups =  db.Groups.Include(g=>g.Students).ToList();

foreach (var group in groups)
{
    Console.WriteLine(group);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"    {student}");
    }
}