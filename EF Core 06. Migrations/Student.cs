namespace EF_Core_06._Migrations;

internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int? Age { get; set; }
    public string? Email { get; set; }
    public bool? Gender { get; set; }
    public bool? IsActive { get; set; }

    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName} - {Age}";
    }
}
