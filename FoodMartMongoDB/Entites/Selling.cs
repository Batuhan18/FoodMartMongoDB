using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodMartMongoDB.Entites
{
    public class Selling
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SellingId { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }


        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        [BsonIgnore]
        public Product Product { get; set; }
    }
}
