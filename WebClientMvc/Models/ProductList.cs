using WebApi;

namespace WebClientMvc.Models
{
    public class ProductList
    {
        private int rowCount;
        public ProductList() { }
        public ProductList(IEnumerable<ProductDTO> rows, int rowCount)
        {
            Rows = rows;
            this.rowCount = rowCount;
        }
        public IEnumerable<ProductDTO> Rows { get; set; } = new List<ProductDTO>();
        public int RowCount => Math.Abs(rowCount);
    }
}
