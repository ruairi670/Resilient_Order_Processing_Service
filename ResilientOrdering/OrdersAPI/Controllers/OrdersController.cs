using Microsoft.AspNetCore.Mvc;
using OrdersAPI.Data.DataTransferObjects;
using OrdersAPI.Data.DataTransferObjects.OrderDTOs;
using OrdersAPI.Data.Tables;
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
        public NetworkTransferObject<OrderDTO> GetOrder(int id)
        {
            NetworkTransferObject<OrderDTO> order = _orderManager.GetOrder(id);

            if (order.TransferObject == null) return null;

            return order;
        }

        [HttpPost("PostOrder")]
        public int? PostOrder([FromBody] NewOrderDTO newOrder)
        {
            int? newOrderId = _orderManager.AddNewOrder(newOrder);

            return newOrderId;
        }
    }
}
