using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.ViewComponents
{
    public class _TrendingProductsViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
