using AutoMapper;
using FoodMartMongoDB.Dtos.CategoryDtos;
using FoodMartMongoDB.Dtos.DiscountDtos;
using FoodMartMongoDB.Dtos.FeatureDtos;
using FoodMartMongoDB.Dtos.ProductDtos;
using FoodMartMongoDB.Dtos.SellingDtos;
using FoodMartMongoDB.Entites;

namespace FoodMartMongoDB.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();
            CreateMap<Category, GetByIdCategoryDto>().ReverseMap();

            CreateMap<Discount, ResultDiscountDto>().ReverseMap();
            CreateMap<Discount, CreateDiscountDto>().ReverseMap();
            CreateMap<Discount, UpdateDiscountDto>().ReverseMap();
            CreateMap<Discount, GetByIdDiscountDto>().ReverseMap();

            CreateMap<Product, ResultProductDto>().ReverseMap();
            CreateMap<Product, CreateProductDto>().ReverseMap();
            CreateMap<Product, UpdateProductDto>().ReverseMap();
            CreateMap<Product, GetByIdProductDto>().ReverseMap();

            CreateMap<Feature, ResultFeatureDto>().ReverseMap();
            CreateMap<Feature, CreateFeatureDto>().ReverseMap();
            CreateMap<Feature, UpdateFeatureDto>().ReverseMap();
            CreateMap<Feature, GetByIdFeatureDto>().ReverseMap();

            CreateMap<Selling, ResultSellingDto>().ReverseMap();
            CreateMap<Selling, CreateSellingDto>().ReverseMap();
            CreateMap<Selling, UpdateSellingDto>().ReverseMap();
            CreateMap<Selling, GetByIdSellingDto>().ReverseMap();
        }
    }
}
