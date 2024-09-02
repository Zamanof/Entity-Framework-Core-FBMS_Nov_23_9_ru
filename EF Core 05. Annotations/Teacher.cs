using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_05._Annotations;

internal class Teacher
{
    // Obyavlyayet svoystvo PRIMARY KEY
    [Key]

    // Sopostavlyet imya svoystva class-a s imenem v tablise.
    // TeacherId (Entity) <-> Id (DB) 
    [Column("Id")]
    public int TeacherId { get; set; }
    // Vajnoye svoystvo. V DB ne mojet bit NULL
    [Required]
    // Ukazivayet maksimalniy razmer dlya polya v DB
    [MaxLength(30)]
    public string? FirstName { get; set; }
    [Required]
    [MaxLength(50)]
    public string? LastName { get; set; }
    [Required]
    // Ukazivayet kakoy tip dannix budet v DB
    [Column(TypeName ="varchar(50)")]
    public string? Email { get; set; }
    public DateTime BirthDay { get; set; }
    public float Salary { get; set; }
    public float Bonus { get; set; }
}
