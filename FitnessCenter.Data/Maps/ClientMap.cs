using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FitnessCenter.Data.Maps;

public class ClientMap
{
    public ClientMap(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(t => t.Name).IsRequired();
    }
}