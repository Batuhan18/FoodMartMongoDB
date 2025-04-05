using Microsoft.AspNetCore.Mvc;

namespace FoodMartMongoDB.ViewComponents
{
    public class _NewBrandsViewComponents : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
