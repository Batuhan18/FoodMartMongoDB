using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FoodMartMongoDB.Entites
{
    public class Feature
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FeatureId { get; set; }
        public string FeatureImage { get; set; }
        public string FeatureTitle { get; set; }
        public string FeatureHeader { get; set; }
        public string FeatureSubtitle { get; set; }
    }
}
