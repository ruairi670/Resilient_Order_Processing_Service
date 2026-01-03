using OrdersAPI.Data;
using OrdersAPI.Data.DataTransferObjects;
using OrdersAPI.Data.DataTransferObjects.OrderDTOs;
using OrdersAPI.Data.Tables;
using OrdersAPI.DataManagement.Interfaces;
using OrdersAPI.Mappers;

namespace OrdersAPI.DataManagement
{
    public class OrderManager : DataManager, IOrderManager
    {

        public OrderManager() : base() { }

        public NetworkTransferObject<OrderDTO> GetOrder(int orderId)
        {
            Order? order = Database.Orders.FirstOrDefault(x => x.Id == orderId);

            if (order == null) return new NetworkTransferObject<OrderDTO>(null, new NullReferenceException("No such order record exists"));

            OrderDTO orderDTO = OrderMapper.ToOrderDTO(order);
            GetOrderNavigationProperties(orderDTO, order);

            return new NetworkTransferObject<OrderDTO>(orderDTO, null);
        }

        private void GetOrderNavigationProperties(OrderDTO orderDTO, Order order)
        {
            Customer customer = Database.Customers.First(x => x.Id == order.CustomerId);
            orderDTO.Customer = CustomerMapper.ToCustomerDTO(customer);

            List<Product> products = Database.Products.Where(x => order.ProductIds.Contains(x.Id)).ToList();
            foreach (Product product in products)
            {
                orderDTO.Products.Add(ProductMapper.ToProductDTO(product));
            }
        }

        public NetworkTransferObject<List<OrderDTO>> GetOrders()
        {
            List<OrderDTO> orderDtos = new List<OrderDTO>();

            List<Order> orders = Database.Orders.ToList();

            foreach (Order order in orders)
            {
                OrderDTO orderDto = OrderMapper.ToOrderDTO(order);

                GetOrderNavigationProperties(orderDto, order);

                orderDtos.Add(orderDto);
            }

            return new NetworkTransferObject<List<OrderDTO>>(orderDtos, null);
        }

        public int? AddNewOrder(NewOrderDTO newOrder)
        {
            if (newOrder == null) return null;

            Order order = OrderMapper.ToOrder(newOrder);

            Database.Orders.Add(order);

            return order.Id;
        }
    }
}
