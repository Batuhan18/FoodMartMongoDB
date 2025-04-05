using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.ViewComponents
{
    public class _SearchLayout : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
