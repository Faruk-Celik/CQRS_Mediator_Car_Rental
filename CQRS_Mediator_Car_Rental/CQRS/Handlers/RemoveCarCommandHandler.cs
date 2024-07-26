using CQRS_Mediator_Car_Rental.CQRS.Commands;
using CQRS_Mediator_Car_Rental.DAL;

namespace CQRS_Mediator_Car_Rental.CQRS.Handlers
{
    public class RemoveCarCommandHandler
    {
        private readonly Context _context;

        public RemoveCarCommandHandler(Context context)
        {
            _context = context;
        }  
        public void Handle(RemoveCarCommand command) 
        { 
           var value=_context.ForRentCars.Find(command.ForRentCarID);
            _context.ForRentCars.Remove(value); 
            _context.SaveChanges();
        }
    }
}
