using System.ComponentModel.DataAnnotations;

namespace WebClientMvc.Models
{
    public class Product
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
        [DisplayFormat(DataFormatString = "{0:N0}")]
        public decimal Price { get; set; }
        /// <summary>
        /// Product description
        /// </summary>
        [MaxLength(500)]
        public string Description { get; set; }
    }
}
