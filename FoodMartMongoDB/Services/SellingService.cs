using AutoMapper;
using FoodMartMongoDB.Dtos.SellingDtos;
using FoodMartMongoDB.Entites;
using FoodMartMongoDB.Settings;
using MongoDB.Driver;

namespace FoodMartMongoDB.Services
{
    public class SellingService : ISellingService
    {
        private readonly IMongoCollection<Selling> _sellingCollection;
        private readonly IMapper _mapper;

        public SellingService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _sellingCollection = database.GetCollection<Selling>(_databaseSettings.SellingCollectionName);
            _mapper = mapper;
        }

        public async Task CreateSellingAsync(CreateSellingDto createSellingDto)
        {
            var value = _mapper.Map<Selling>(createSellingDto);
            await _sellingCollection.InsertOneAsync(value);
        }

        public Task DeleteSellingAsync(string id)
        {
            return _sellingCollection.DeleteOneAsync(x => x.SellingId == id);
        }

        public async Task<List<ResultSellingDto>> GetAllSellingAsync()
        {
            var value = await _sellingCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultSellingDto>>(value);
        }

        public async Task<GetByIdSellingDto> GetByIdSellingAsync(string id)
        {
            var value = await _sellingCollection.Find(x => x.SellingId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetByIdSellingDto>(value);
        }

        public async Task UpdateSellingAsync(UpdateSellingDto updateSellingDto)
        {
            var value = _mapper.Map<Selling>(updateSellingDto);
            await _sellingCollection.FindOneAndReplaceAsync(x => x.SellingId == updateSellingDto.SellingId, value);
        }
    }
}
