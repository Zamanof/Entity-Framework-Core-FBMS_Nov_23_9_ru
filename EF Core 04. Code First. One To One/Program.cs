// Relationships
// One To One
// One To Many
// Many To Many

using EF_Core_04._Code_First._One_To_One;
using Microsoft.EntityFrameworkCore;


using StudentContext db = new StudentContext();
//Student student = new Student()
//{
//    FirstName = "Salam",
//    LastName = "Salamzade",
//    BirthDay = new DateTime(12, 12, 12)
//};
//StudentCard card = new StudentCard()
//{
//    StartDate = new DateTime(29, 9, 1),
//    EndDate = new DateTime(31, 6, 30),
//    Student = student
//};

//db.StudentCards.Add(card);
//db.SaveChanges();

var studentCard = db.StudentCards.Include(sc=>sc.Student).First();
Console.WriteLine(studentCard);
Console.WriteLine(studentCard.Student);


