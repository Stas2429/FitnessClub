using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FitnessCenter.Data;

public class ClientReserv
{
    [Required]
    public Guid ClientId { get; set; }

    [ForeignKey("ClientId")]
    public Client Client { get; set; }

    [Required]
    public Guid ReservId { get; set; }

    [ForeignKey("ReservId")]
    public Reserv Reserv { get; set; }
}