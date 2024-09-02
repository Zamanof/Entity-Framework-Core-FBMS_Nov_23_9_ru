namespace EF_Core_05._Fluent_Api;
internal class Teacher
{
    public int TeacherId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateTime BirthDay { get; set; }
    public float Salary { get; set; }
    public float Bonus { get; set; }
}