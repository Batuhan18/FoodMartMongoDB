using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FoodMartMongoDB.Entites
{
    public class Discount
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string DiscountId { get; set; }
        public string DiscountPercent { get; set; }
        public string DiscountTitle { get; set; }
        public string DiscountImage { get; set; }
        public string Description { get; set; }
    }
}
