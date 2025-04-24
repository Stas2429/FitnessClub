using FitnessCenter.Data;
using Microsoft.EntityFrameworkCore;


namespace ClassLibrary;

public class ApplicationContext:DbContext
{
    public DbSet<Class> Classes { get; set; }
    public DbSet<Client> Clients { get; set; }
    public DbSet<Schedule> Schedule { get; set; }
    public DbSet<Trainer> Trainers { get; set; }
    
    /* public ApplicationContext(DbContextOptions<ApplicationContext> options)
    {

    }
    */
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;" +
                                 "Port=5432;" +
                                 "Database=FitnessCenter;" +
                                 "Username=postgres;" +
                                 "Password=1");
        /*var connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
        optionsBuilder.UseNpgsql(connectionString);*/
       
        /*optionsBuilder.UseNpgsql(_config.GetSection("DatabaseConfig")["pg_db"]);*/
    }
}