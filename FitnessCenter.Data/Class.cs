using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FitnessCenter.Data;

[Table("Classes")]
public class Class : BaseModel
{
    [Required, MaxLength(100)] public string Name { get; set; }
    [Required] public TimeSpan Time { get; set; }
    [Required] public decimal Cost { get; set; }
    [Required] public int MaxNumber { get; set; }

    public ICollection<Reserv> Reservs { get; set; }
}