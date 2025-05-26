using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FitnessCenter.Data;

[Table("ScheduleReservs")]
public class ScheduleReserv
{
    [Required] public Guid ScheduleId { get; set; }
    [ForeignKey("ScheduleId")] public Schedule Schedule { get; set; }

    [Required] public Guid ReservId { get; set; }
    [ForeignKey("ReservId")] public Reserv Reserv { get; set; }
}