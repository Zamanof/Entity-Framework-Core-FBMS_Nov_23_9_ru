using EF_Core_05._Annotations;
// Entity Model - Annotations



using SchoolContext db = new();

Student student = new Student() { 
FirstName = "Adam",
LastName = "Sandler"
};
db.Students.Add(student);

Group group = new()
{
    GroupName = "FBMS_Nov_23_9_ru",
    GroupRating = 10,
    CourseYear = 2,
    Students = [student]
};
db.Groups.Add(group);

Departament departament = new()
{
    DepartamentName = "Programming"
};
db.Departments.Add(departament);

Faculty faculty = new()
{
    FacultyName = ".NET programming"
};
db.Faculties.Add(faculty);

Teacher teacher1 = new()
{
    FirstName = "Nadir",
    LastName = "Zamanov",
    BirthDay = new DateTime(1980, 10, 7),
    Salary = 1244244,
    Bonus = 10000000,
    Email = "Zamanov@itstep.org"
};

Teacher teacher2 = new()
{
    FirstName = "Ridan",
    LastName = "Namazov",
    BirthDay = new DateTime(1980, 10, 7),
    Salary = 1987123,
    Bonus = 10000000,
    Email = "Namazov@itstep.org"
};
db.Teachers.AddRange(teacher1, teacher2);
db.SaveChanges();
