using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FitnessCenter.Data;

[Table("Subscriptions")]
public class Subscription : BaseModel
{
    [Required, MaxLength(100)] public string Name { get; set; }

    public ICollection<SubscriptionReserv> SubscriptionReservs { get; set; }
}