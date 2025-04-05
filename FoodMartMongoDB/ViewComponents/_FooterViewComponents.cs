using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.ViewComponents
{
    public class _FooterViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
