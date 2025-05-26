using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FitnessCenter.Data;

[Table("Trainers")]
public class Trainer : BaseModel
{
    [Required, MaxLength(50)] public string Name { get; set; }
    [Required, MaxLength(50)] public string Surname { get; set; }
    [MaxLength(50)] public string Patronymic { get; set; }
    [Required] public DateTime DateOfBirth { get; set; }
    [Required, MaxLength(10)] public string Gender { get; set; }

    public ICollection<TrainerReserv> TrainerReservs { get; set; }
}