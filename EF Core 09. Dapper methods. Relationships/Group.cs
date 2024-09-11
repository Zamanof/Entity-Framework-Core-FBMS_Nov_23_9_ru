namespace EF_Core_09._Dapper_methods._Relationships;

internal class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdFaculty { get; set; }

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    public override string ToString()
    {
        return Name;
    }
}
