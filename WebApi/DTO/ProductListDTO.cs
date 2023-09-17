namespace WebApi.DTO
{
    public class ProductListDTO
    {
        private int rowCount;

        public ProductListDTO() { }
        public ProductListDTO(IEnumerable<ProductDTO> rows, int rowCount)
        {
            Rows = rows;
            this.rowCount = rowCount;
        }
        public IEnumerable<ProductDTO> Rows { get; set; } = new List<ProductDTO>();
        public int RowCount => Math.Abs(rowCount);
    }
}
