using WebApi.BusinessControllers.Interfaces;
using WebApi.Controllers;
using WebApi.DTO;
using WebApi.Extensions;
using WebApi.Model.Entities;
using WebApi.Repository.Interfaces;
using static WebApi.Exceptions;

namespace WebApi.BusinessControllers
{
    /// <summary>
    /// Product business controller
    /// </summary>
    public class ProductBusinessController : IProductBusinessController
    {
        private readonly IProductRepository productRepository;
        private readonly ILogger<ProductBusinessController> logger;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="productRepository"></param>
        public ProductBusinessController(
            IProductRepository productRepository,
            ILogger<ProductBusinessController> logger)
        {
            this.productRepository = productRepository;
            this.logger = logger;
        }
        /// <summary>
        /// Create new product
        /// </summary>
        /// <param name="productDTO"></param>
        /// <returns></returns>
        public async Task<ProductDTO> CreateAsync(ProductDTO productDTO)
        {
            try
            {             
                await productRepository.BeginTransactionAsync();

                var product = productDTO.ToDB();
                var productId = await productRepository.AddAsync(product);
                product = await productRepository.GetAsync<Product>(productId);

                productRepository.CommitTransaction();
                logger.LogInformation("Transaction committed in ProductBusinessController.CreateAsync");
                return product?.ToComm();
            }
            catch (Exception ex)
            {
                productRepository.RollbackTransaction();
                logger.LogWarning("Transaction rollbacked");
                logger.LogError(ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Patch product - update Description
        /// </summary>
        /// <param name="id"></param>
        /// <param name="productDTO"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        public async Task<ProductDTO> PatchProductAsync(int id, ProductPatchDTO productDTO)
        {
            try
            {
                await productRepository.BeginTransactionAsync();

                var productDB = await productRepository.GetAsync<Product>(id);
                if (productDB == null)
                {
                    var message = $"Product id {id} not found";
                    logger.LogError(message);
                    throw new NotFoundException(message);
                }
                else
                {
                    productDB.Description = productDTO.Description;                                        
                    await productRepository.UpdateAsync(productDB);

                    productRepository.CommitTransaction();
                    logger.LogInformation("Transaction committed in ProductBusinessController.PatchProductAsync");
                    return productDB.ToComm();
                }
            }
            catch (Exception ex)
            {
                productRepository.RollbackTransaction();
                logger.LogWarning("Transaction rollbacked");
                logger.LogError(ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="NotFoundException"></exception>
        public async Task<ProductDTO> GetProductAsync(int id)
        {
            try
            {
                var product = await productRepository.GetAsync<Product>(id);
                if (product == null)
                {
                    var message = $"Product id {id} not found";
                    logger.LogError(message);
                    throw new NotFoundException(message);
                }
                return product.ToComm();
            }
            catch (Exception)
            {
                throw;
            }
        }
        /// <summary>
        /// Get pagination result of products
        /// </summary>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public async Task<ProductListDTO> GetAsync(int? from, int? count)
        {
            var result = await productRepository.GetAsync<Product>(from, count);
            var productList = new ProductListDTO();
            productList = new ProductListDTO(result.Rows.Select(c => c.ToComm()), result.RowCount);
            return productList;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<ProductDTO>> GetAllAsync()
        {
            var result = await productRepository.GetAllAsync<Product>();
            return result.Select(c => c.ToComm());
        }
    }
}
