using OrdersAPI.Data.DataTransferObjects.Base;

namespace OrdersAPI.Data.DataTransferObjects
{
    public class NetworkTransferObject<T>
        //where T : BaseDTO
    {
        public T? TransferObject { get; set; }

        public Exception? Exception { get; set; }

        public NetworkTransferObject(T? transferObject, Exception? exception)
        {
            TransferObject = transferObject;
            Exception = exception;
        }
    }
}
