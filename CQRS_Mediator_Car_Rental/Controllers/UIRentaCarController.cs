using MediatR;
using Microsoft.AspNetCore.Mvc;
using CQRS_Mediator_Car_Rental.CQRS.Handlers;
using CQRS_Mediator_Car_Rental.Mediator.Queries;
using CQRS_Mediator_Car_Rental.Models;

namespace CQRS_Mediator_Car_Rental.Controllers
{
    public class UIRentaCarController : Controller
    {
        private readonly IMediator _mediator; 
        private readonly GetCarQueryHandler _getCarQueryHandler;

        public UIRentaCarController(IMediator mediator, GetCarQueryHandler getCarQueryHandler)
        {
            _mediator = mediator;
            _getCarQueryHandler = getCarQueryHandler;
        }

        public IActionResult Index()
        {
            return View();
        } 

        [HttpPost]
        public async Task<IActionResult> SearchCarList(SearchCarViewModel model)
        {  
            var result=await _mediator.Send(new SearchCarQuery(model.DestinationLocationID,model.ReceivingLocationID,model.ReceivingDate,model.DeliveryDate)); 
            return View(result);
            
        }  
        public IActionResult CarList()
        {
            var values = _getCarQueryHandler.Handle(); 
            return View(values);
        }
       
    }
}
