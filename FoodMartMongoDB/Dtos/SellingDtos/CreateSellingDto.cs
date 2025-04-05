namespace FoodMartMongoDB.Dtos.SellingDtos
{
    public class CreateSellingDto
    {
        public string ProductId { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ProductImage { get; set; }
    }
}
