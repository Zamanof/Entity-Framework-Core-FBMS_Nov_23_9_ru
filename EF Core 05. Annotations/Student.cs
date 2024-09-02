using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF_Core_05._Annotations;

internal class Student
{
    public int Id { get; set; }
    [Required]
    [MaxLength(30)]
    public string? FirstName { get; set; }

    [Required]
    [MaxLength(50)]
    public string? LastName { get; set; }

    // Ukazivayet chto dannoye svoystvo eto vneshniy klyuch
    [ForeignKey("Group")]
    [Column("Id_Group")]
    public int GroupId { get; set; } // ForeignKey
    public Group Group { get; set; } // Navigation Property


    public override string ToString()
    {
        return $"{Id}. {FirstName} {LastName}";
    }
}
