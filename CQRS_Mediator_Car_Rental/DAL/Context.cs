using Microsoft.EntityFrameworkCore;

namespace CQRS_Mediator_Car_Rental.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-6VB768D\\SQLEXPRESS02; initial catalog=CQRSMediatorCarRental; integrated Security=true;");
        }
        public DbSet<ForRentCar> ForRentCars { get; set; }
        public DbSet<ReceivingLocation> ReceivingLocations { get; set; }
        public DbSet<DeliveryLocation> DeliveryLocations { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
    }
}
