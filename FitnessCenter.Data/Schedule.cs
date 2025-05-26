using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FitnessCenter.Data;

[Table("Schedules")]
public class Schedule : BaseModel
{
    [Required] public DateTime Date { get; set; }
    [Required] public DateTime DateBegin { get; set; }
    [Required] public DateTime DateEnd { get; set; }

    public ICollection<ScheduleReserv> ScheduleReservs { get; set; }
}