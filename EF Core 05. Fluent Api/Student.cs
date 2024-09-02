namespace EF_Core_05._Fluent_Api;
internal class Student
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int GroupId { get; set; } 
    public Group Group { get; set; }
}
