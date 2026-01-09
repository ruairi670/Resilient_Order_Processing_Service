using DataModels.Data;

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
