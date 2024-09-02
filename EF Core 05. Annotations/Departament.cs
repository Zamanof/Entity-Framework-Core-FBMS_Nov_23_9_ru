namespace EF_Core_05._Annotations;

internal class Departament
{
    public int Id { get; set; }
    public string DepartamentName { get; set; }
    public List<Teacher> Teachers { get; set; } = [];
}
