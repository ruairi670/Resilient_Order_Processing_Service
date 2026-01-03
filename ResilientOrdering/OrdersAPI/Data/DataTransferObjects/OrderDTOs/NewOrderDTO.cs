using OrdersAPI.Data.DataTransferObjects.Base;
using OrdersAPI.Data.DataTransferObjects.CustomerDTOs;
using OrdersAPI.Data.DataTransferObjects.ProductDTOs;

namespace OrdersAPI.Data.DataTransferObjects.OrderDTOs
{
    public class NewOrderDTO : BaseDTO
    {
        public int CustomerId { get; set; }

        public List<int> ProductIds { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DateToBeDelivered { get; set; }
    }
}
