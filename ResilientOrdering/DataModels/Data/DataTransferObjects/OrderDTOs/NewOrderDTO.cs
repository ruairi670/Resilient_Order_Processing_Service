using DataModels.Data.DataTransferObjects.Base;
using DataModels.Data.DataTransferObjects.CustomerDTOs;
using DataModels.Data.DataTransferObjects.ProductDTOs;

namespace DataModels.Data.DataTransferObjects.OrderDTOs
{
    public class NewOrderDTO : BaseDTO
    {
        public Guid CustomerId { get; set; }

        public List<Guid> ProductIds { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DateToBeDelivered { get; set; }
    }
}
