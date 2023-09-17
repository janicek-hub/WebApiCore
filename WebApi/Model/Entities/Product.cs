using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Options;

namespace WebApi.Model.Entities
{
    /// <summary>
    /// Product entity
    /// </summary>
    [Table("Products")]
    public class Product
    {        
        /// <summary>
        /// Product identifier
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Product name
        /// </summary>
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }
        /// <summary>
        /// Product image
        /// </summary>
        [Required]
        [MaxLength(500)]        
        public string ImgUri { get; set; }
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
}
