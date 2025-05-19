using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using WebApi.BusinessControllers.Interfaces;
using WebApi.DTO;

namespace WebApi.Controllers
{
    /// <summary>
    /// Product API controller
    /// </summary>
    //[Authorize] for use authorization token
    [Route("api/v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusinessController productBusinessController;
        /// <summary>
        /// Constructor
        /// </summary>
        public ProductController(IProductBusinessController productBusinessController)
        {
            this.productBusinessController = productBusinessController;
        }

        /// <summary>
        /// Return all products
        /// </summary>
        /// <returns></returns>
        /// /// <response code="200">Returns all products</response>
        /// <response code="400">Returns ProblemDetail with message</response>
        /// <response code="500">Returns ProblemDetail with exception</response>
        [HttpGet("all")]
        [ProducesResponseType(typeof(IEnumerable<ProductDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAll()
        {
            var result = await productBusinessController.GetAllAsync();
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
        /// <summary>
        /// Return a paginated list of products
        /// </summary>
        /// <param name="from"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        /// <response code="200">Returns a paginated list of products</response>
        /// <response code="400">Returns ProblemDetail with message</response>
        /// <response code="500">Returns ProblemDetail with exception</response>
        [HttpGet("pagination")]
        [ProducesResponseType(typeof(IEnumerable<ProductDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> Get(
            [FromQuery] int? from = 0,
            [FromQuery] int? count = 10)
        {
            var result = await productBusinessController.GetAsync(from, count);
            if (result == null)
            {
                return NotFound();
            }
            Response.Headers.Add("RowCount", result?.RowCount.ToString());
            return Ok(result?.Rows);
        }

        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <response code="200">Returns product item</response>
        /// <response code="400">Returns ProblemDetail with message</response>
        /// <response code="500">Returns ProblemDetail with exception</response>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ProductDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ProductDTO>> GetById(int id)
        {
            var result = await productBusinessController.GetProductAsync(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        /// <summary>
        /// Updates description of product
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <param name="product">Data for update</param>
        /// <returns>Updated product</returns>
        /// <response code="200">Returns updated product item</response>
        /// <response code="400">Returns ProblemDetail with message</response>
        /// <response code="500">Returns ProblemDetail with exception</response>
        [HttpPatch("{id}")]
        [ProducesResponseType(typeof(ProductDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status500InternalServerError)]
        [SwaggerResponseExample(StatusCodes.Status200OK, typeof(ProductDTO))]
        public async Task<ActionResult<ProductDTO>> Patch(int id, [FromBody] ProductPatchDTO product)
        {
            var result = await productBusinessController.PatchProductAsync(id, product);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
