namespace CQRS_Mediator_Car_Rental.DAL
{
    public class DeliveryLocation
    { 
        public int DeliveryLocationId { get; set; } 
        public string DeliveryLocationName { get; set;}
        public List<RentACar> RentACars { get; set; }
    }
}
