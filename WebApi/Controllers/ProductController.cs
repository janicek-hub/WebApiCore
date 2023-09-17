using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Filters;
using WebApi.BusinessControllers.Interfaces;
using WebApi.DTO;
using static WebApi.Exceptions;

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
        private readonly IProductBusinessController _productBusinessController;
        /// <summary>
        /// Constructor
        /// </summary>
        public ProductController(IProductBusinessController productBusinessController)
        {
            _productBusinessController = productBusinessController;
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
            try
            {
                var result = await _productBusinessController.GetAllAsync();
                return Ok(result);
            }
            catch (NotFoundException exc)
            {
                return NotFound();
            }
            catch (Exception exc)
            {
                return BadRequest(new ProblemDetails() { Detail = exc.Message + (exc.InnerException != null ? $";\n{exc.InnerException.Message}" : "") + "\n" + exc.StackTrace, Title = exc.Message, Type = exc.GetType().ToString() });
            }
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
            try
            {
                var result = await _productBusinessController.GetAsync(from, count);
                Response.Headers.Add("RowCount", result?.RowCount.ToString());
                return Ok(result?.Rows);
            }
            catch (NotFoundException exc)
            {
                return NotFound();
            }
            catch (Exception exc)
            {
                return BadRequest(new ProblemDetails() { Detail = exc.Message + (exc.InnerException != null ? $";\n{exc.InnerException.Message}" : "") + "\n" + exc.StackTrace, Title = exc.Message, Type = exc.GetType().ToString() });
            }
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
            try
            {
                var result = await _productBusinessController.GetProductAsync(id);
                return Ok(result);
            }
            catch (NotFoundException exc)
            {
                return NotFound();
            }
            catch (Exception exc)
            {
                return BadRequest(new ProblemDetails() { Detail = exc.Message + (exc.InnerException != null ? $";\n{exc.InnerException.Message}" : "") + "\n" + exc.StackTrace, Title = exc.Message, Type = exc.GetType().ToString() });
            }
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
            try
            {
                var result = await _productBusinessController.PatchProductAsync(id, product);
                return Ok(result);
            }
            catch (NotFoundException exc)
            {
                return NotFound();
            }
            catch (Exception exc)
            {
                return BadRequest(new ProblemDetails() { Detail = exc.Message + (exc.InnerException != null ? $";\n{exc.InnerException.Message}" : "") + "\n" + exc.StackTrace, Title = exc.Message, Type = exc.GetType().ToString() });
            }
        }
    }
}
