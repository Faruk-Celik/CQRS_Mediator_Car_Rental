using CQRS_Mediator_Car_Rental.CQRS.Commands;
using CQRS_Mediator_Car_Rental.DAL;

namespace CQRS_Mediator_Car_Rental.CQRS.Handlers
{
    public class CreateForCarCommandHandler
    {
        private readonly Context _context;

        public CreateForCarCommandHandler(Context context)
        {
            _context = context;
        } 
        public void Handle(CreateForCarCommand command) 
        {
            _context.Add(new ForRentCar
            {
                CarBrand = command.CarBrand,
                CarModel = command.CarModel,
                CarKM = command.CarKM,
                CarType = command.CarType,
                CarGearType = command.CarGearType,
                CarTotalPerson = command.CarTotalPerson,
                CarFuelType = command.CarFuelType,
                CarColor = command.CarColor,
                CarRenterPersonMinAge = command.CarRenterPersonMinAge,
                CarEnginePower = command.CarEnginePower,
                ImageUrl = command.ImageUrl,
                CarDayPrice = command.CarDayPrice
            }); 
            _context.SaveChanges();
        }
    }
}
