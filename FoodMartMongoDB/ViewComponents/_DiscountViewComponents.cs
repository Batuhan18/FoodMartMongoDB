using FoodMartMongoDB.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodMartMongoDB.ViewComponents
{
    public class _DiscountViewComponents : ViewComponent
    {
        private readonly IDiscountService _discountService;

        public _DiscountViewComponents(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _discountService.GetAllDiscountAsync();
            return View(value);
        }
    }
}
