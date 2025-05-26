using FitnessCenter.Data;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenter.Infrastructure
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Reserv> Reservs { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<ClientReserv> ClientReservs { get; set; }
        public DbSet<ScheduleReserv> ScheduleReservs { get; set; }
        public DbSet<SubscriptionReserv> SubscriptionReservs { get; set; }
        public DbSet<TrainerReserv> TrainerReservs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;" +
                                     "Port=5432;" +
                                     "Database=FitnessCenter;" +
                                     "Username=postgres;" +
                                     "Password=1");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ClientReserv>().HasKey(x => new { x.ClientId, x.ReservId });
            modelBuilder.Entity<TrainerReserv>().HasKey(x => new { x.TrainerId, x.ReservId });
            modelBuilder.Entity<ScheduleReserv>().HasKey(x => new { x.ScheduleId, x.ReservId });
            modelBuilder.Entity<SubscriptionReserv>().HasKey(x => new { x.SubscriptionId, x.ReservId });
        }
    }
}