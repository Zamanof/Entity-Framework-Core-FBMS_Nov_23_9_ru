namespace EF_Core_05._Fluent_Api;

internal class Group
{
    public int Id { get; set; }
    public string? GroupName { get; set; }
    public int GroupRating { get; set; }
    public int CourseYear { get; set; } = 1;
    public List<Student> Students { get; set; } = [];
}