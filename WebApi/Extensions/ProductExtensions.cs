using WebApi.DTO;
using WebApi.Model.Entities;

namespace WebApi.Extensions
{
    public static class ProductExtensions
    {
        public static ProductDTO ToComm(this Product product)
        {
            return new ProductDTO()
            {
                Id = product.Id,
                Description = product.Description,
                ImgUri = product.ImgUri,
                Name = product.Name,
                Price = product.Price
            };
        }
        public static Product ToDB(this ProductDTO product, Product dbProduct = null)
        {
            if (dbProduct == null)
            {
                dbProduct = new Product();
            }
            dbProduct.Price = product.Price;
            dbProduct.ImgUri = product.ImgUri;
            dbProduct.Name = product.Name;
            dbProduct.Description = product.Description;
            return dbProduct;
        }
    }
}
