using System.ComponentModel.DataAnnotations;

namespace WebApi.DTO
{
    /// <summary>
    /// ProductDTO
    /// </summary>
    public class ProductDTO
    {
        /// <summary>
        /// Product identifier
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Product name
        /// </summary>
        [Required]
        [MaxLength(250)]
        public required string Name { get; set; }
        /// <summary>
        /// Product image
        /// </summary>
        [Required]
        [MaxLength(500)]
        public required string ImgUri { get; set; }
        /// <summary>
        /// Product price
        /// </summary>
        [Required]
        public decimal Price { get; set; }
        /// <summary>
        /// Product description
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }
    }

    /// <summary>
    /// ProductPatchDTO
    /// </summary>
    public class ProductPatchDTO
    {
        /// <summary>
        /// Product description
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }
    }
}