namespace EF_Core_07._Explicit_Loading
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; } = [];

        public override string ToString()
        {
            return Name;
        }
    }
}
