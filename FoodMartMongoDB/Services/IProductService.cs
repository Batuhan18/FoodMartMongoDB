using FoodMartMongoDB.Dtos.ProductDtos;

namespace FoodMartMongoDB.Services
{
    public interface IProductService
    {
        Task<List<ResultProductDto>> GetAllProductsAsync();
        Task CreateProductAsync(CreateProductDto createProductDto);
        Task UpdateProductAsync(UpdateProductDto updateProductDto);
        Task DeleteProductAsync(string id);
        Task<GetByIdProductDto> GetByIdProductDtoAsync(string id);
    }
}
