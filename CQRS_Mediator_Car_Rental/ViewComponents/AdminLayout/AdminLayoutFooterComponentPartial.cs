using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_Car_Rental.ViewComponents.AdminLayout
{
    public class AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
