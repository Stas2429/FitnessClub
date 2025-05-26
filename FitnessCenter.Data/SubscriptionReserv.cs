using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FitnessCenter.Data;

[Table("SubscriptionReservs")]
public class SubscriptionReserv
{
    [Required] public Guid SubscriptionId { get; set; }
    [ForeignKey("SubscriptionId")] public Subscription Subscription { get; set; }

    [Required] public Guid ReservId { get; set; }
    [ForeignKey("ReservId")] public Reserv Reserv { get; set; }
}