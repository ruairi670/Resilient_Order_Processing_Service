using DataModels.Data.DataTransferObjects.Base;

namespace DataModels.Data.DataTransferObjects.ProductDTOs
{
    public class ProductDTO : BaseDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public int QuantityInInventory { get; set; }
    }
}
