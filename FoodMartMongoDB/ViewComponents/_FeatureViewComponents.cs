using FoodMartMongoDB.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FoodMartMongoDB.ViewComponents
{
    public class _FeatureViewComponents : ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _FeatureViewComponents(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _featureService.GetAllFeatureAsync();
            return View(value);
        }
    }
}
