namespace EF_Core_05._Annotations;

internal class Faculty
{
    public int Id { get; set; }
    public string FacultyName { get; set; }
    public List<Group> Groups { get; set; } = [];
}
