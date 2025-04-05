using AutoMapper;
using FoodMartMongoDB.Dtos.CategoryDtos;
using FoodMartMongoDB.Entites;
using FoodMartMongoDB.Settings;
using MongoDB.Driver;

namespace FoodMartMongoDB.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryColelction;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _categoryColelction = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }

        public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);
            await _categoryColelction.InsertOneAsync(value);
        }

        public async Task DeleteCategoryAsync(string id)
        {
            await _categoryColelction.DeleteOneAsync(x => x.CategoryId == id);
        }

        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            var value = await _categoryColelction.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultCategoryDto>>(value);
        }

        public async Task<GetByIdCategoryDto> GetByIdCategoryAsync(string id)
        {
            var value = await _categoryColelction.Find(x => x.CategoryId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdCategoryDto>(value);
        }

        public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            var value = _mapper.Map<Category>(updateCategoryDto);
            await _categoryColelction.FindOneAndReplaceAsync(x => x.CategoryId == updateCategoryDto.CategoryId, value);
        }
    }
}
