namespace EF_Core_07._Loadings._Lazy_loading;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; }
    public virtual List<Student> Students { get; set; } = [];

    public override string ToString()
    {
        return Name;
    }
}
