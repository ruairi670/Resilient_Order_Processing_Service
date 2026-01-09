using DataModels.Data.DataTransferObjects.Base;
using DataModels.Data.DataTransferObjects.CustomerDTOs;
using DataModels.Data.DataTransferObjects.ProductDTOs;

namespace DataModels.Data.DataTransferObjects.OrderDTOs
{
    public class OrderDTO : BaseDTO
    {
        public Guid Id { get; set; }

        public CustomerDTO Customer { get; set; }

        public List<ProductDTO> Products { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DateToBeDelivered { get; set; }

        public bool Processed { get; set; }

        public bool OutForDelivery { get; set; }

        public bool Delivered { get; set; }
    }
}
