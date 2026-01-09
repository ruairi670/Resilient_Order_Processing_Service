using DataModels.Data.DataTransferObjects;
using DataModels.Data.DataTransferObjects.OrderDTOs;
using Microsoft.AspNetCore.Mvc;
using OrdersAPI.DataManagement;
using System.Collections.Generic;

namespace OrdersAPI.Controllers
{
    [ApiController]
    [Route("api/Orders")]
    public class OrdersController : ControllerBase
    {
        //private readonly ILogger<OrdersController> _logger;

        protected OrderManager _orderManager { get; set; }
        public OrdersController(OrderManager orderManager)
        {
            //_logger = logger;
            _orderManager = orderManager;
        }

        [HttpGet(Name = "Index")]
        public string Get()
        {
            return "Orders Index";
        }

        [HttpGet("GetOrders")]
        public NetworkTransferObject<List<OrderDTO>>? GetOrders()
        {
            NetworkTransferObject<List<OrderDTO>> orders = _orderManager.GetOrders();

            if (orders.TransferObject == null) return null;

            return orders;
        }

        [HttpGet("GetOrders/{id}")]
        public NetworkTransferObject<OrderDTO> GetOrder(Guid id)
        {
            NetworkTransferObject<OrderDTO> order = _orderManager.GetOrder(id);

            if (order.TransferObject == null) return null;

            return order;
        }

        [HttpPost("PostOrder")]
        public Guid? PostOrder([FromBody] NewOrderDTO newOrder)
        {
            Guid? newOrderId = _orderManager.AddNewOrder(newOrder);

            return newOrderId;
        }
    }
}
