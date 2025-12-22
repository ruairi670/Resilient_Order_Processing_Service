using OrdersAPI.Data;
using OrdersAPI.Data.DataTransferObjects;
using OrdersAPI.Data.DataTransferObjects.OrderDTOs;
using OrdersAPI.Data.Tables;

namespace OrdersAPI.DataManagement
{
    public abstract class DataManager
    {
        protected Database Database { get; set; }

        public DataManager()
        {
            Database = new Database();
        }

    }
}
