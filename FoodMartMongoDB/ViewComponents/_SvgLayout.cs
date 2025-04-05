using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.ViewComponents
{
    public class _SvgLayout : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
