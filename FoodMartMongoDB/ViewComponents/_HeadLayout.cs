using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.ViewComponents
{
    public class _HeadLayout : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
