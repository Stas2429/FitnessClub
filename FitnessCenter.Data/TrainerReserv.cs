using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FitnessCenter.Data;

[Table("TrainerReservs")]
public class TrainerReserv
{
    [Required] public Guid TrainerId { get; set; }
    [ForeignKey("TrainerId")] public Trainer Trainer { get; set; }

    [Required] public Guid ReservId { get; set; }
    [ForeignKey("ReservId")] public Reserv Reserv { get; set; }
}