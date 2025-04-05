using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.ViewComponents
{
    public class _NavbarLayout : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
