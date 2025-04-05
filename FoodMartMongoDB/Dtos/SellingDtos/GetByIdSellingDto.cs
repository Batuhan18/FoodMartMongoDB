namespace FoodMartMongoDB.Dtos.SellingDtos
{
    public class GetByIdSellingDto
    {
        public string SellingId { get; set; }
        public string ProductId { get; set; }
        public int Count { get; set; }
        public decimal TotalPrice { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string ProductImage { get; set; }
    }
}
