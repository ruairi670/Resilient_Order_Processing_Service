using OrdersAPI.Data.DataTransferObjects.Base;
using OrdersAPI.Data.DataTransferObjects.CustomerDTOs;
using OrdersAPI.Data.DataTransferObjects.ProductDTOs;

namespace OrdersAPI.Data.DataTransferObjects.OrderDTOs
{
    public class OrderDTO : BaseDTO
    {
        public int Id { get; set; }

        public CustomerDTO Customer { get; set; }

        public List<ProductDTO> Products { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DateToBeDelivered { get; set; }

        public bool Processed { get; set; }

        public bool OutForDelivery { get; set; }

        public bool Delivered { get; set; }
    }
}
