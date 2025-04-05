using FoodMartMongoDB.Dtos.DiscountDtos;

namespace FoodMartMongoDB.Services
{
    public interface IDiscountService
    {
        Task<List<ResultDiscountDto>> GetAllDiscountAsync();
        Task CreateDiscountAsync(CreateDiscountDto createDiscountDto);
        Task UpdateDiscountAsync(UpdateDiscountDto updateDiscountDto);
        Task DeleteDiscountAsync(string id);
        Task<GetByIdDiscountDto> GetByIdDiscountAsync(string id);
    }
}
