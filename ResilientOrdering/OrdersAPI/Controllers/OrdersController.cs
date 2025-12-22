using Microsoft.AspNetCore.Mvc;
using OrdersAPI.Data.DataTransferObjects;
using OrdersAPI.Data.DataTransferObjects.OrderDTOs;
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
        public OrdersController()
        {
            //_logger = logger;
            _orderManager = new OrderManager();
        }

        [HttpGet(Name = "Index")]
        public string Get()
        {
            return "Orders Index";
        }

        [HttpGet("GetOrders")]
        public IEnumerable<OrderDTO> GetOrders()
        {
            NetworkTransferObject<List<OrderDTO>> orders = _orderManager.GetOrders();

            return (List<OrderDTO>)orders.TransferObject;
        }
    }
}
