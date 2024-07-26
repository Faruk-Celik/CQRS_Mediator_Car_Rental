using Microsoft.AspNetCore.Mvc;

namespace CQRS_Mediator_Car_Rental.ViewComponents.AdminLayout
{
    public class AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        { return View(); }
    }
}
