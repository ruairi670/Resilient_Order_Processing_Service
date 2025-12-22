using OrdersAPI.Data.DataTransferObjects.Base;
using OrdersAPI.Data.DataTransferObjects.CustomerDTOs;
using OrdersAPI.Data.DataTransferObjects.ProductDTOs;

namespace OrdersAPI.Data.DataTransferObjects.OrderDTOs
{
    public class EditOrderDTO : BaseDTO
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public List<Guid> ProductIds { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DateToBeDelivered { get; set; }

        public bool Processed { get; set; }

        public bool OutForDelivery { get; set; }

        public bool Delivered { get; set; }
    }
}
