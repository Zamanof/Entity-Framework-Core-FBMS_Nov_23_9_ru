namespace EF_Core_09._Dapper_methods._Relationships;

public class Student
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int IdGroup { get; set; }

    public int Term { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}