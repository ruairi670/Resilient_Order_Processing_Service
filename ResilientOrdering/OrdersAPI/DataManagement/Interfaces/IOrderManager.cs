using OrdersAPI.Data.DataTransferObjects;
using OrdersAPI.Data.DataTransferObjects.OrderDTOs;

namespace OrdersAPI.DataManagement.Interfaces
{
    public interface IOrderManager
    {
        NetworkTransferObject<OrderDTO> GetOrder(int orderId);

        NetworkTransferObject<List<OrderDTO>> GetOrders();

        int? AddNewOrder(NewOrderDTO newOrder);
    }
}
