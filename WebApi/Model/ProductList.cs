using WebApi.Model.Entities;

namespace WebApi.Model
{
    public class ProductList
    {
        public ProductList() { }
        public ProductList(IEnumerable<Product> rows, int rowCount)
        {
            Rows = rows;
            RowCount = rowCount;
        }
        public IEnumerable<Product> Rows { get; set; } = new List<Product>();
        public int RowCount { get; set; }
    }
}
