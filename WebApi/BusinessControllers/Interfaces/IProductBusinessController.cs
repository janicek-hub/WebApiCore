using WebApi.DTO;
using static WebApi.Exceptions;

namespace WebApi.BusinessControllers.Interfaces
{
    /// <summary>
    /// IProductBusinessController interface
    /// </summary>
    public interface IProductBusinessController
    {
        /// <summary>
        /// Create new product
        /// </summary>
        /// <param name="productDTO"></param>
        /// <returns></returns>
        Task<ProductDTO> CreateAsync(ProductDTO productDTO);
        /// <summary>
        /// Patch product - update Description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="productDTO"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        Task<ProductDTO> PatchProductAsync(int id, ProductPatchDTO productDTO);
        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        Task<ProductDTO> GetProductAsync(int id);
        /// <summary>
        /// Get pagination result of products
        /// </summary>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        Task<ProductListDTO> GetAsync(int? from, int? count);
        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ProductDTO>> GetAllAsync();
    }
}
