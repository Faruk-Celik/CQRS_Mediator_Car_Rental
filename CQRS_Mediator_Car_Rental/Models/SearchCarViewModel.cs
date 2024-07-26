﻿namespace CQRS_Mediator_Car_Rental.Models
{
    public class SearchCarViewModel
    {
        public DateTime ReceivingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int ReceivingLocationID { get; set; }
        public int DestinationLocationID { get; set; }
    }
}
