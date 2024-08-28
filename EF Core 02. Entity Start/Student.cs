namespace EF_Core_02._Entity_Start;

internal class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    public override string ToString()
    {
        return $@"-----------{Id}-----------
FirstName:     {FirstName}
LastName:      {LastName}
Birthday:      {BirthDate.ToShortDateString()}
{new string('-', 25)}
";
    }
}
