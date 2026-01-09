using DataModels.Data.DataTransferObjects;
using DataModels.Data.DataTransferObjects.OrderDTOs;

namespace OrdersAPI.DataManagement.Interfaces
{
    public interface IOrderManager
    {
        NetworkTransferObject<OrderDTO> GetOrder(Guid orderId);

        NetworkTransferObject<List<OrderDTO>> GetOrders();

        Guid? AddNewOrder(NewOrderDTO newOrder);
    }
}
