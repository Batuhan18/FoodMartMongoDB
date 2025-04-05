using FoodMartMongoDB.Dtos.SellingDtos;

namespace FoodMartMongoDB.Services
{
    public interface ISellingService
    {
        Task<List<ResultSellingDto>> GetAllSellingAsync();
        Task CreateSellingAsync(CreateSellingDto createSellingDto);
        Task UpdateSellingAsync(UpdateSellingDto updateSellingDto);
        Task DeleteSellingAsync(string id);
        Task<GetByIdSellingDto> GetByIdSellingAsync(string id);
    }
}
