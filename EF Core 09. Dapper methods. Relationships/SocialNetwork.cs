namespace EF_Core_09._Dapper_methods._Relationships;

public class SocialNetwork
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<User> Users { get; set; } = [];
    public override string ToString()
    {
        return Name;
    }
}
