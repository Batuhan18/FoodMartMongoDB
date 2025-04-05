using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.ViewComponents
{
    public class _MostPopularViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
