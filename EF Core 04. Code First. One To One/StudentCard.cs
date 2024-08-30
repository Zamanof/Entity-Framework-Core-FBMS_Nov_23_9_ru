namespace EF_Core_04._Code_First._One_To_One;

internal class StudentCard
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Student Student { get; set; }
    public override string ToString()
    {
        return $"Student Card - Start Date: {StartDate.ToShortDateString()} End Date: {EndDate.ToShortDateString()}";
    }
}
