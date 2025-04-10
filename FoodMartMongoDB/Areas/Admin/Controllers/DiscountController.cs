using FoodMartMongoDB.Dtos.DiscountDtos;
using FoodMartMongoDB.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodMartMongoDB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DiscountController : Controller
    {
        private readonly IDiscountService _discountService;

        public DiscountController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _discountService.GetAllDiscountAsync();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> CreateDiscount()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            await _discountService.CreateDiscountAsync(createDiscountDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteDiscount(string id)
        {
            await _discountService.DeleteDiscountAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDiscount(string id)
        {
            var updateDto = await _discountService.GetByIdDiscountAsync(id); 
            return View(updateDto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            await _discountService.UpdateDiscountAsync(updateDiscountDto);
            return RedirectToAction("Index");
        }
    }
}
