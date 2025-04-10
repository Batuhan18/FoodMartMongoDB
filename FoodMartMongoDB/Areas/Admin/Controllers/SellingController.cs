using FoodMartMongoDB.Dtos.SellingDtos;
using FoodMartMongoDB.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodMartMongoDB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SellingController : Controller
    {
        private readonly ISellingService _sellingService;

        public SellingController(ISellingService sellingService)
        {
            _sellingService = sellingService;
        }

        public async Task<IActionResult> Index()
        {
            var value = await _sellingService.GetAllSellingAsync();
            return View(value);
        }

        [HttpGet]
        public async Task<IActionResult> CreateSelling()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSelling(CreateSellingDto createSellingDto)
        {
            await _sellingService.CreateSellingAsync(createSellingDto);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteSelling(string id)
        {
            await _sellingService.DeleteSellingAsync(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSelling(string id)
        {
            var value = await _sellingService.GetByIdSellingAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSelling(UpdateSellingDto updateSellingDto)
        {
            await _sellingService.UpdateSellingAsync(updateSellingDto);
            return RedirectToAction("Index");
        }
    }
}
