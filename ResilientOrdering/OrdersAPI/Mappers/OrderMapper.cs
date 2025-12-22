using OrdersAPI.Data.DataTransferObjects.OrderDTOs;
using OrdersAPI.Data.DataTransferObjects.ProductDTOs;
using OrdersAPI.Data.Tables;

namespace OrdersAPI.Mappers
{
    public static class OrderMapper
    {
        public static OrderDTO ToOrderDTO(Order order)
        {
            OrderDTO dto = new OrderDTO();

            dto.Id = order.Id;
            dto.OrderDate = order.OrderDate;
            dto.DateToBeDelivered = order.DateToBeDelivered;
            dto.Processed = order.Processed;
            dto.OutForDelivery = order.OutForDelivery;
            dto.Delivered = order.Delivered;

            //dto.Customer = CustomerMapper.ToCustomerDTO(order.Customer);
            dto.Products = new List<ProductDTO>();
            //foreach (Product product in order.Products)
            //{
            //    dto.Products.Add(ProductMapper.ToProductDTO(product));
            //}

            return dto;
        }

        public static Order ToOrder(NewOrderDTO newOrder)
        {
            Order order = new Order(newOrder.CustomerId, newOrder.ProductIds, newOrder.OrderDate, newOrder.DateToBeDelivered);

            return order;
        }
    }
}
