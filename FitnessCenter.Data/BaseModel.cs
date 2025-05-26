using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessCenter.Data;

public abstract class BaseModel
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public DateTime DataCreate { get; set; }

    [Required]
    public DateTime DataUpdate { get; set; }

    protected BaseModel()
    {
        Id = Guid.NewGuid();
        DataCreate = DateTime.Now;
        DataUpdate = DateTime.Now;
    }
}