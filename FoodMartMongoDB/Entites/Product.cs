using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FoodMartMongoDB.Entites
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string CategoryId { get; set; }
        [BsonIgnore]
        public Category Category { get; set; }
    }
}
