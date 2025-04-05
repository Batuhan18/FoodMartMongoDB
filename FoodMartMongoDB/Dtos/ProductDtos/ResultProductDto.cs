namespace FoodMartMongoDB.Dtos.ProductDtos
{
    public class ResultProductDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public string Price { get; set; }
        public string Stock { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
