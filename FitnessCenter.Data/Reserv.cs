using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FitnessCenter.Data;

[Table("Reservs")]
public class Reserv : BaseModel
{
    [Required] public Guid ClassId { get; set; }
    [ForeignKey("ClassId")] public Class Class { get; set; }

    [Required] public Guid TrainerId { get; set; }
    [ForeignKey("TrainerId")] public Trainer Trainer { get; set; }

    [Required, MaxLength(30)] public string Type { get; set; }
    [Required] public int Number { get; set; }

    public ICollection<ClientReserv> ClientReservs { get; set; }
    public ICollection<TrainerReserv> TrainerReservs { get; set; }
    public ICollection<ScheduleReserv> ScheduleReservs { get; set; }
    public ICollection<SubscriptionReserv> SubscriptionReservs { get; set; }
}