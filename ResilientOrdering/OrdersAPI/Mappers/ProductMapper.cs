using OrdersAPI.Data.DataTransferObjects.ProductDTOs;
using OrdersAPI.Data.Tables;

namespace OrdersAPI.Mappers
{
    public static class ProductMapper
    {
        public static ProductDTO ToProductDTO(Product product)
        {
            ProductDTO dto = new ProductDTO();

            dto.Id = product.Id;
            dto.Name = product.Name;
            dto.Description = product.Description;
            dto.Price = product.Price;
            dto.QuantityInInventory = product.QuantityInInventory;

            return dto;
        }
    }
}
