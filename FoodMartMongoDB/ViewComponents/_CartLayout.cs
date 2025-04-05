using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.ViewComponents
{
    public class _CartLayout : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
