namespace EF_Core_04._Code_First._One_To_Many;

internal class Student
{    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}
